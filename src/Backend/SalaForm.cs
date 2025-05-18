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

    public partial class SalaForm : Form
    {
        private MainContainerForm container;

        // Construtor com parâmetro
        public SalaForm(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            // Associar o evento CheckedChanged a todas as checkboxes
            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;
            checkBox4.CheckedChanged += CalcularConsumo;
            checkBox5.CheckedChanged += CalcularConsumo;
            checkBox6.CheckedChanged += CalcularConsumo;

            // Voltar para PainelForm dentro do painel do container
            pictureBox3.Click += (s, e) =>
            {
                container.AbrirFormNoPainel(new PainelForm(container));
            };
        }

        // Construtor padrão (para o designer)
        public SalaForm()
        {
            InitializeComponent();

            // Associar o evento CheckedChanged a todas as checkboxes (para designer)
            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;
            checkBox4.CheckedChanged += CalcularConsumo;
            checkBox5.CheckedChanged += CalcularConsumo;
            checkBox6.CheckedChanged += CalcularConsumo;

            // Evento padrão para o designer (fecha a janela normal)
            pictureBox3.Click += (s, e) =>
            {
                new PainelForm().Show();
                this.Close();
            };
        }

        private void CalcularConsumo(object sender, EventArgs e)
        {
            int dispositivosLigados = 0;

            if (checkBox1.Checked) dispositivosLigados++;
            if (checkBox2.Checked) dispositivosLigados++;
            if (checkBox3.Checked) dispositivosLigados++;
            if (checkBox4.Checked) dispositivosLigados++;
            if (checkBox5.Checked) dispositivosLigados++;
            if (checkBox6.Checked) dispositivosLigados++;

            // 50 watts = 0.05 kWh
            double consumoTotal = dispositivosLigados * 0.05;
            label1.Text = $"Consumo: {consumoTotal} kWh";
        }

        private void SalaForm_Load(object sender, EventArgs e)
        {

        }
    }
}