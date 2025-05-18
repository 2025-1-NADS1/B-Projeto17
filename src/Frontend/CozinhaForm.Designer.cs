namespace dash
{

    partial class CozinhaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
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
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cozinha2;
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cozinhaparts;
            pictureBox2.Location = new Point(30, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 343);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(338, 170);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(20, 20);
            checkBox1.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.Location = new Point(338, 210);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(20, 20);
            checkBox2.TabIndex = 3;
            // 
            // checkBox3
            // 
            checkBox3.Location = new Point(338, 247);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(20, 20);
            checkBox3.TabIndex = 4;
            // 
            // checkBox4
            // 
            checkBox4.Location = new Point(338, 302);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(20, 20);
            checkBox4.TabIndex = 5;
            // 
            // checkBox5
            // 
            checkBox5.Location = new Point(338, 350);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(20, 20);
            checkBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.Location = new Point(659, 510);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 7;
            label1.Text = "Consumo: 0 kWh";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._return;
            pictureBox3.Location = new Point(30, 500);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 78);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // CozinhaForm
            // 
            ClientSize = new Size(1397, 616);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox5);
            Controls.Add(label1);
            Name = "CozinhaForm";
            Text = "Cozinha";
            Load += CozinhaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox3;
    }
}

