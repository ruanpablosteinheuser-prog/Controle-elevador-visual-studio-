#include <arduino.h>
#include "botao.h"
#include "sensor.h"
#include "motor.h"
#include "Elevador.h"

Elevador::Elevador() {}

Elevador::~Elevador() {}

void Elevador::setupHardware() {
  motor1.setupMotor();
  sensor1.setupSensor();
  botao1.setupBotao();
  botao1.setChamadaAndar();    // chamadaAndar = -1
  sensor1.setAndarAtual();     // andarAtual = 99
}

void Elevador::iniciaElevador() {  // metodo para inicializar o elevador 
  motor1.DesligaMotor();           // deliga o motor por segurança 
  sensor1.verificaSensor();        // verifica se algum sensor esta acionado 
  delay(200);

  if (sensor1.getAndarAtual() == 99) {  // não está em nenhum andar conhecido
    motor1.MotorDescer();               // liga o motor para descer
    while (sensor1.getAndarAtual() != 0) {    // enquanto a variavel chamada andar for diferente de zero então
      sensor1.verificaSensor();               // verifica qual sensor esta acionado
      delay(100);
    }
    motor1.DesligaMotor();            // quando chamada andar for igual a zero então desliga o motor         

  }
}


void Elevador::controlaElevador() {     //metodo para controlar o elevador 

  
  botao1.receberAndarExterno(); //metodo do botão para receber um andar da interface gráfica
  botao1.acionamentoBotao();    //metodod para verificar se algum botão foi acionado e atribuir o valor a variavel chamadaAndar

  
  if (botao1.getChamadaAndar() != -1) {   //se chamada andar for diferente de -1 então 
    if (botao1.adicionarAndar()) {        // se algum andar for adicionado a fila então
      botao1.enviarFilaInterface();  // envia fila para a interface grafica
    }
    botao1.setChamadaAndar();  // reseta a variavel chamda andar para -1
  }

  
  int destino = botao1.pegarProximoAndar(); // variavel destino recebe o primeiro elemento do vetor 
  if (destino == -1) {                      // se destino é -1 então o elevador fica parado 
    motor1.DesligaMotor();  // fila vazia então o elevador fica parado
    return;
  }

  
  sensor1.verificaSensor();                // verifica se algum sensor esta acionado 
  int atual = sensor1.getAndarAtual();    // variavel atual recebe o chamadaAndar

 
  if (atual == destino) {           // se atual é igual a destino então
    motor1.DesligaMotor();          // desliga o motor 
    delay(800);                    // tempo parado  em um andar
    botao1.rodarFila();            // remove o andar da fila
    botao1.enviarFilaInterface();  // atualiza interface
    return;
  }

  
  if (atual < destino) {        // se a valor da variavel atual é menor que o valor da  variavel destino
    motor1.MotorSubir();  // motor liga para subir 

    
    while (sensor1.getAndarAtual() != destino) { // enqunanto sensor for diferente de destino então 
      sensor1.verificaSensor();                   // verifica sensor acionado 

      
      botao1.receberAndarExterno(); // verifica se chegou algum andar pela serial 
      botao1.acionamentoBotao();     // verifica se algum botão foi acionado 
      if (botao1.getChamadaAndar() != -1) { // se o valor da variavel chamada andar é diferente de -1 então
        if (botao1.adicionarAndar()) {      // se adiciona um novo andar a fila então
          botao1.enviarFilaInterface();     // envia fila atual para a interface 
        }
        botao1.setChamadaAndar();         // reseta a variavel chamada andar para -1 
      }
      delay(50);
    }
  }
  
  else if (atual > destino) {     //se o valor da variavel atual for maior que o valor da variavel destino 
    motor1.MotorDescer();  // liga motor para descer 

    while (sensor1.getAndarAtual() != destino) {  // enquanto chamada andar for diferente de destino 
      sensor1.verificaSensor();                   // verifica se algum sensor foi acionado 

      botao1.receberAndarExterno();             // verifica se algum andar foi recebido pela serial 
      botao1.acionamentoBotao();                // verifica se o botão seja acionado 
      if (botao1.getChamadaAndar() != -1) {     // verifica se o valor da variavel chamada andar é diferente de -1 então
        if (botao1.adicionarAndar()) {          // adiciona andar a fila 
          botao1.enviarFilaInterface();         // envia a fila atualizada para a interface 
        }
        botao1.setChamadaAndar();         //reseta a cariavel chamada andar para -1 
      }
      delay(50);
    }
  }

 
  motor1.DesligaMotor(); // caso tenha chegado no andar então ele desliga o motor
  delay(800);
  botao1.rodarFila();   // roda a fila de andares 
  botao1.enviarFilaInterface();   // envai a fila atualizada para a interface 
}


