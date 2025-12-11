#ifndef sensor_h
#define sensor_h

class Sensor { //classe sensor

private:        //atributos privados
 int sensor0;
 int sensor1;
 int sensor2;
 int sensor3;
 int andarAtual;

public: // assinaturas de metodos e cosntrutores 

Sensor (); // construtor

virtual ~Sensor(); //destrutor

void setupSensor(); //método que define o setup da pinagem
void verificaSensor(); //método que verifica o estado dos sensores

// SETTER
void setAndarAtual();   //MÉTODO QUE INICIALIZA ANDAR ATUAL

//GETTER
int getAndarAtual();    // MÉTODO QUE RETORNA O VALOR DE ANDAR ATUAL 




};

#endif