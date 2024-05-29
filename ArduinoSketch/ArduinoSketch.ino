#include <SoftwareSerial.h>

SoftwareSerial mySerial(8, 9); // RX | TX

#define KEY 7
#define LED 13
bool ok;
int var;
String bf = "";

void setup() {
  pinMode(KEY, OUTPUT);
  digitalWrite(KEY, LOW);
  pinMode(LED, OUTPUT);
  delay(3000);
  Serial.begin(9600);
  mySerial.begin(38400);
  ok = configure_HC05();
}

void loop() {
  if (ok) {
    if (mySerial.available() > 0) {
      var = mySerial.read();
      mySerial.println(var);
      
      // Chuyển đổi var sang ký tự và so sánh
      if (var == '1') {
        digitalWrite(LED, HIGH);
      } else if (var == '0') {
        digitalWrite(LED, LOW);
      }
    }
  }
}

bool configure_HC05() {
  digitalWrite(KEY, HIGH); // Set KEY high to enter AT mode
  delay(2000);
  Serial.println("Entering AT mode...");
  
  mySerial.println("AT");
  delay(2000);
  
  if (!mySerial.find("OK")) {
    Serial.println("Failed to enter AT mode.");
    return false;
  }

  mySerial.println("AT+RMAAD");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to clear paired devices.");
    return false;
  }

  mySerial.println("AT+NAME=Nhom11-Bluetooth");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to set name.");
    return false;
  } else {
    Serial.println("New name: Nhom11-Bluetooth");
  }

  mySerial.println("AT+PSWD=1234");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to set password.");
    return false;
  } else {
    Serial.println("New password: 1234");
  }

  mySerial.println("AT+ROLE=0");
  delay(2000);

  if (!mySerial.find("OK")) {
    Serial.println("Failed to set role.");
    return false;
  } else {
    Serial.println("New role: SLAVE");
  }

  mySerial.println("AT+RESET");
  delay(2000);
  if (!mySerial.find("OK")) {
    Serial.println("Failed to reset HC-05.");
    return false;
  }

  digitalWrite(KEY, LOW); // Set KEY low to exit AT mode
  
  Serial.println("Bluetooth Ready!");

  return true;
}
