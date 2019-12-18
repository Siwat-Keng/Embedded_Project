#include <MicroGear.h>
#include <ESP8266WiFi.h>
#include <SoftwareSerial.h>

const char* ssid     = "Keng";
const char* password = "Kengfreewifi";

#define APPID   "esp8266Project"
#define KEY     "sagrUhQu9KuT5EP"
#define SECRET  "11Oa3xUQHWNiiMJAyTCvmapLc"

#define ALIAS   "NodeMCU1"
#define Target "VisualStudio"

#define RX 12   // slot 1
#define TX 13   // slot 2

WiFiClient client;
MicroGear microgear(client);

uint32_t timer;
char msgOut[2];
char msgIn[2];
char* temp;
SoftwareSerial chat(RX, TX);

void onMsghandler(char *topic, uint8_t* msg, unsigned int msglen) 
{
    msg[msglen] = '\0';
    temp = (char*) msg;
    Serial.println(temp);
    chat.write(temp);
}

void onConnected(char *attribute, uint8_t* msg, unsigned int msglen) 
{
    Serial.println("Connected to NETPIE...");
    microgear.setAlias(ALIAS);
}

void setup() {
     /* Event listener */
    microgear.on(MESSAGE,onMsghandler);
    microgear.on(CONNECTED,onConnected);
    
    pinMode(RX, INPUT);
    pinMode(TX, OUTPUT);
    
    Serial.begin(115200);
    chat.begin(115200);
    
    Serial.println("Starting...");

    WiFi.begin(ssid, password);
    while (WiFi.status() != WL_CONNECTED) 
    {
       delay(250);
       Serial.print(".");
    }

    Serial.println("WiFi connected");  
    Serial.println("IP address: ");
    Serial.println(WiFi.localIP());

    microgear.init(KEY,SECRET,ALIAS);
    microgear.connect(APPID);
    
}

void loop() {
  
    if (chat.available() >= 2){
       msgOut[0] = chat.read();
       msgOut[1] = chat.read();
    }
    
    if (microgear.connected())
    {
       microgear.loop();
       
       if (timer >= 1000){
          Serial.println(msgOut);
          microgear.chat(Target , msgOut);
          timer = 0;
       }
       else timer += 10;
    }
    else{
       Serial.println("connection lost, reconnect...");  
       if (timer >= 5000){
          microgear.connect(APPID);
          timer = 0;   
       }
       else timer += 10;
    }
    delay(10);
}
