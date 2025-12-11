#include "motor.h"
#include <arduino.h>

Motor::Motor () { // construtor
  
}

Motor:: ~Motor (){
    //destrutor 
}

//DEFINI O MODO DE OPERAÇÃO DE CADA PINO 
 
 void Motor::setupMotor(){
   
   this-> motorSubir = 5;
   this->motorDescer = 3;

   pinMode(motorSubir,OUTPUT);
   pinMode(motorDescer,OUTPUT);
  
}

//ACIONAMENTO PARA MOTOR SUBIR
 void Motor::MotorSubir(){
   digitalWrite(motorSubir, HIGH);
   digitalWrite(motorDescer,LOW);
}
//ACIONAMENTO PARA MOTOR DESCER
  void Motor::MotorDescer(){
   digitalWrite(motorSubir,LOW);
   digitalWrite(motorDescer,HIGH);
}
//DESACIONAMENTO (DESLIGA O  MOTOR)
 void Motor::DesligaMotor(){
   digitalWrite(motorSubir,LOW);
   digitalWrite(motorDescer,LOW);
  }





