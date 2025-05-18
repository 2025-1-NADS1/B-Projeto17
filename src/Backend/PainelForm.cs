using System;
using System.Windows.Forms;

namespace dash
{
    public partial class PainelForm : Form
    {
        private MainContainerForm container;

        // Construtor com parâmetro
        public PainelForm(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            pictureBox1.Click += (s, e) => container.AbrirFormNoPainel(new SalaForm(container));
            pictureBox2.Click += (s, e) => container.AbrirFormNoPainel(new CozinhaForm(container));
            pictureBox3.Click += (s, e) => container.AbrirFormNoPainel(new Quarto1Form(container));
            pictureBox4.Click += (s, e) => container.AbrirFormNoPainel(new Quarto2Form(container));
            pictureBox5.Click += (s, e) => container.AbrirFormNoPainel(new BanheiroForm(container));
            pictureBox6.Click += (s, e) => container.AbrirFormNoPainel(new PiscinaForm(container));
        }

        // Construtor padrão (necessário para o designer funcionar)
        public PainelForm()
        {
            InitializeComponent();
        }

        private void PainelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
