#ifndef motor_h
#define motor_h

#include <arduino.h>

class Motor {   //classe
  private:    //atributos
  int motorSubir;
  int motorDescer;
  
  public:
     
     Motor(); //construtor

      virtual ~Motor(); // destrutor
  

  void MotorSubir(); //assinatura função que aciona o motor para subir 
  void MotorDescer(); //assinatura função que aciona o motor para descer 
  void setupMotor(); // assinatura função que define a pinagem o motor
  void DesligaMotor(); // assinatura da função que desliga o motor 
};









#endif 