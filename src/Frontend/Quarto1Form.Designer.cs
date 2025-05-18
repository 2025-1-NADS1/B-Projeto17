namespace dash
{

    partial class Quarto1Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;

        // Adicionei a pictureBoxvoltar
        private System.Windows.Forms.PictureBox pictureBoxvoltar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            pictureBoxvoltar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxvoltar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Quarto1_2;
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.quartos1;
            pictureBox2.Location = new Point(2, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 237);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(262, 211);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(20, 20);
            checkBox1.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.Location = new Point(262, 258);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(20, 20);
            checkBox2.TabIndex = 3;
            // 
            // checkBox3
            // 
            checkBox3.Location = new Point(262, 313);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(20, 20);
            checkBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new Point(744, 495);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 5;
            label1.Text = "Consumo: 0 kWh";
            // 
            // pictureBoxvoltar
            // 
            pictureBoxvoltar.BackColor = SystemColors.Control;
            pictureBoxvoltar.Image = Properties.Resources._return;
            pictureBoxvoltar.Location = new Point(12, 518);
            pictureBoxvoltar.Name = "pictureBoxvoltar";
            pictureBoxvoltar.Size = new Size(91, 84);
            pictureBoxvoltar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxvoltar.TabIndex = 6;
            pictureBoxvoltar.TabStop = false;
            // 
            // Quarto1Form
            // 
            ClientSize = new Size(1507, 625);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(label1);
            Controls.Add(pictureBoxvoltar);
            Name = "Quarto1Form";
            Text = "Quarto 1";
            Load += Quarto1Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxvoltar).EndInit();
            ResumeLayout(false);
        }
    }
}



