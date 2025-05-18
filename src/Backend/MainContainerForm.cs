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
    public partial class MainContainerForm : Form
    {
        public MainContainerForm()
        {
            InitializeComponent();

      
            this.Load += MainContainerForm_Load; // Liga o evento Load ao método que criamos
        }

        
        public void AbrirFormNoPainel(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }
        private void MainContainerForm_Load(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Form1(this));
        }


        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
