namespace ProiectMSOA
{
    partial class FormAdaugaUtilizator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAnulare = new Button();
            buttonSalvare = new Button();
            textBoxParola = new TextBox();
            label2 = new Label();
            textBoxNume = new TextBox();
            label1 = new Label();
            label3 = new Label();
            comboBoxRol = new ComboBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAnulare
            // 
            buttonAnulare.BackColor = SystemColors.Control;
            buttonAnulare.Cursor = Cursors.Hand;
            buttonAnulare.FlatAppearance.BorderColor = Color.FromArgb(207, 216, 220);
            buttonAnulare.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 248);
            buttonAnulare.FlatStyle = FlatStyle.Flat;
            buttonAnulare.Font = new Font("Segoe UI", 10F);
            buttonAnulare.Location = new Point(170, 210);
            buttonAnulare.Name = "buttonAnulare";
            buttonAnulare.Size = new Size(120, 38);
            buttonAnulare.TabIndex = 11;
            buttonAnulare.Text = "Anulare";
            buttonAnulare.UseVisualStyleBackColor = false;
            buttonAnulare.Click += buttonAnulare_Click;
            // 
            // buttonSalvare
            // 
            buttonSalvare.BackColor = SystemColors.Control;
            buttonSalvare.Cursor = Cursors.Hand;
            buttonSalvare.FlatAppearance.BorderSize = 0;
            buttonSalvare.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            buttonSalvare.FlatStyle = FlatStyle.Flat;
            buttonSalvare.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSalvare.Location = new Point(30, 210);
            buttonSalvare.Name = "buttonSalvare";
            buttonSalvare.Size = new Size(120, 38);
            buttonSalvare.TabIndex = 10;
            buttonSalvare.Text = "Salvare";
            buttonSalvare.UseVisualStyleBackColor = false;
            buttonSalvare.Click += buttonSalvare_Click;
            // 
            // textBoxParola
            // 
            textBoxParola.Font = new Font("Segoe UI", 10F);
            textBoxParola.Location = new Point(30, 103);
            textBoxParola.Name = "textBoxParola";
            textBoxParola.Size = new Size(260, 34);
            textBoxParola.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 85);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 8;
            label2.Text = "Parolă";
            // 
            // textBoxNume
            // 
            textBoxNume.Font = new Font("Segoe UI", 10F);
            textBoxNume.Location = new Point(30, 48);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(260, 34);
            textBoxNume.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Nume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 140);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 12;
            label3.Text = "Rol";
            // 
            // comboBoxRol
            // 
            comboBoxRol.Font = new Font("Segoe UI", 10F);
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(30, 158);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(260, 36);
            comboBoxRol.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonAnulare);
            panel1.Controls.Add(comboBoxRol);
            panel1.Controls.Add(buttonSalvare);
            panel1.Controls.Add(textBoxNume);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxParola);
            panel1.Location = new Point(49, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 280);
            panel1.TabIndex = 14;
            // 
            // FormAdaugaUtilizator
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 324);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAdaugaUtilizator";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdaugaUtilizator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAnulare;
        private Button buttonSalvare;
        private TextBox textBoxParola;
        private Label label2;
        private TextBox textBoxNume;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxRol;
        private Panel panel1;
    }
}