#include <SoftwareSerial.h>
#include <Servo.h>

Servo myServo;
SoftwareSerial mySerial(8, 9); // RX | TX
#define SERVO 6
#define KEY 7
#define LED 13
bool is_manual = false;
bool found_new_data = false;
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
  handle_received_data();
  if (!found_new_data){
    int SensorValue = analogRead(A0);

    String mode = "";
    if (is_manual){
      mode = "Manual Mode : ";
    }
    else{
      mode = "Auto Mode : ";
    }
    Serial.print(mode);
    Serial.println(SensorValue);
    delay(1000);

    int led_analog_write = map(SensorValue, 0, 1023, 0, 255);
    analogWrite(LED, led_analog_write);

    if(!is_manual && SensorValue >= 200){
      myServo.write(0);
      openfan();
    }else if (!is_manual && SensorValue < 200){
      myServo.write(90);
      closefan();
    }
  }
  // mySerial.write(SensorValue);
}

void handle_received_data(){
  if (mySerial.available()) {
    data_received += mySerial.read();
    found_new_data = true;

    Serial.print("New data: ");
    Serial.println(data_received);
    if (data_received == "120128" && is_manual) {
      myServo.write(0); // open window
      Serial.println("window opened");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "0128" && is_manual) {
      myServo.write(90); // close window
      Serial.println("window closed");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "248128128") {
      is_manual = !is_manual; // change mode
      Serial.println("change mode");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "0248128" && is_manual) {
      openfan(); // run fan
      Serial.println("fan running");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "120248128" && is_manual) {
      closefan(); // stop fan
      Serial.println("fan stopped");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "-1"){
      data_received = "";
    } else if ((data_received == "0128" || data_received == "120128" || data_received == "0248128"  || data_received == "120248128") && is_manual == false) {
      data_received = "";
      found_new_data = false;
    } else if (data_received == "128128128"){
      is_manual = false;
      data_received = "";
      found_new_data = false;
    }
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