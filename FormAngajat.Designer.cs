namespace ProiectMSOA
{
    partial class FormAngajat
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMeniu = new Panel();
            buttonNvgDelogare = new Button();
            buttonNvgNotificari = new Button();
            buttonNvgPreturi = new Button();
            buttonNvgIncasari = new Button();
            buttonNvgComenzi = new Button();
            panelComenzi = new Panel();
            comboBoxFiltru = new ComboBox();
            label3 = new Label();
            textBoxCautare = new TextBox();
            label2 = new Label();
            buttonDetalii = new Button();
            buttonSalveazaStatus = new Button();
            comboBoxStatus = new ComboBox();
            label1 = new Label();
            dataGridViewComenzi = new DataGridView();
            panelPlati = new Panel();
            comboBoxFiltrarePlata = new ComboBox();
            label4 = new Label();
            dataGridViewPlati = new DataGridView();
            panelPreturi = new Panel();
            dataGridViewPreturi = new DataGridView();
            panelNotificari = new Panel();
            dataGridViewNotificari = new DataGridView();
            panelMeniu.SuspendLayout();
            panelComenzi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComenzi).BeginInit();
            panelPlati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlati).BeginInit();
            panelPreturi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreturi).BeginInit();
            panelNotificari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotificari).BeginInit();
            SuspendLayout();
            // 
            // panelMeniu
            // 
            panelMeniu.BackColor = SystemColors.AppWorkspace;
            panelMeniu.Controls.Add(buttonNvgDelogare);
            panelMeniu.Controls.Add(buttonNvgNotificari);
            panelMeniu.Controls.Add(buttonNvgPreturi);
            panelMeniu.Controls.Add(buttonNvgIncasari);
            panelMeniu.Controls.Add(buttonNvgComenzi);
            panelMeniu.Dock = DockStyle.Left;
            panelMeniu.Font = new Font("Segoe UI", 9.5F);
            panelMeniu.Location = new Point(0, 0);
            panelMeniu.Name = "panelMeniu";
            panelMeniu.Size = new Size(200, 624);
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
            buttonNvgDelogare.Location = new Point(0, 220);
            buttonNvgDelogare.Name = "buttonNvgDelogare";
            buttonNvgDelogare.Padding = new Padding(20, 0, 0, 0);
            buttonNvgDelogare.Size = new Size(200, 55);
            buttonNvgDelogare.TabIndex = 4;
            buttonNvgDelogare.Text = "Ieșire Cont";
            buttonNvgDelogare.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgDelogare.UseVisualStyleBackColor = false;
            buttonNvgDelogare.Click += buttonNvgDelogare_Click;
            // 
            // buttonNvgNotificari
            // 
            buttonNvgNotificari.Cursor = Cursors.Hand;
            buttonNvgNotificari.Dock = DockStyle.Top;
            buttonNvgNotificari.FlatAppearance.BorderSize = 0;
            buttonNvgNotificari.FlatStyle = FlatStyle.Flat;
            buttonNvgNotificari.Font = new Font("Segoe UI", 10F);
            buttonNvgNotificari.ForeColor = Color.White;
            buttonNvgNotificari.Location = new Point(0, 165);
            buttonNvgNotificari.Name = "buttonNvgNotificari";
            buttonNvgNotificari.Padding = new Padding(20, 0, 0, 0);
            buttonNvgNotificari.Size = new Size(200, 55);
            buttonNvgNotificari.TabIndex = 3;
            buttonNvgNotificari.Text = "Notificări";
            buttonNvgNotificari.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgNotificari.UseVisualStyleBackColor = false;
            buttonNvgNotificari.Click += buttonNvgNotificari_Click;
            // 
            // buttonNvgPreturi
            // 
            buttonNvgPreturi.Cursor = Cursors.Hand;
            buttonNvgPreturi.Dock = DockStyle.Top;
            buttonNvgPreturi.FlatAppearance.BorderSize = 0;
            buttonNvgPreturi.FlatStyle = FlatStyle.Flat;
            buttonNvgPreturi.Font = new Font("Segoe UI", 10F);
            buttonNvgPreturi.ForeColor = Color.White;
            buttonNvgPreturi.Location = new Point(0, 110);
            buttonNvgPreturi.Name = "buttonNvgPreturi";
            buttonNvgPreturi.Padding = new Padding(20, 0, 0, 0);
            buttonNvgPreturi.Size = new Size(200, 55);
            buttonNvgPreturi.TabIndex = 2;
            buttonNvgPreturi.Text = "Prețuri";
            buttonNvgPreturi.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgPreturi.UseVisualStyleBackColor = false;
            buttonNvgPreturi.Click += buttonNvgPreturi_Click;
            // 
            // buttonNvgIncasari
            // 
            buttonNvgIncasari.Cursor = Cursors.Hand;
            buttonNvgIncasari.Dock = DockStyle.Top;
            buttonNvgIncasari.FlatAppearance.BorderSize = 0;
            buttonNvgIncasari.FlatStyle = FlatStyle.Flat;
            buttonNvgIncasari.Font = new Font("Segoe UI", 10F);
            buttonNvgIncasari.ForeColor = Color.White;
            buttonNvgIncasari.Location = new Point(0, 55);
            buttonNvgIncasari.Name = "buttonNvgIncasari";
            buttonNvgIncasari.Padding = new Padding(20, 0, 0, 0);
            buttonNvgIncasari.Size = new Size(200, 55);
            buttonNvgIncasari.TabIndex = 1;
            buttonNvgIncasari.Text = "Încasări";
            buttonNvgIncasari.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgIncasari.UseVisualStyleBackColor = false;
            buttonNvgIncasari.Click += buttonNvgIncasari_Click;
            // 
            // buttonNvgComenzi
            // 
            buttonNvgComenzi.Cursor = Cursors.Hand;
            buttonNvgComenzi.Dock = DockStyle.Top;
            buttonNvgComenzi.FlatAppearance.BorderSize = 0;
            buttonNvgComenzi.FlatStyle = FlatStyle.Flat;
            buttonNvgComenzi.Font = new Font("Segoe UI", 10F);
            buttonNvgComenzi.ForeColor = Color.White;
            buttonNvgComenzi.Location = new Point(0, 0);
            buttonNvgComenzi.Name = "buttonNvgComenzi";
            buttonNvgComenzi.Padding = new Padding(20, 0, 0, 0);
            buttonNvgComenzi.Size = new Size(200, 55);
            buttonNvgComenzi.TabIndex = 0;
            buttonNvgComenzi.Text = "Comenzi";
            buttonNvgComenzi.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgComenzi.UseVisualStyleBackColor = false;
            buttonNvgComenzi.Click += buttonNvgComenzi_Click;
            // 
            // panelComenzi
            // 
            panelComenzi.Controls.Add(comboBoxFiltru);
            panelComenzi.Controls.Add(label3);
            panelComenzi.Controls.Add(textBoxCautare);
            panelComenzi.Controls.Add(label2);
            panelComenzi.Controls.Add(buttonDetalii);
            panelComenzi.Controls.Add(buttonSalveazaStatus);
            panelComenzi.Controls.Add(comboBoxStatus);
            panelComenzi.Controls.Add(label1);
            panelComenzi.Controls.Add(dataGridViewComenzi);
            panelComenzi.Font = new Font("Segoe UI", 9.5F);
            panelComenzi.Location = new Point(200, 0);
            panelComenzi.Name = "panelComenzi";
            panelComenzi.Size = new Size(900, 680);
            panelComenzi.TabIndex = 1;
            // 
            // comboBoxFiltru
            // 
            comboBoxFiltru.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltru.FlatStyle = FlatStyle.Flat;
            comboBoxFiltru.Font = new Font("Segoe UI", 10F);
            comboBoxFiltru.FormattingEnabled = true;
            comboBoxFiltru.Location = new Point(224, 559);
            comboBoxFiltru.Name = "comboBoxFiltru";
            comboBoxFiltru.Size = new Size(200, 36);
            comboBoxFiltru.TabIndex = 8;
            comboBoxFiltru.SelectedIndexChanged += comboBoxFiltru_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label3.Location = new Point(7, 562);
            label3.Name = "label3";
            label3.Size = new Size(204, 25);
            label3.TabIndex = 7;
            label3.Text = "Filtrează după status: ";
            // 
            // textBoxCautare
            // 
            textBoxCautare.Location = new Point(191, 504);
            textBoxCautare.Name = "textBoxCautare";
            textBoxCautare.Size = new Size(224, 33);
            textBoxCautare.TabIndex = 6;
            textBoxCautare.TextChanged += textBoxCautare_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.Location = new Point(7, 512);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 5;
            label2.Text = "Caută utilizator: ";
            // 
            // buttonDetalii
            // 
            buttonDetalii.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDetalii.Cursor = Cursors.Hand;
            buttonDetalii.FlatStyle = FlatStyle.Flat;
            buttonDetalii.ForeColor = Color.White;
            buttonDetalii.Location = new Point(675, 408);
            buttonDetalii.Name = "buttonDetalii";
            buttonDetalii.Size = new Size(150, 38);
            buttonDetalii.TabIndex = 4;
            buttonDetalii.Text = "Detalii";
            buttonDetalii.UseVisualStyleBackColor = true;
            buttonDetalii.Click += buttonDetalii_Click;
            // 
            // buttonSalveazaStatus
            // 
            buttonSalveazaStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalveazaStatus.Cursor = Cursors.Hand;
            buttonSalveazaStatus.FlatStyle = FlatStyle.Flat;
            buttonSalveazaStatus.ForeColor = Color.White;
            buttonSalveazaStatus.Location = new Point(478, 411);
            buttonSalveazaStatus.Name = "buttonSalveazaStatus";
            buttonSalveazaStatus.Size = new Size(150, 38);
            buttonSalveazaStatus.TabIndex = 3;
            buttonSalveazaStatus.Text = "Salvează";
            buttonSalveazaStatus.UseVisualStyleBackColor = true;
            buttonSalveazaStatus.Click += buttonSalveazaStatus_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(191, 415);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(235, 36);
            comboBoxStatus.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.Location = new Point(26, 415);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "Status Comandă";
            // 
            // dataGridViewComenzi
            // 
            dataGridViewComenzi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewComenzi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComenzi.BackgroundColor = Color.WhiteSmoke;
            dataGridViewComenzi.BorderStyle = BorderStyle.None;
            dataGridViewComenzi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewComenzi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewComenzi.ColumnHeadersHeight = 36;
            dataGridViewComenzi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewComenzi.EnableHeadersVisualStyles = false;
            dataGridViewComenzi.GridColor = Color.WhiteSmoke;
            dataGridViewComenzi.Location = new Point(7, 12);
            dataGridViewComenzi.Name = "dataGridViewComenzi";
            dataGridViewComenzi.RowHeadersVisible = false;
            dataGridViewComenzi.RowHeadersWidth = 62;
            dataGridViewComenzi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewComenzi.RowTemplate.Height = 32;
            dataGridViewComenzi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewComenzi.Size = new Size(880, 379);
            dataGridViewComenzi.TabIndex = 0;
            dataGridViewComenzi.SelectionChanged += dataGridViewComenzi_SelectionChanged;
            // 
            // panelPlati
            // 
            panelPlati.BackColor = Color.WhiteSmoke;
            panelPlati.Controls.Add(comboBoxFiltrarePlata);
            panelPlati.Controls.Add(label4);
            panelPlati.Controls.Add(dataGridViewPlati);
            panelPlati.Location = new Point(200, 0);
            panelPlati.Name = "panelPlati";
            panelPlati.Size = new Size(900, 680);
            panelPlati.TabIndex = 5;
            // 
            // comboBoxFiltrarePlata
            // 
            comboBoxFiltrarePlata.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltrarePlata.FlatStyle = FlatStyle.Flat;
            comboBoxFiltrarePlata.Font = new Font("Segoe UI", 10F);
            comboBoxFiltrarePlata.FormattingEnabled = true;
            comboBoxFiltrarePlata.Location = new Point(313, 363);
            comboBoxFiltrarePlata.Name = "comboBoxFiltrarePlata";
            comboBoxFiltrarePlata.Size = new Size(200, 36);
            comboBoxFiltrarePlata.TabIndex = 2;
            comboBoxFiltrarePlata.SelectedIndexChanged += comboBoxFiltrarePlata_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label4.Location = new Point(7, 366);
            label4.Name = "label4";
            label4.Size = new Size(300, 25);
            label4.TabIndex = 1;
            label4.Text = "Sortează după metoda de plată: ";
            // 
            // dataGridViewPlati
            // 
            dataGridViewPlati.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPlati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlati.BackgroundColor = Color.WhiteSmoke;
            dataGridViewPlati.BorderStyle = BorderStyle.None;
            dataGridViewPlati.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPlati.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPlati.ColumnHeadersHeight = 36;
            dataGridViewPlati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPlati.EnableHeadersVisualStyles = false;
            dataGridViewPlati.GridColor = Color.GhostWhite;
            dataGridViewPlati.Location = new Point(7, 12);
            dataGridViewPlati.Name = "dataGridViewPlati";
            dataGridViewPlati.RowHeadersVisible = false;
            dataGridViewPlati.RowHeadersWidth = 62;
            dataGridViewPlati.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPlati.RowTemplate.Height = 32;
            dataGridViewPlati.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlati.Size = new Size(880, 331);
            dataGridViewPlati.TabIndex = 0;
            // 
            // panelPreturi
            // 
            panelPreturi.Controls.Add(dataGridViewPreturi);
            panelPreturi.Location = new Point(200, 0);
            panelPreturi.Name = "panelPreturi";
            panelPreturi.Size = new Size(900, 680);
            panelPreturi.TabIndex = 6;
            // 
            // dataGridViewPreturi
            // 
            dataGridViewPreturi.AllowUserToAddRows = false;
            dataGridViewPreturi.AllowUserToDeleteRows = false;
            dataGridViewPreturi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPreturi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPreturi.BackgroundColor = Color.WhiteSmoke;
            dataGridViewPreturi.BorderStyle = BorderStyle.None;
            dataGridViewPreturi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPreturi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPreturi.ColumnHeadersHeight = 36;
            dataGridViewPreturi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPreturi.EnableHeadersVisualStyles = false;
            dataGridViewPreturi.GridColor = Color.GhostWhite;
            dataGridViewPreturi.Location = new Point(7, 12);
            dataGridViewPreturi.Name = "dataGridViewPreturi";
            dataGridViewPreturi.ReadOnly = true;
            dataGridViewPreturi.RowHeadersVisible = false;
            dataGridViewPreturi.RowHeadersWidth = 62;
            dataGridViewPreturi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPreturi.RowTemplate.Height = 32;
            dataGridViewPreturi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPreturi.Size = new Size(813, 319);
            dataGridViewPreturi.TabIndex = 0;
            // 
            // panelNotificari
            // 
            panelNotificari.Controls.Add(dataGridViewNotificari);
            panelNotificari.Location = new Point(200, 0);
            panelNotificari.Name = "panelNotificari";
            panelNotificari.Size = new Size(900, 680);
            panelNotificari.TabIndex = 1;
            // 
            // dataGridViewNotificari
            // 
            dataGridViewNotificari.AllowUserToAddRows = false;
            dataGridViewNotificari.AllowUserToDeleteRows = false;
            dataGridViewNotificari.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewNotificari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNotificari.BackgroundColor = Color.WhiteSmoke;
            dataGridViewNotificari.BorderStyle = BorderStyle.None;
            dataGridViewNotificari.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewNotificari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewNotificari.ColumnHeadersHeight = 36;
            dataGridViewNotificari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewNotificari.EnableHeadersVisualStyles = false;
            dataGridViewNotificari.GridColor = Color.GhostWhite;
            dataGridViewNotificari.Location = new Point(7, 12);
            dataGridViewNotificari.Name = "dataGridViewNotificari";
            dataGridViewNotificari.ReadOnly = true;
            dataGridViewNotificari.RowHeadersVisible = false;
            dataGridViewNotificari.RowHeadersWidth = 62;
            dataGridViewNotificari.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewNotificari.RowTemplate.Height = 32;
            dataGridViewNotificari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNotificari.Size = new Size(880, 319);
            dataGridViewNotificari.TabIndex = 0;
            // 
            // FormAngajat
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 624);
            Controls.Add(panelMeniu);
            Controls.Add(panelComenzi);
            Controls.Add(panelPlati);
            Controls.Add(panelNotificari);
            Controls.Add(panelPreturi);
            Font = new Font("Segoe UI", 9.5F);
            Name = "FormAngajat";
            Text = "DashBoardAngajat";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormAngajat_FormClosed;
            Load += FormAngajat_Load;
            panelMeniu.ResumeLayout(false);
            panelComenzi.ResumeLayout(false);
            panelComenzi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComenzi).EndInit();
            panelPlati.ResumeLayout(false);
            panelPlati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlati).EndInit();
            panelPreturi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreturi).EndInit();
            panelNotificari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotificari).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMeniu;
        private Button buttonNvgComenzi;
        private Panel panelComenzi;
        private DataGridView dataGridViewComenzi;
        private Button buttonNvgIncasari;
        private Button buttonDetalii;
        private Button buttonSalveazaStatus;
        private ComboBox comboBoxStatus;
        private Label label1;
        private Button buttonNvgDelogare;
        private Button buttonNvgNotificari;
        private Button buttonNvgPreturi;
        private Panel panelPlati;
        private DataGridView dataGridViewPlati;
        private Panel panelPreturi;
        private DataGridView dataGridViewPreturi;
        private Panel panelNotificari;
        private DataGridView dataGridViewNotificari;
        private ComboBox comboBoxFiltru;
        private Label label3;
        private TextBox textBoxCautare;
        private Label label2;
        private ComboBox comboBoxFiltrarePlata;
        private Label label4;
    }
}