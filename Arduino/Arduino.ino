//Piny sensor 1
int echoPin = 2;
int trigPin = 3;
char pomiar;


void setup() {
  pinMode(echoPin, INPUT);
  pinMode(trigPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()>0)
    pomiar = Serial.read();
  if (pomiar == 1){
  digitalWrite(trigPin, HIGH);
  delay(10);
  digitalWrite(trigPin, LOW);
  int odleglosc = pulseIn(echoPin, HIGH);
  delay(10);
  String wyslij = odleglosc + ";" + odleglosc;
  Serial.println(wyslij); 
  }  
}
