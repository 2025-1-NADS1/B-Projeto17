using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dash
{
    public partial class BanheiroForm : Form
    {
        private MainContainerForm container;

        public BanheiroForm(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            pictureBox3.Click += (s, e) =>
            {
                // Voltar para o painel principal dentro do container
                container.AbrirFormNoPainel(new PainelForm(container));
            };
        }

        private void BanheiroForm_Load(object sender, EventArgs e)
        {

        }
    }
}



