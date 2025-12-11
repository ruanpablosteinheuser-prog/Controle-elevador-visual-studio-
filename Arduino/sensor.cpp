#include "sensor.h"
#include <arduino.h>


Sensor::Sensor (){ //construtor do sensor

}

Sensor::~Sensor (){ // destrutor

}

void Sensor::setupSensor(){   //função que define como os pinos irão trabalhar 

  this->sensor0 = 8;
  this->sensor1 = 7;
  this->sensor2 = 6;
  this->sensor3 = 4;
 
  pinMode(sensor0,INPUT_PULLUP);
  pinMode(sensor1,INPUT_PULLUP);
  pinMode(sensor2,INPUT_PULLUP);
  pinMode(sensor3,INPUT_PULLUP);

}



void Sensor::verificaSensor(){    //função que verifica o estado do sensor
  if (digitalRead(sensor0) == LOW){andarAtual = 0;
    }else if (digitalRead(sensor1) == LOW){andarAtual = 1;
      }else if (digitalRead(sensor2) == LOW){andarAtual = 2;
        }else if (digitalRead(sensor3) == LOW){andarAtual = 3;
  }
}

void Sensor::setAndarAtual(){     // método da classe sensor que inicializa a variavel andar atual
  this->andarAtual = 99;          // inicialização da variavel andar atual com valor de 99
}
int Sensor::getAndarAtual(){      // método da classe sensor que retorna o valor de andar atual 
  return this->andarAtual;        //retorna valor da variavel andar atual 
}