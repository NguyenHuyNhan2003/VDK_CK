#include <SoftwareSerial.h>
#include <Servo.h>

Servo myServo;
SoftwareSerial mySerial(8, 9); // RX | TX
#define SERVO 6
#define KEY 7
#define LED 13
bool is_manual = true;
String data_received;
int SensorValue = 0;
int Fan_pin1 = 2;
int Fan_pin2 = 3;

void setup() {
  // pinMode(KEY, OUTPUT);
  digitalWrite(KEY, LOW);
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
  pinMode(Fan_pin1, OUTPUT);
  pinMode(Fan_pin2, OUTPUT);

  Serial.begin(9600);
  mySerial.begin(38400);
  myServo.attach(SERVO);
  // configure_HC05();
}

void loop() {
  if (is_manual) {
    if (mySerial.available()) {
      data_received += mySerial.read();
      Serial.print("New data: ");
      Serial.println(data_received);
      if (data_received == "120128") {
        digitalWrite(LED, HIGH);
        myServo.write(0); // open window
        Serial.println("window opened");
        data_received = "";
      } else if (data_received == "0128") {
        digitalWrite(LED, LOW);
        myServo.write(90); // close window
        Serial.println("window closed");
        data_received = "";
      } else if (data_received == "248128128") {
        is_manual = !is_manual; // change mode
        Serial.println("change mode");
        data_received = "";
      } else if (data_received == "0248128") {
        openfan(); // run fan
        Serial.println("fan running");
        data_received = "";
      } else if (data_received == "120248128") {
        closefan(); // stop fan
        Serial.println("fan stopped");
        data_received = "";
      } else if (data_received == "-1"){
        data_received = "";
      }
    }
  }
  else{
    if (mySerial.available() > 0) {
      data_received += mySerial.read();
      Serial.print("New data: ");
      Serial.println(data_received);
      if (data_received == "248128128") {
        is_manual = !is_manual;
        Serial.println("change mode"); // change mode
        data_received = "";
      }
    }
    SensorValue = analogRead(A0);
    Serial.println(SensorValue);
    delay(1000);
    while(analogRead(A0) > 200){
      openfan();
      SensorValue = analogRead(A0);
      Serial.println(SensorValue);
      int led_analog_write = map(SensorValue, 0, 1023, 0, 255);
      analogWrite(LED, led_analog_write);
    }
    closefan();
    // mySerial.write(SensorValue);
  }
}

void openfan() {
  digitalWrite(Fan_pin1, HIGH);
  digitalWrite(Fan_pin2, LOW);
}

void closefan() {
  digitalWrite(Fan_pin1, LOW);
  digitalWrite(Fan_pin2, LOW);
}

// configuring hc-05
void configure_HC05() {
  // digitalWrite(KEY, HIGH); // Set KEY high to enter AT mode
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

  // digitalWrite(KEY, LOW); // Set KEY low to exit AT mode
  
  Serial.println("Bluetooth Ready!");
}