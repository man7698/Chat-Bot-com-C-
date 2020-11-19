using System;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Media;


namespace ChatBotProject
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer reader = new SpeechSynthesizer();

        bool textToSpeech = false;

        static ChatBot bot;

        public Form1()
        {
            InitializeComponent();
        }

        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            bot = new ChatBot();

            // define a posição para primeira linha no topo
            bbl_old.Top = 0 - bbl_old.Height;

            // cria log da conversa
            if (File.Exists("chat.log"))
            {
                using (StreamReader sr = File.OpenText("chat.log"))
                {
                    int i = 0; // conta linhas
                    while (sr.Peek() >= 0) // loop ate o final do arquivo
                    {
                        if (i % 2 == 0) // vê se a linha é par
                        {
                            addInMessage(sr.ReadLine());
                        }
                        else
                        {
                            addOutMessage(sr.ReadLine());
                        }
                        i++;
                    }
                    // rolar para ultima mensagem quando terminar de carregar.
                    panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
                    panel2.PerformLayout();
                }
            }
        }

        private void showOutput()
        {
            if (!(string.IsNullOrWhiteSpace(InputTxt.Text))) // ve se a caixa de texto não esta vazia
            {
                SoundPlayer Send = new SoundPlayer("SOUND1.wav"); // som de envio
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav"); // som de recebimento

                // mostrar mensagem e tocar o som
                addInMessage(InputTxt.Text);
                Send.Play();
  
                // armazenar a saida dos bots fornecendo nossa entrada.
                string outtt = bot.getOutput(InputTxt.Text);

                if (outtt.Length == 0)
                {
                    outtt = "EU NÃO ENTENDI.";
                }

                // cria backup do bate papo do usuario para um local do executavel
                FileStream fs = new FileStream(@"chat.log", FileMode.Append, FileAccess.Write);
                if (fs.CanWrite)
                {
                    byte[] write = System.Text.Encoding.ASCII.GetBytes(InputTxt.Text + Environment.NewLine + outtt + Environment.NewLine);
                    fs.Write(write, 0, write.Length);
                }
                fs.Flush();
                fs.Close();
                

                // cria um cronometro para atrasar a resposta do bot e fazer parecer mais humano
                var t = new Timer();
                
                // tempo em milisegundos atraso de 1 s mais 0,01 s por caracter
                t.Interval = 1000 + (outtt.Length * 10);

                // mostrar o label o chatbot esta pensando
                txtTyping.Show();

                // desativa a textbox enquanto o bot esta pensando
                InputTxt.Enabled = false;

                t.Tick += (s, d) =>
                {
                  

                    InputTxt.Enabled = true; // habilita textbox

                    // esconde a mensagem o bot esta pensando...
                    txtTyping.Hide();

                    // mostra a mensagem do bot e toca o som
                    addOutMessage(outtt);
                    Rcv.Play();

                    // se habilitado fala a mensagem
                    if (textToSpeech)
                    {
                        reader.SpeakAsync(outtt);
                    }
                    
                    InputTxt.Focus(); // coloca o cursor na textbox
                    t.Stop();
                };
                t.Start(); // inicia o timer

                InputTxt.Text = ""; // limpa a textbox
            }
        }

        // Chame o método de saída quando o botão enviar for clicado.
        private void button1_Click(object sender, EventArgs e)
        {
            showOutput();
        }

        // Chame o método Output quando a tecla Enter for pressionada.
        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showOutput();
                e.SuppressKeyPress = true; // desabilita som de erro do windows
            }
        }

        // Bolha fictícia criada para armazenar os dados da bolha anterior.
        bubble bbl_old = new bubble();

        // Criação de bolha de mensagem do usuário
        public void addInMessage(string message)
        {
            // criar nova bolha do batepapo
            bubble bbl = new bubble(message, msgtype.In);
            bbl.Location = bubble1.Location; // Defina o novo local da bolha da amostra de bolha.
            bbl.Left += 150; // Recua a bolha para o lado direito.
            bbl.Size = bubble1.Size; // Defina o novo tamanho de bolha da amostra de bolha.
            bbl.Top = bbl_old.Bottom + 10; // Posicione a bolha abaixo da anterior com algum espaço extra

            // add nova bolha no painel
            panel2.Controls.Add(bbl);

            // coloca o focus na bolha mais recente
            bbl.Focus();

            // salve o último objeto adicionado à bolha fictícia
            bbl_old = bbl;
        }

        // Criação de bolha de mensagem de bot
        public void addOutMessage(string message)
        {
            // cria nova bolha no chat
            bubble bbl = new bubble(message, msgtype.Out);
            bbl.Location = bubble1.Location; // Defina o novo local da bolha da amostra de bolha.
            bbl.Size = bubble1.Size; // Defina o novo tamanho de bolha da amostra de bolha.
            bbl.Top = bbl_old.Bottom + 10; // Posicione a bolha abaixo da anterior com algum espaço extra.

            // Add nova bolha no painel
            panel2.Controls.Add(bbl);

            // coloca o focus na ultima bolha
            bbl.Focus();

            // salve o último objeto adicionado à bolha fictícia
            bbl_old = bbl;
        }

        // Botão Fechar personalizado para fechar o programa quando clicado.
        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Limpe todas as bolhas e chat.log
        private void clearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
           // Exclua o arquivo de log
            File.Delete(@"chat.log");

            // limpar o chat
            panel2.Controls.Clear();

            // Isso redefiniu a posição para a próxima bolha voltar ao topo.
            bbl_old.Top = 0 - bbl_old.Height;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
          //  contextMenuStrip1.Show(menuButton, new System.Drawing.Point(0, -contextMenuStrip1.Size.Height));
        }

        private void toggleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sempre que o botão de alternância é clicado, verdadeiro é definido como falso e vice-versa.
           // textToSpeech = !textToSpeech;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            // Exclua o arquivo de log
            File.Delete(@"chat.log");

            // limpar o chat
            panel2.Controls.Clear();

            // Isso redefiniu a posição para a próxima bolha voltar ao topo.
            bbl_old.Top = 0 - bbl_old.Height;
        }

        private void btnaudio_Click(object sender, EventArgs e)
        {
            // sempre que o botão de alternância é clicado, verdadeiro é definido como falso e vice-versa.
            //textToSpeech = !textToSpeech;
        }
    }
}