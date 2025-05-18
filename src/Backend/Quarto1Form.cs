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

    public partial class Quarto1Form : Form
    {
        private MainContainerForm container;

        // Construtor com parâmetro
        public Quarto1Form(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            // Eventos para calcular consumo quando qualquer checkbox for clicada
            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;

            // Evento clique da pictureBoxvoltar - volta para PainelForm no painel
            pictureBoxvoltar.Click += (s, e) =>
            {
                container.AbrirFormNoPainel(new PainelForm(container));
            };
        }

        // Construtor padrão (para designer)
        public Quarto1Form()
        {
            InitializeComponent();

            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;

            pictureBoxvoltar.Click += (s, e) =>
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

            // 1,5 kWh por dispositivo
            double consumo = ligados * 1.5;
            label1.Text = $"Consumo: {consumo} kWh";
        }

        private void Quarto1Form_Load(object sender, EventArgs e)
        {
        }
    }
}






