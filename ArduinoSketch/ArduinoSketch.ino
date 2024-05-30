#include <SoftwareSerial.h>

SoftwareSerial mySerial(8, 9); // RX | TX

#define KEY 7
#define LED 13
bool AT;
String var;

void setup() {
  pinMode(KEY, OUTPUT);
  digitalWrite(KEY, LOW);
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
  delay(3000);
  Serial.begin(9600);
  mySerial.begin(38400);
  // configure_HC05();
  AT = true;
}

void loop() {
  if (AT) {
    if (mySerial.available() > 0) {
      

      var = mySerial.read();
      // Chuyển đổi var sang ký tự và so sánh
      if (var == "120") {
        digitalWrite(LED, HIGH);
        Serial.println(var);
      } else if (var == "0") {
        digitalWrite(LED, LOW);
        Serial.println(var);
      } else if (var == "248") {
        digitalWrite(LED, LOW);
        delay(1000);
        digitalWrite(LED, HIGH);
        delay(1000);
        digitalWrite(LED, LOW);
        Serial.println(var);
      }
    }
    int SensorValue = analogRead(A0);
    // Serial.println(SensorValue);
    // delay(1000);
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