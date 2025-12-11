#ifndef botao_h
#define botao_h

class Botao {  //CLASSE
  private:    //ATRIBUTOS
   int botao0;
   int botao1;
   int botao2;
   int botao3;
   int chamadaAndar;
   char valor;
   int andarExterno;
   int filaInterface;
  
  const int tamanhoMaximo = 5;    //tamanho maximo do vetor
  int filaDeAndares[5] = {0};   //vetor fila de andares com tamanho 5
  int tamanho = 0 ;     //tamanho, para verificar se o vetor tem espaço sobrando e pra rodar a fila 
   

  public: //ASSINATURAS

  Botao (); //CONSTRUTOR

  virtual ~Botao (); //DESTRUTOR

   void setupBotao ();   //ASSINATURA FUNÇÃO QUE DEFINE A PINAGEM DOS BOTÕES 
   void acionamentoBotao();  //ASSINATURA FUNÇÃO ACIONAMENTO DOS BOTÕES 
   bool adicionarAndar();   //assinatura função adiciona andar a fila de andares
   bool rodarFila();        //assinatura do metodo que roda a fila de andares 
   int pegarProximoAndar();
   void receberAndarExterno();
   void enviarFilaInterface();

//SETTERS
  
  void setChamadaAndar();   //metodo que inicializa a variavel chamadaAndar com -1 

//GETTERS
  
  int getChamadaAndar(); //metodo que pega o valor da variavel chamadaAndar

};

#endif