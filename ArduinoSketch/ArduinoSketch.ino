#include <SoftwareSerial.h>

SoftwareSerial mySerial(8, 9); // RX | TX

#define KEY 7
#define LED 13
bool window_stata_open = false;
bool manual = false;
String var;

int in1 = 2;
int in2 = 3;

void setup() {
  pinMode(KEY, OUTPUT);
  digitalWrite(KEY, LOW);
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  delay(3000);
  Serial.begin(9600);
  mySerial.begin(38400);
  // configure_HC05();
}

void loop() {
  openfan();
  if (manual) {
    if (mySerial.available() > 0) {
      var = mySerial.read();
      // Chuyển đổi var sang ký tự và so sánh
      if (var == "120") {
        digitalWrite(LED, HIGH);
        // Serial.println(var);
      } else if (var == "0") {
        digitalWrite(LED, LOW);
        // Serial.println(var);
      } else if (var == "248") {
        manual = !manual;
        // Serial.println(var);
      }
    }
  }
  else{
    if (mySerial.available() > 0) {
      var = mySerial.read();
      if (var == "248") {
        manual = !manual;
      }
    }
    int SensorValue = analogRead(A0);
    Serial.println(SensorValue);
    // while(analogRead(A0) > 400){
    //   openfan()
    // }
    //closefan()
    int led_analog_write = map(SensorValue, 0, 1023, 0, 255);
    analogWrite(LED, led_analog_write);
    delay(1000);
    // mySerial.write(SensorValue);
  }
}

void configure_HC05() {
  digitalWrite(KEY, HIGH); // Set KEY high to enter AT mode
  delay(2000);
  Serial.println("Entering AT mode...");
  
  mySerial.println("AT");
  delay(2000);
  
  if (!mySerial.find("OK")) {
    Serial.println("Failed to enter AT mode.");
  }

  mySerial.println("AT+RMAAD");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to clear paired devices.");
  }

  mySerial.println("AT+NAME=Nhom11-Bluetooth");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to set name.");
  } else {
    Serial.println("New name: Nhom11-Bluetooth");
  }

  mySerial.println("AT+PSWD=1234");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to set password.");
  } else {
    Serial.println("New password: 1234");
  }

  mySerial.println("AT+ROLE=0");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to set role.");
  } else {
    Serial.println("New role: SLAVE");
  }

  mySerial.println("AT+RESET");
  delay(2000);
  if (!mySerial.find("OK")) {
    Serial.println("Failed to reset HC-05.");
  }

  digitalWrite(KEY, LOW); // Set KEY low to exit AT mode
  
  Serial.println("Bluetooth Ready!");
}

void openfan() {
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
}

void closefan() {
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
}