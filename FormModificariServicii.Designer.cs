namespace ProiectMSOA
{
    partial class FormModificariServicii
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
            label1 = new Label();
            textBoxDenumire = new TextBox();
            label2 = new Label();
            numericUpDownPret = new NumericUpDown();
            numericUpDownDurata = new NumericUpDown();
            label3 = new Label();
            buttonSalvare = new Button();
            buttonAnulare = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.Location = new Point(189, 81);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Denumire";
            // 
            // textBoxDenumire
            // 
            textBoxDenumire.BorderStyle = BorderStyle.FixedSingle;
            textBoxDenumire.Location = new Point(328, 75);
            textBoxDenumire.Name = "textBoxDenumire";
            textBoxDenumire.Size = new Size(308, 33);
            textBoxDenumire.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.Location = new Point(245, 142);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Pret";
            // 
            // numericUpDownPret
            // 
            numericUpDownPret.Location = new Point(328, 140);
            numericUpDownPret.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPret.Name = "numericUpDownPret";
            numericUpDownPret.Size = new Size(308, 33);
            numericUpDownPret.TabIndex = 3;
            // 
            // numericUpDownDurata
            // 
            numericUpDownDurata.Location = new Point(328, 200);
            numericUpDownDurata.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownDurata.Name = "numericUpDownDurata";
            numericUpDownDurata.Size = new Size(308, 33);
            numericUpDownDurata.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label3.Location = new Point(219, 202);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 4;
            label3.Text = "Durata";
            // 
            // buttonSalvare
            // 
            buttonSalvare.Cursor = Cursors.Hand;
            buttonSalvare.FlatAppearance.BorderSize = 0;
            buttonSalvare.FlatStyle = FlatStyle.Flat;
            buttonSalvare.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonSalvare.Location = new Point(172, 298);
            buttonSalvare.Name = "buttonSalvare";
            buttonSalvare.Size = new Size(198, 38);
            buttonSalvare.TabIndex = 6;
            buttonSalvare.Text = "Salvare";
            buttonSalvare.UseVisualStyleBackColor = true;
            buttonSalvare.Click += buttonSalvare_Click;
            // 
            // buttonAnulare
            // 
            buttonAnulare.Cursor = Cursors.Hand;
            buttonAnulare.DialogResult = DialogResult.Cancel;
            buttonAnulare.FlatAppearance.BorderSize = 0;
            buttonAnulare.FlatStyle = FlatStyle.Flat;
            buttonAnulare.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonAnulare.Location = new Point(529, 298);
            buttonAnulare.Name = "buttonAnulare";
            buttonAnulare.Size = new Size(198, 38);
            buttonAnulare.TabIndex = 7;
            buttonAnulare.Text = "Anulare";
            buttonAnulare.UseVisualStyleBackColor = true;
            buttonAnulare.Click += buttonAnulare_Click;
            // 
            // FormModificariServicii
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 450);
            Controls.Add(buttonAnulare);
            Controls.Add(buttonSalvare);
            Controls.Add(numericUpDownDurata);
            Controls.Add(label3);
            Controls.Add(numericUpDownPret);
            Controls.Add(label2);
            Controls.Add(textBoxDenumire);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.5F);
            MaximizeBox = false;
            Name = "FormModificariServicii";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormModificariServicii";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPret).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDenumire;
        private Label label2;
        private NumericUpDown numericUpDownPret;
        private NumericUpDown numericUpDownDurata;
        private Label label3;
        private Button buttonSalvare;
        private Button buttonAnulare;
    }
}