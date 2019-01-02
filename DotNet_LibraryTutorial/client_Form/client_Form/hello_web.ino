#include <ESP8266WiFi.h>
#include <WiFiClient.h>
#include <ESP8266WebServer.h>
#include <ESP8266mDNS.h>

const char* ssid     = "PenguinInTheHouse";
const char* password = "26821731";

ESP8266WebServer server(80);
#define LED_Blue 2
#define RY1 13
void handleRoot() {
  digitalWrite(LED_Blue, 1);
  server.send(200, "text/plain", "hello LEE from esp8266!");
  digitalWrite(RY1, !digitalRead(RY1));
 }

void handleNotFound(){
  digitalWrite(LED_Blue, 1);
  String message = "File Not Found\n\n";
  message += "URI: ";
  message += server.uri();
  message += "\nMethod: ";
  message += (server.method() == HTTP_GET)?"GET":"POST";
  message += "\nArguments: ";
  message += server.args();
  message += "\n";
  for (uint8_t i=0; i<server.args(); i++){
    message += " " + server.argName(i) + ": " + server.arg(i) + "\n";
  }
  server.send(404, "text/plain", message);
  digitalWrite(LED_Blue, 0);
}

void setup(void){
  pinMode(LED_Blue, OUTPUT);
  pinMode(RY1, OUTPUT);
  digitalWrite(LED_Blue, 0);
  Serial.begin(115200);
  WiFi.begin(ssid, password);
  Serial.println("");

  // Wait for connection
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Connected to ");
  Serial.println(ssid);
  Serial.print("IP address: ");
  Serial.println(WiFi.localIP());

  if (MDNS.begin("esp8266")) {
    Serial.println("MDNS responder started");
  }

  server.on("/", handleRoot);

  server.on("/inline", [](){server.send(200, "text/plain", "this works as well");});
  server.on("/hello", [](){server.send(200, "text/plain", "hello client");});
  server.on("/yes", [](){server.send(200, "text/plain", "yes too");});
  
  //server.onNotFound(handleNotFound);
  server.onNotFound([](){server.send(200, "text/plain", "Not Found");});

  server.begin();
  Serial.println("HTTP server started");
}

void loop(void){
  server.handleClient();
}
