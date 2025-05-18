using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dash
{
    public partial class Form1 : Form
    {
        private MainContainerForm container; // Referência ao MainContainerForm

        public Form1(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            // Evento do botão Enter (PictureBox funcional)
            pictureBox4.Click += VerificarLogin;
        }

        private void VerificarLogin(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            if (usuario == "admin" && senha == "123")
            {
                // Cria o PainelForm e exibe dentro do painel do MainContainer
                PainelForm painel = new PainelForm(container);
                container.AbrirFormNoPainel(painel);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}






