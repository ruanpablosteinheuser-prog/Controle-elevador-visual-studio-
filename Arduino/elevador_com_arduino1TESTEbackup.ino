#include "motor.h"
#include "botao.h"
#include "sensor.h"
#include "Elevador.h"

//INSTANCIA DE OBJETOS

Elevador elevador1;

void setup() {
  Serial.begin(9600);
elevador1.setupHardware(); 
elevador1.iniciaElevador();

}


void loop() {
 elevador1.controlaElevador();

}
