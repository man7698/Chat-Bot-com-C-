using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatBotProject
{
    public partial class bubble : UserControl
    {
        public bubble()
        {
            InitializeComponent();
        }

        public bubble(string message, msgtype messagetype)
        {
            InitializeComponent();

            // Defina o texto no balão da mensagem no parâmetro.
            lblmessage.Text = message;

            // Mude a cor com base no tipo de mensagem.
            if (messagetype.ToString() == "In")
            {
                // mensagem recebida do usuário
                this.BackColor = Color.Gray;
            }
            else
            {
                // Mensagem do bot de saída
                this.BackColor = Color.FromArgb(0, 164, 147); 
            }
            Setheight();
        }

        private void bubble_Load(object sender, EventArgs e) { }

        // Define a altura da bolha com base no comprimento da mensagem.
        void Setheight()
        {
            // redimensione a bolha após ela ser chamada
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(lblmessage.Text, lblmessage.Font, lblmessage.Width);

            // Defina a altura da bolha
            lblmessage.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
        }

        private void bubble_Resize(object sender, EventArgs e)
        {
            Setheight();
        }

        private void lblmessage_Click(object sender, EventArgs e)
        {

        }
    }

    // Faça uma enumeração personalizada para determinar facilmente as mensagens de entrada e saída para que possamos definir a cor
    public enum msgtype
    {
        In,
        Out
    }
}
