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
    public partial class Quarto2Form : Form
    {
        private MainContainerForm container;

        // Construtor com container
        public Quarto2Form(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            // Eventos para calcular consumo
            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;

            // Voltar para o PainelForm dentro do painel
            pictureBox3.Click += (s, e) =>
            {
                container.AbrirFormNoPainel(new PainelForm(container));
            };
        }

        // Construtor padrão (para designer)
        public Quarto2Form()
        {
            InitializeComponent();

            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;

            pictureBox3.Click += (s, e) =>
            {
                new PainelForm().Show();
                this.Close();
            };
        }

        private void CalcularConsumo(object sender, EventArgs e)
        {
            int ligados = 0;

            if (checkBox1.Checked) ligados++;
            if (checkBox2.Checked) ligados++;
            if (checkBox3.Checked) ligados++;

            double consumo = ligados * 1.5;
            label1.Text = $"Consumo: {consumo} kWh";
        }

        private void Quarto2Form_Load(object sender, EventArgs e)
        {

        }
    }
}



