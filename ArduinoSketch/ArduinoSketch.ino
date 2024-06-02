#include <SoftwareSerial.h>
#include <Servo.h>
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27, 16, 2);

Servo myServo;
SoftwareSerial mySerial(8, 9); // RX | TX

#define SERVO 5
#define KEY 7
#define LED 6
#define Fan_pin1 12
#define Fan_pin2 13

bool is_manual = false;
bool found_new_data = false;
String data_received;

void setup() {
  // pinMode(KEY, OUTPUT);
  // digitalWrite(KEY, LOW);
  pinMode(LED, OUTPUT);
  pinMode(Fan_pin1, OUTPUT);
  pinMode(Fan_pin2, OUTPUT);

  lcd.init(); // Khởi động màn hình
  lcd.backlight();

  Serial.begin(9600);
  mySerial.begin(38400);
  myServo.attach(SERVO);
  // configure_HC05();
}

void loop() {

  // find_LCD_I2C();

  handle_received_data();
  if (!found_new_data){
    int SensorValue = analogRead(A0);

    String mode = "";
    if (is_manual){
      mode = "Manual";
    }
    else{
      mode = "Auto";
    }
    
    Serial.print(mode);
    Serial.print(" Mode: ");
    Serial.println(SensorValue);
    Display_On_LCD(SensorValue, mode);
    delay(1000);

    // int led_analog_write = map(SensorValue, 0, 1023, 0, 255);
    // analogWrite(LED, led_analog_write);

    if (SensorValue >= 700){
      digitalWrite(LED, HIGH);
    } else {
      digitalWrite(LED, LOW);
    }

    if(!is_manual && SensorValue >= 700){ // detect smoke
      myServo.write(0);
      openfan();
    }else if (!is_manual && SensorValue < 700){
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

    // Serial.print("New data: ");
    // Serial.println(data_received);
    if (data_received == "120128" && is_manual) {
      myServo.write(0); // open window
      Serial.println("Window opened");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "0128" && is_manual) {
      myServo.write(90); // close window
      Serial.println("Window closed");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "248128128") {
      is_manual = !is_manual; // change mode
      Serial.println("Change mode");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "0248128" && is_manual) {
      openfan(); // run fan
      Serial.println("Fan running");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "120248128" && is_manual) {
      closefan(); // stop fan
      Serial.println("Fan stopped");
      data_received = "";
      found_new_data = false;
    } else if (data_received == "-1" || data_received.length() > 9){
      data_received = "";
    } else if ((data_received == "0128" || data_received == "120128" || data_received == "0248128"  || data_received == "120248128") && is_manual == false) {
      data_received = "";
      found_new_data = false;
    } else if (data_received == "128128128"){
      is_manual = false;
      data_received = "";
      found_new_data = false;
      Serial.println("Auto mode");
    }
  }
}

void Display_On_LCD(int sensorValue, String mode){
  lcd.clear();
  lcd.setCursor(0, 0);
  // lcd.print(mode + " Mode: ");
  // lcd.setCursor(0, 1);
  // lcd.print(sensorValue);

  lcd.print(mode + " Mode: " + String(sensorValue));
  
  // Calculate the number of characters to black out
  int blackBlocks  = map(sensorValue, 0, 1023, 0, 16);
  
  lcd.setCursor(0, 1);
  for (int i = 0; i < 16; i++) {
      if (i < blackBlocks) {
          lcd.write(0xFF); // Write black block character
      } else {
          lcd.print(" "); // Write space character
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


void find_LCD_I2C(){
  byte error, address;
  int nDevices;
  Serial.println("Scanning...");
 
  nDevices = 0;
  for(address = 1; address < 127; address++ )
  {
    // The i2c_scanner uses the return value of
    // the Write.endTransmisstion to see if
    // a device did acknowledge to the address.
    Wire.beginTransmission(address);
    error = Wire.endTransmission();
 
    if (error == 0)
    {
      Serial.print("I2C device found at address 0x");
      if (address<16)
        Serial.print("0");
      Serial.print(address,HEX);
      Serial.println("  !");
 
      nDevices++;
    }
    else if (error==4)
    {
      Serial.print("Unknown error at address 0x");
      if (address<16)
        Serial.print("0");
      Serial.println(address,HEX);
    }    
  }
  if (nDevices == 0)
    Serial.println("No I2C devices found\n");
  else
    Serial.println("done\n");
}