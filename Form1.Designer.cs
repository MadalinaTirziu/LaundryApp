namespace ProiectMSOA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxNume = new TextBox();
            label2 = new Label();
            textBoxParola = new TextBox();
            buttonAutentificare = new Button();
            buttonAdaugaCont = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 155);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            // 
            // textBoxNume
            // 
            textBoxNume.BorderStyle = BorderStyle.FixedSingle;
            textBoxNume.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNume.Location = new Point(30, 173);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(300, 34);
            textBoxNume.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 215);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Parolă";
            // 
            // textBoxParola
            // 
            textBoxParola.BorderStyle = BorderStyle.FixedSingle;
            textBoxParola.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxParola.Location = new Point(30, 233);
            textBoxParola.Name = "textBoxParola";
            textBoxParola.PasswordChar = '*';
            textBoxParola.Size = new Size(300, 34);
            textBoxParola.TabIndex = 3;
            // 
            // buttonAutentificare
            // 
            buttonAutentificare.BackColor = SystemColors.Control;
            buttonAutentificare.Cursor = Cursors.Hand;
            buttonAutentificare.FlatAppearance.BorderSize = 0;
            buttonAutentificare.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            buttonAutentificare.FlatStyle = FlatStyle.Flat;
            buttonAutentificare.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAutentificare.ForeColor = Color.White;
            buttonAutentificare.Location = new Point(30, 290);
            buttonAutentificare.Name = "buttonAutentificare";
            buttonAutentificare.Size = new Size(300, 42);
            buttonAutentificare.TabIndex = 4;
            buttonAutentificare.Text = "Autentificare";
            buttonAutentificare.UseVisualStyleBackColor = false;
            buttonAutentificare.Click += buttonAutentificare_Click;
            // 
            // buttonAdaugaCont
            // 
            buttonAdaugaCont.BackColor = SystemColors.Control;
            buttonAdaugaCont.Cursor = Cursors.Hand;
            buttonAdaugaCont.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 242, 253);
            buttonAdaugaCont.FlatStyle = FlatStyle.Flat;
            buttonAdaugaCont.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdaugaCont.Location = new Point(30, 348);
            buttonAdaugaCont.Name = "buttonAdaugaCont";
            buttonAdaugaCont.Size = new Size(300, 42);
            buttonAdaugaCont.TabIndex = 5;
            buttonAdaugaCont.Text = "Adaugă cont nou";
            buttonAdaugaCont.UseVisualStyleBackColor = false;
            buttonAdaugaCont.Click += buttonAdaugaCont_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(270, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonAdaugaCont);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonAutentificare);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxParola);
            panel1.Controls.Add(textBoxNume);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(61, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 440);
            panel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 28);
            label6.Name = "label6";
            label6.Size = new Size(149, 38);
            label6.TabIndex = 7;
            label6.Text = "FreshFlow";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 130);
            label5.Name = "label5";
            label5.Size = new Size(263, 23);
            label5.TabIndex = 2;
            label5.Text = "Conectează-te pentru a continua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 95);
            label4.Name = "label4";
            label4.Size = new Size(174, 36);
            label4.TabIndex = 1;
            label4.Text = "Bine ai venit!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 58);
            label3.Name = "label3";
            label3.Size = new Size(193, 23);
            label3.TabIndex = 0;
            label3.Text = "Spălătorie și Curățătorie";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 504);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autentificare";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxNume;
        private Label label2;
        private TextBox textBoxParola;
        private Button buttonAutentificare;
        private Button buttonAdaugaCont;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
