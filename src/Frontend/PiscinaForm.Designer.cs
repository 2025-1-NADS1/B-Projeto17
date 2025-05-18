namespace dash
{

    partial class PiscinaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;

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
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Piscina2;
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.piscinapart;
            pictureBox2.Location = new Point(30, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(277, 139);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(313, 160);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(20, 20);
            checkBox1.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.Location = new Point(313, 197);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(20, 20);
            checkBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(737, 542);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 4;
            label1.Text = "Consumo: 0 kWh";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._return;
            pictureBox3.Location = new Point(36, 492);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 102);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // PiscinaForm
            // 
            ClientSize = new Size(1457, 628);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(label1);
            Name = "PiscinaForm";
            Text = "Piscina";
            Load += PiscinaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox3;
    }
}

