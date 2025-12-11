#include "botao.h"
#include <arduino.h>

  
//COSNTRUTOR
Botao::Botao(){
  
}

//DESTRUTOR
Botao::~Botao(){

}
//MÉTODO DEFINE A PINAGEM E MODO DE TRABALHO DE CADA PINO 
void Botao::setupBotao(){
  
  this->botao0 = 21;
  this->botao1 = 20;
  this->botao2 = 19;
  this->botao3 = 18;
  
  pinMode(botao0,INPUT_PULLUP);
  pinMode(botao1,INPUT_PULLUP);
  pinMode(botao2,INPUT_PULLUP);
  pinMode(botao3,INPUT_PULLUP);
  

}
void Botao::receberAndarExterno(){
  if(Serial.available()){   // verifica se tem algo na porta serial caso sim então
    int valor = Serial.peek(); //A varivel valor recebe o próximo byte sem utilizar ele  
    if (valor >= '0' && valor <= '3') { // se o valor da variavel  estiver entre 0 e 3 então 
     andarExterno = Serial.parseInt(); // andar externo recebe o valor inteiro lido na serial pela função parseInt
    }else{
      Serial.read(); // descarta lixo 
    }
  }
}
//MÉTODO QUE DEFINE O FUNCIONAMENTO DOS BOTÕES
void Botao::acionamentoBotao(){

  if(digitalRead(botao0) == HIGH){chamadaAndar = 0;
    }else if (digitalRead(botao1) == HIGH){ chamadaAndar = 1;    /// ALTERADO PARA LOW CASO NÃO FUNCIONE TROCAR PARA HIGH NOVAMENTE 
      }else if (digitalRead(botao2) == HIGH){chamadaAndar = 2;
        }else if (digitalRead(botao3) == HIGH){chamadaAndar = 3;
          }else if(andarExterno >= 0 && andarExterno <= 3){
            chamadaAndar = andarExterno;
            andarExterno = -1;
              }   
}

//MÉTODO QUE ADICIONA UM NOVO ANDAR A FILA 
bool Botao::adicionarAndar(){     //MÉTODO DA CLASSE BOTÃO ADICIONA ANDAR A FILA 
  if (chamadaAndar == -1)return false;    // SE CHAMADA ANDAR = -1 ENCERRA A FUNÇÃO ADICIONA ANDAR
  if(tamanho < tamanhoMaximo){      // SE TAMANHO DO VETOR É MENOR QUE O TAMANHO MÁXIMO ENTÃO:
      for (int i = 0; i < tamanho; ++i) {   // PARA I MENOR QUE TAMANHO, INCREMENTA 1
      if (filaDeAndares[i] == chamadaAndar) {   // SE FILA DE ANDARES COM INDICE I = CHAMADA ANDAR ATRIBUI -1 PARA CHAMADA ANDAR
        chamadaAndar = -1;                       // ADICIONA -1 A CHAMADA ANDAR PARA NÃO TER CHAMADAS DUPLICADAS 
        return false;
      }
    }
    filaDeAndares[tamanho++] = chamadaAndar;
    chamadaAndar = -1; // reset após adicionar
    return true;
  }
  return false;
}

bool Botao::rodarFila(){          //MÉTODO DA CLASSE BOTÃO PARA RODAR A FILA 
  if(tamanho > 0){                // SE O TAMANHO É MENOR QUE 0 ENTÃO:
    for(int i = 0; i < tamanho - 1; i++){      // PARA I COMEÇANDO EM 0, ENQUANTO I FOR MENOR QUE TAMANHO -1, INCREMENTA MAIS 1
    filaDeAndares[i] = filaDeAndares[i+1];    //VETOR FILA DE ANDARES COM TAMANHO I RECEBE VETOR FILA DE ANDARES COM INDICE I +1 
    }
  tamanho--;    // TAMANHO DECREMENTA 1
  
  return true;

  }
  return false;
}

int Botao::pegarProximoAndar(){     // função para pegar o próximo andar de destino do elevador 
  if(tamanho > 0) return filaDeAndares[0];                 // verifica se a fila não esta vazia e então retorna o valor que esta guardado no indice 0 do vetor    
    return  -1;                       // se não retorna -1 que significa que a fila está  vazia 
  
}

void Botao::setChamadaAndar(){    // MÉTODO DA CLASSE BOTÃO QUE INICIALIZA A VARIAVEL CHAMADA ANDAR COM -1 
  chamadaAndar = -1;              // CHAMADA ANDAR RECEBE -1 
}
int Botao::getChamadaAndar(){     // MÉTODO DA CLASSE BOTÃO PEGA O VALOR DA VARÍAVEL CHAMADA ANDAR
  return this->chamadaAndar;      // RETORNA PARA O MÉTODO O VALOR DE CHAMADA ANDAR
}

void Botao::enviarFilaInterface(){ // metodo para enviar os elementos da fila via porta serial
  for(int i = 0; i < tamanho; i++){ // laço for para correr o vetor 
    filaInterface = filaDeAndares[i]; // a variavel guarda o elemento do indice 
    Serial.print(filaInterface); // envia o conteudo da variavel que é um elemento do vetor fila para  a inteface
    Serial.print(","); // envia uma virgula 
  }
  Serial.println();
}