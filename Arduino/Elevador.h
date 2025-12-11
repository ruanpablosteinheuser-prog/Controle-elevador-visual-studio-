#ifndef Elevador_h
#define Elevador_h

class Elevador {

private:

   Botao botao1;
   Sensor sensor1;
   Motor motor1;
 
  


public:
   
   Elevador();

   virtual ~Elevador();

 void iniciaElevador();       // inicia o elevador para no andar em que ele esta caso não esteja em nenhum ele vai até o andar zero 
 void controlaElevador();     // função que implementa toda a logica do programa 
 void setupHardware();        // atribui a pinagem para as I/O;
 
};

#endif