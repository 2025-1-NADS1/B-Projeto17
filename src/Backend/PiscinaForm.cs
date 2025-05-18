using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace dash
{



    public partial class PiscinaForm : Form
    {
        private MainContainerForm container;

        
        public PiscinaForm(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            checkBox1.CheckedChanged += AtualizarConsumo;
            checkBox2.CheckedChanged += AtualizarConsumo;

            pictureBox3.Click += (s, e) =>
            {
                container.AbrirFormNoPainel(new PainelForm(container));
            };
        }

        
        public PiscinaForm()
        {
            InitializeComponent();

            checkBox1.CheckedChanged += AtualizarConsumo;
            checkBox2.CheckedChanged += AtualizarConsumo;

            pictureBox3.Click += (s, e) =>
            {
                new PainelForm().Show();
                this.Close();
            };
        }

        private double CalcularConsumo()
        {
            int ligados = 0;
            if (checkBox1.Checked) ligados++;
            if (checkBox2.Checked) ligados++;
            return ligados * 2.0; // 2 kWh por dispositivo
        }

        private void AtualizarConsumo(object sender, EventArgs e)
        {
            double consumo = CalcularConsumo();
            label1.Text = $"Consumo: {consumo} kWh";
        }

        private void PiscinaForm_Load(object sender, EventArgs e)
        {
        }
    }
}


