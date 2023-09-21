#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 10
#define RST_PIN 9

MFRC522 rfid(SS_PIN, RST_PIN);

const int GreenLed = 3; const int RedLed = 4;

void setup() {
  pinMode(RedLed, OUTPUT); //Red Led
  pinMode(GreenLed, OUTPUT); //Green Led
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
  digitalWrite(RedLed, 1); 
}

void loop() {
  if (rfid.PICC_IsNewCardPresent() && rfid.PICC_ReadCardSerial()) {
    String content = "";
    for (byte i = 0; i < rfid.uid.size; i++) {
      content.concat(String(rfid.uid.uidByte[i]<0x10 ? " 0":" "));
      content.concat(String(rfid.uid.uidByte[i], HEX));
    }
    Serial.print(content.substring(1, 12));
    Serial.println();
    rfid.PICC_HaltA();
    digitalWrite(GreenLed, 1);  
    if (content == content)
    {
      digitalWrite(RedLed, 1);
      led();  
      digitalWrite(RedLed, 1);
    } 
    else{
      digitalWrite(RedLed, 1);
    }
  }
}

void led() {  
  digitalWrite(RedLed, 0);
  for (int i = 0; i <= 10; i++){
    digitalWrite(GreenLed, 1);
    delay(100);
    digitalWrite(GreenLed, 0);
    delay(100);
  }
}
