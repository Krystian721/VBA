//Piny sensor 1
int echoPin = 2;
int trigPin = 3;
char start;


void setup() {
  pinMode(echoPin, INPUT);
  pinMode(trigPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(trigPin, HIGH);
  delay(10);
  digitalWrite(trigPin, LOW);
  int odleglosc = pulseIn(echoPin, HIGH);
  delay(10);
  if (Serial.available()>0)
    start = Serial.read();
  Serial.println(start);   
}
