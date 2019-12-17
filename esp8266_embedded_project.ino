#include <MicroGear.h>
#include <ESP8266WiFi.h>

const char* ssid     = "Keng";
const char* password = "Kengfreewifi";

#define APPID   "esp8266Project"
#define KEY     "sagrUhQu9KuT5EP"
#define SECRET  "11Oa3xUQHWNiiMJAyTCvmapLc"

#define ALIAS   "NodeMCU1"
#define TargetWeb "HTML_web"

#define D6 12   // slot 1
#define D7 13   // slot 2

WiFiClient client;
MicroGear microgear(client);

void onMsghandler(char *topic, uint8_t* msg, unsigned int msglen) 
{
    Serial.print("Incoming message --> ");
    msg[msglen] = '\0';
    Serial.println((char *)msg);
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

    Serial.begin(115200);
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
    if (microgear.connected())
    {
       microgear.loop();
       Serial.println("connected");

       char msg[2] = { digitalRead(D6) + '0', digitalRead(D7) + '0' };
       Serial.println(msg);
/*
       float Humidity = dht.readHumidity();
       float Temp = dht.readTemperature();  // Read temperature as Celsius (the default)
       String data = "/" + String(Humidity) + "/" + String(Temp);

       data.toCharArray(msg,data.length());
           
*/
       microgear.chat(TargetWeb , msg);
    }
   else 
   {
    Serial.println("connection lost, reconnect...");
    microgear.connect(APPID);
   }
    delay(100);
}
