namespace ProiectMSOA
{
    partial class FormClient
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelMeniu = new Panel();
            buttonNvgDelogare = new Button();
            buttonNvgCont = new Button();
            buttonNvgIstoric = new Button();
            buttonNvgComandaNoua = new Button();
            panelComandaNoua = new Panel();
            label5 = new Label();
            radioButtonDescrescator = new RadioButton();
            radioButtonCrescator = new RadioButton();
            label4 = new Label();
            buttonPlaseazaComanda = new Button();
            comboBoxMetodaPlata = new ComboBox();
            label1 = new Label();
            checkedListBoxServicii = new CheckedListBox();
            panelIstoric = new Panel();
            dataGridViewIstoric = new DataGridView();
            panelCont = new Panel();
            buttonSalvareParola = new Button();
            textBoxParolaNoua = new TextBox();
            label7 = new Label();
            labelTotalCheltuit = new Label();
            label6 = new Label();
            labelTotalComenzi = new Label();
            label3 = new Label();
            label2 = new Label();
            panelMeniu.SuspendLayout();
            panelComandaNoua.SuspendLayout();
            panelIstoric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIstoric).BeginInit();
            panelCont.SuspendLayout();
            SuspendLayout();
            // 
            // panelMeniu
            // 
            panelMeniu.BackColor = SystemColors.ActiveBorder;
            panelMeniu.Controls.Add(buttonNvgDelogare);
            panelMeniu.Controls.Add(buttonNvgCont);
            panelMeniu.Controls.Add(buttonNvgIstoric);
            panelMeniu.Controls.Add(buttonNvgComandaNoua);
            panelMeniu.Dock = DockStyle.Left;
            panelMeniu.Location = new Point(0, 0);
            panelMeniu.Name = "panelMeniu";
            panelMeniu.Size = new Size(220, 598);
            panelMeniu.TabIndex = 0;
            // 
            // buttonNvgDelogare
            // 
            buttonNvgDelogare.Cursor = Cursors.Hand;
            buttonNvgDelogare.Dock = DockStyle.Top;
            buttonNvgDelogare.FlatAppearance.BorderSize = 0;
            buttonNvgDelogare.FlatStyle = FlatStyle.Flat;
            buttonNvgDelogare.Font = new Font("Segoe UI", 10F);
            buttonNvgDelogare.ForeColor = Color.White;
            buttonNvgDelogare.Location = new Point(0, 165);
            buttonNvgDelogare.Name = "buttonNvgDelogare";
            buttonNvgDelogare.Padding = new Padding(20, 0, 0, 0);
            buttonNvgDelogare.Size = new Size(220, 55);
            buttonNvgDelogare.TabIndex = 3;
            buttonNvgDelogare.Text = "Ieșire Cont";
            buttonNvgDelogare.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgDelogare.UseVisualStyleBackColor = true;
            buttonNvgDelogare.Click += buttonNvgDelogare_Click;
            // 
            // buttonNvgCont
            // 
            buttonNvgCont.Cursor = Cursors.Hand;
            buttonNvgCont.Dock = DockStyle.Top;
            buttonNvgCont.FlatAppearance.BorderSize = 0;
            buttonNvgCont.FlatStyle = FlatStyle.Flat;
            buttonNvgCont.Font = new Font("Segoe UI", 10F);
            buttonNvgCont.ForeColor = Color.White;
            buttonNvgCont.Location = new Point(0, 110);
            buttonNvgCont.Name = "buttonNvgCont";
            buttonNvgCont.Padding = new Padding(20, 0, 0, 0);
            buttonNvgCont.Size = new Size(220, 55);
            buttonNvgCont.TabIndex = 2;
            buttonNvgCont.Text = "Contul meu";
            buttonNvgCont.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgCont.UseVisualStyleBackColor = true;
            buttonNvgCont.Click += buttonNvgCont_Click;
            // 
            // buttonNvgIstoric
            // 
            buttonNvgIstoric.Cursor = Cursors.Hand;
            buttonNvgIstoric.Dock = DockStyle.Top;
            buttonNvgIstoric.FlatAppearance.BorderSize = 0;
            buttonNvgIstoric.FlatStyle = FlatStyle.Flat;
            buttonNvgIstoric.Font = new Font("Segoe UI", 10F);
            buttonNvgIstoric.ForeColor = Color.White;
            buttonNvgIstoric.Location = new Point(0, 55);
            buttonNvgIstoric.Name = "buttonNvgIstoric";
            buttonNvgIstoric.Padding = new Padding(20, 0, 0, 0);
            buttonNvgIstoric.Size = new Size(220, 55);
            buttonNvgIstoric.TabIndex = 1;
            buttonNvgIstoric.Text = "Istoric și Status";
            buttonNvgIstoric.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgIstoric.UseVisualStyleBackColor = true;
            buttonNvgIstoric.Click += buttonNvgIstoric_Click;
            // 
            // buttonNvgComandaNoua
            // 
            buttonNvgComandaNoua.Cursor = Cursors.Hand;
            buttonNvgComandaNoua.Dock = DockStyle.Top;
            buttonNvgComandaNoua.FlatAppearance.BorderSize = 0;
            buttonNvgComandaNoua.FlatStyle = FlatStyle.Flat;
            buttonNvgComandaNoua.Font = new Font("Segoe UI", 10F);
            buttonNvgComandaNoua.ForeColor = Color.White;
            buttonNvgComandaNoua.Location = new Point(0, 0);
            buttonNvgComandaNoua.Name = "buttonNvgComandaNoua";
            buttonNvgComandaNoua.Padding = new Padding(20, 0, 0, 0);
            buttonNvgComandaNoua.Size = new Size(220, 55);
            buttonNvgComandaNoua.TabIndex = 0;
            buttonNvgComandaNoua.Text = "Comandă nouă";
            buttonNvgComandaNoua.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgComandaNoua.UseVisualStyleBackColor = true;
            buttonNvgComandaNoua.Click += buttonNvgComandaNoua_Click;
            // 
            // panelComandaNoua
            // 
            panelComandaNoua.Controls.Add(label5);
            panelComandaNoua.Controls.Add(radioButtonDescrescator);
            panelComandaNoua.Controls.Add(radioButtonCrescator);
            panelComandaNoua.Controls.Add(label4);
            panelComandaNoua.Controls.Add(buttonPlaseazaComanda);
            panelComandaNoua.Controls.Add(comboBoxMetodaPlata);
            panelComandaNoua.Controls.Add(label1);
            panelComandaNoua.Controls.Add(checkedListBoxServicii);
            panelComandaNoua.ForeColor = SystemColors.ActiveCaptionText;
            panelComandaNoua.Location = new Point(220, 0);
            panelComandaNoua.Name = "panelComandaNoua";
            panelComandaNoua.Size = new Size(1256, 598);
            panelComandaNoua.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 60);
            label5.Name = "label5";
            label5.Size = new Size(234, 25);
            label5.TabIndex = 7;
            label5.Text = "Selectează serviciile dorite";
            // 
            // radioButtonDescrescator
            // 
            radioButtonDescrescator.AutoSize = true;
            radioButtonDescrescator.Location = new Point(159, 505);
            radioButtonDescrescator.Name = "radioButtonDescrescator";
            radioButtonDescrescator.Size = new Size(145, 29);
            radioButtonDescrescator.TabIndex = 6;
            radioButtonDescrescator.TabStop = true;
            radioButtonDescrescator.Text = "Descrescător";
            radioButtonDescrescator.UseVisualStyleBackColor = true;
            radioButtonDescrescator.CheckedChanged += radioButtonDescrescator_CheckedChanged;
            // 
            // radioButtonCrescator
            // 
            radioButtonCrescator.AutoSize = true;
            radioButtonCrescator.Location = new Point(30, 505);
            radioButtonCrescator.Name = "radioButtonCrescator";
            radioButtonCrescator.Size = new Size(117, 29);
            radioButtonCrescator.TabIndex = 5;
            radioButtonCrescator.TabStop = true;
            radioButtonCrescator.Text = "Crescător";
            radioButtonCrescator.UseVisualStyleBackColor = true;
            radioButtonCrescator.CheckedChanged += radioButtonCrescator_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label4.Location = new Point(30, 477);
            label4.Name = "label4";
            label4.Size = new Size(274, 25);
            label4.TabIndex = 4;
            label4.Text = "Sortează serviciile după preț: ";
            // 
            // buttonPlaseazaComanda
            // 
            buttonPlaseazaComanda.Cursor = Cursors.Hand;
            buttonPlaseazaComanda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonPlaseazaComanda.ForeColor = Color.White;
            buttonPlaseazaComanda.Location = new Point(240, 425);
            buttonPlaseazaComanda.Name = "buttonPlaseazaComanda";
            buttonPlaseazaComanda.Size = new Size(196, 40);
            buttonPlaseazaComanda.TabIndex = 3;
            buttonPlaseazaComanda.Text = "Plasează Comanda";
            buttonPlaseazaComanda.UseVisualStyleBackColor = true;
            buttonPlaseazaComanda.Click += buttonPlaseazaComanda_Click;
            // 
            // comboBoxMetodaPlata
            // 
            comboBoxMetodaPlata.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMetodaPlata.FlatStyle = FlatStyle.Flat;
            comboBoxMetodaPlata.Font = new Font("Segoe UI", 10F);
            comboBoxMetodaPlata.FormattingEnabled = true;
            comboBoxMetodaPlata.Location = new Point(30, 428);
            comboBoxMetodaPlata.Name = "comboBoxMetodaPlata";
            comboBoxMetodaPlata.Size = new Size(180, 36);
            comboBoxMetodaPlata.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.Location = new Point(30, 400);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "Metoda de plată";
            // 
            // checkedListBoxServicii
            // 
            checkedListBoxServicii.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxServicii.BackColor = Color.White;
            checkedListBoxServicii.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxServicii.CheckOnClick = true;
            checkedListBoxServicii.Font = new Font("Segoe UI", 10F);
            checkedListBoxServicii.FormattingEnabled = true;
            checkedListBoxServicii.Location = new Point(30, 90);
            checkedListBoxServicii.Name = "checkedListBoxServicii";
            checkedListBoxServicii.Size = new Size(720, 250);
            checkedListBoxServicii.TabIndex = 0;
            // 
            // panelIstoric
            // 
            panelIstoric.Controls.Add(dataGridViewIstoric);
            panelIstoric.Location = new Point(220, 0);
            panelIstoric.Name = "panelIstoric";
            panelIstoric.Size = new Size(1256, 598);
            panelIstoric.TabIndex = 4;
            // 
            // dataGridViewIstoric
            // 
            dataGridViewIstoric.AllowUserToAddRows = false;
            dataGridViewIstoric.AllowUserToDeleteRows = false;
            dataGridViewIstoric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewIstoric.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIstoric.BackgroundColor = Color.WhiteSmoke;
            dataGridViewIstoric.BorderStyle = BorderStyle.None;
            dataGridViewIstoric.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewIstoric.ColumnHeadersHeight = 36;
            dataGridViewIstoric.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewIstoric.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewIstoric.EnableHeadersVisualStyles = false;
            dataGridViewIstoric.Location = new Point(20, 40);
            dataGridViewIstoric.Name = "dataGridViewIstoric";
            dataGridViewIstoric.ReadOnly = true;
            dataGridViewIstoric.RowHeadersVisible = false;
            dataGridViewIstoric.RowHeadersWidth = 62;
            dataGridViewIstoric.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewIstoric.RowTemplate.Height = 32;
            dataGridViewIstoric.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewIstoric.Size = new Size(958, 400);
            dataGridViewIstoric.TabIndex = 0;
            // 
            // panelCont
            // 
            panelCont.Controls.Add(buttonSalvareParola);
            panelCont.Controls.Add(textBoxParolaNoua);
            panelCont.Controls.Add(label7);
            panelCont.Controls.Add(labelTotalCheltuit);
            panelCont.Controls.Add(label6);
            panelCont.Controls.Add(labelTotalComenzi);
            panelCont.Controls.Add(label3);
            panelCont.Controls.Add(label2);
            panelCont.Location = new Point(220, 0);
            panelCont.Name = "panelCont";
            panelCont.Size = new Size(1036, 598);
            panelCont.TabIndex = 5;
            // 
            // buttonSalvareParola
            // 
            buttonSalvareParola.Cursor = Cursors.Hand;
            buttonSalvareParola.FlatStyle = FlatStyle.Flat;
            buttonSalvareParola.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonSalvareParola.ForeColor = Color.White;
            buttonSalvareParola.Location = new Point(30, 295);
            buttonSalvareParola.Name = "buttonSalvareParola";
            buttonSalvareParola.Size = new Size(180, 38);
            buttonSalvareParola.TabIndex = 7;
            buttonSalvareParola.Text = "Salvează";
            buttonSalvareParola.UseVisualStyleBackColor = true;
            buttonSalvareParola.Click += buttonSalvareParola_Click;
            // 
            // textBoxParolaNoua
            // 
            textBoxParolaNoua.BorderStyle = BorderStyle.FixedSingle;
            textBoxParolaNoua.Font = new Font("Segoe UI", 10F);
            textBoxParolaNoua.Location = new Point(30, 252);
            textBoxParolaNoua.Name = "textBoxParolaNoua";
            textBoxParolaNoua.Size = new Size(250, 34);
            textBoxParolaNoua.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 230);
            label7.Name = "label7";
            label7.Size = new Size(143, 25);
            label7.TabIndex = 5;
            label7.Text = "Schimbă parola";
            // 
            // labelTotalCheltuit
            // 
            labelTotalCheltuit.AutoSize = true;
            labelTotalCheltuit.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTotalCheltuit.ForeColor = Color.LimeGreen;
            labelTotalCheltuit.Location = new Point(340, 155);
            labelTotalCheltuit.Name = "labelTotalCheltuit";
            labelTotalCheltuit.Size = new Size(50, 60);
            labelTotalCheltuit.TabIndex = 4;
            labelTotalCheltuit.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(340, 130);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 3;
            label6.Text = "Total cheltuit";
            // 
            // labelTotalComenzi
            // 
            labelTotalComenzi.AutoSize = true;
            labelTotalComenzi.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTotalComenzi.ForeColor = Color.Blue;
            labelTotalComenzi.Location = new Point(30, 155);
            labelTotalComenzi.Name = "labelTotalComenzi";
            labelTotalComenzi.Size = new Size(50, 60);
            labelTotalComenzi.TabIndex = 2;
            labelTotalComenzi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(30, 130);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 1;
            label3.Text = "Total comenzi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 65);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1256, 598);
            Controls.Add(panelMeniu);
            Controls.Add(panelComandaNoua);
            Controls.Add(panelIstoric);
            Controls.Add(panelCont);
            Font = new Font("Segoe UI", 9.5F);
            Name = "FormClient";
            Text = "FormClient";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormClient_FormClosed;
            Load += FormClient_Load;
            panelMeniu.ResumeLayout(false);
            panelComandaNoua.ResumeLayout(false);
            panelComandaNoua.PerformLayout();
            panelIstoric.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIstoric).EndInit();
            panelCont.ResumeLayout(false);
            panelCont.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMeniu;
        private Button buttonNvgComandaNoua;
        private Panel panelComandaNoua;
        private Button buttonPlaseazaComanda;
        private ComboBox comboBoxMetodaPlata;
        private Label label1;
        private CheckedListBox checkedListBoxServicii;
        private Button buttonNvgIstoric;
        private Panel panelIstoric;
        private DataGridView dataGridViewIstoric;
        private Button buttonNvgCont;
        private Panel panelCont;
        private Button buttonNvgDelogare;
        private RadioButton radioButtonDescrescator;
        private RadioButton radioButtonCrescator;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label labelTotalComenzi;
        private Label label3;
        private Button buttonSalvareParola;
        private TextBox textBoxParolaNoua;
        private Label label7;
        private Label labelTotalCheltuit;
    }
}