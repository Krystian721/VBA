//Piny sensor 1
int echoPin = 2;
int trigPin = 3;
String pomiar = "1";
//Piny sensor 2
int analogPin = 0;


void setup() {
  pinMode(echoPin, INPUT);
  pinMode(trigPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()>0)
    pomiar = Serial.read();
  if (pomiar == "1"){
  digitalWrite(trigPin, HIGH);
  delay(200);
  digitalWrite(trigPin, LOW);
  int odleglosc = pulseIn(echoPin, HIGH);
  int temperatura = analogRead(analogPin);
  delay(200);
  Serial.print(odleglosc); 
  Serial.print(";");
  Serial.println(temperatura);
  }
}
