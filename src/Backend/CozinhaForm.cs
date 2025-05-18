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

    public partial class CozinhaForm : Form
    {
        private MainContainerForm container;

        public CozinhaForm(MainContainerForm container)
        {
            InitializeComponent();
            this.container = container;

            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;
            checkBox4.CheckedChanged += CalcularConsumo;
            checkBox5.CheckedChanged += CalcularConsumo;

            pictureBox3.Click += (s, e) =>
            {
                container.AbrirFormNoPainel(new PainelForm(container));
            };
        }

        // Construtor padrão para designer
        public CozinhaForm()
        {
            InitializeComponent();

            checkBox1.CheckedChanged += CalcularConsumo;
            checkBox2.CheckedChanged += CalcularConsumo;
            checkBox3.CheckedChanged += CalcularConsumo;
            checkBox4.CheckedChanged += CalcularConsumo;
            checkBox5.CheckedChanged += CalcularConsumo;

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
            if (checkBox4.Checked) ligados++;
            if (checkBox5.Checked) ligados++;

            double consumo = ligados * 3.0; // 3 kWh por dispositivo
            label1.Text = $"Consumo: {consumo} kWh";
        }

        private void CozinhaForm_Load(object sender, EventArgs e)
        {
        }
    }
}


