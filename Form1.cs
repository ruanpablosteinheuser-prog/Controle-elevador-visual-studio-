using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace INTERFACE_DE_APRENDIZADO
{
    
    public partial class Form1 : Form
    {
        string[] portas;
        SerialPort PortaSerial = new SerialPort(); //cria o objeto portaserial
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e) // quando o programa iniacia ele roda o form load
        {
            portas = SerialPort.GetPortNames(); // cria a variavel portas e guarda dentro dela a portas seriais 
            Combo_Ports.Items.AddRange(portas); // adiciona varias portas seriais a combo_ports

            Conectar.Text = "Desconectado";
            Conectar.BackColor = Color.Red;
        }

        private void Combo_Ports_Selecionar_Porta_Serial(object sender, EventArgs e) //seleciona e abre a porta serial 
        { 
             
                PortaSerial.PortName = Combo_Ports.SelectedItem.ToString(); // seleciona a porta serial que for selecionada na combobox
                PortaSerial.BaudRate = 9600; // set do baudrate para 9600
                
            }

        private void Andar_0_Click(object sender, EventArgs e)
        {
            PortaSerial.WriteLine("0"); // caso o botao 0 seja clicado então envia 0 pela serial port
        }

        private void Andar_1_Click(object sender, EventArgs e)
        {
            PortaSerial.WriteLine("1");// caso o botao 1 seja clicado então envia 1 pela serial port
        }

        private void Andar_2_Click(object sender, EventArgs e)
        {
            PortaSerial.WriteLine("2"); // caso o botao 2 seja clicado então envia 2 pela serial port
        }

        private void Andar_3_Click(object sender, EventArgs e)
        {
            PortaSerial.WriteLine("3"); // caso o botao 3 seja clicado então envia 3 pela serial port
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PortaSerial.IsOpen)
                {
                    PortaSerial.Open(); // abre a porta serial que for selecionada 
                    Conectar.Text = "Conectado"; //escreve no botão conectado 
                    Conectar.BackColor = Color.Green; // muda a cor do botão para verde
                    PortaSerial.DataReceived += ReceberFilaDeAndares;
                }
            }
            catch
            {
                Conectar.Text = "Falha ao Conectar"; // escreve no botão 
                Conectar.BackColor = Color.Red; // altera a cor do botão para vermelho 
            }

        }

        private void ReceberFilaDeAndares(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string linha = PortaSerial.ReadLine().Trim(); // a string linha recebe o vetor fila de andares por porta serial

                if (string.IsNullOrWhiteSpace(linha))
                    return;

                linha = linha.TrimEnd(','); // remove a ultima virgula 

                string[] valores = linha.Split(','); // guarda os elementos da variavel linha dentro de um vetor de string separados por virgula

                this.Invoke(new Action(() => //adiciona os elementos da fila ao listbox
                {
                    Fila_De_Andares.Items.Clear();

                    foreach (string valor in valores)
                    {
                        if (!string.IsNullOrWhiteSpace(valor))
                            Fila_De_Andares.Items.Add(valor);
                    }
                }));


            }
            catch
            {
                this.Invoke(new Action(() =>
                {
                    Fila_De_Andares.Items.Add("Falha ao receber dados"); // se houver falha ao receber dados da fila
                }));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /* private void AtualizarFilaDeAndares(string mensagem)
         {
             string dados = mensagem.Substring(5); // remove o nome FILA:

             Fila_De_Andares.Items.Clear();  //limpa a fila de andares antes de atualizar

             if (!string.IsNullOrWhiteSpace(dados)) // verifica se a variavel dados não é nula, branca ou espaços
             {
                 string[] andares = dados.Split(','); //adiciona virgula entre os dados do vetor 

                 foreach (string andar in andares)   // 
                 {
                     Fila_De_Andares.Items.Add("Andar " +andar.Trim()); //adiciona a lista de andar os dados recebidos do arduino
                 }

             }
             else
             {
                 Fila_De_Andares.Items.Add("A fila está vazia"); //caso fila de andares esteja vazia 
             }
         }*/

    }
}
