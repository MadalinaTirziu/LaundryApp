namespace ProiectMSOA
{
    partial class FormDashBoardAdmin
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewUtilizatori = new DataGridView();
            comboBoxRol = new ComboBox();
            buttonSalvare = new Button();
            buttonSterge = new Button();
            panelSetari = new Panel();
            textBoxProgramWeekend = new TextBox();
            label7 = new Label();
            textBoxProgramSaptamana = new TextBox();
            label6 = new Label();
            label5 = new Label();
            buttonSetari = new Button();
            textBoxTelefon = new TextBox();
            textBoxAdresa = new TextBox();
            textBoxNume = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProviderSetare = new ErrorProvider(components);
            dataGridViewServicii = new DataGridView();
            dataGridViewRapoarte = new DataGridView();
            panelUtilizatori = new Panel();
            comboBoxFiltruRol = new ComboBox();
            label4 = new Label();
            panelServicii = new Panel();
            buttonStergeServiciu = new Button();
            buttonModificaServiciu = new Button();
            buttonAdaugaServiciu = new Button();
            panelRapoarte = new Panel();
            buttonRapoarte = new Button();
            panelMeniu = new Panel();
            buttonNvgDelogare = new Button();
            buttonNvgRapoarte = new Button();
            buttonNvgServicii = new Button();
            buttonNvgSetari = new Button();
            buttonNvgUtilizatori = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtilizatori).BeginInit();
            panelSetari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderSetare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicii).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapoarte).BeginInit();
            panelUtilizatori.SuspendLayout();
            panelServicii.SuspendLayout();
            panelRapoarte.SuspendLayout();
            panelMeniu.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUtilizatori
            // 
            dataGridViewUtilizatori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUtilizatori.BackgroundColor = Color.WhiteSmoke;
            dataGridViewUtilizatori.BorderStyle = BorderStyle.None;
            dataGridViewUtilizatori.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUtilizatori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUtilizatori.ColumnHeadersHeight = 36;
            dataGridViewUtilizatori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewUtilizatori.EnableHeadersVisualStyles = false;
            dataGridViewUtilizatori.GridColor = Color.GhostWhite;
            dataGridViewUtilizatori.Location = new Point(3, 7);
            dataGridViewUtilizatori.Name = "dataGridViewUtilizatori";
            dataGridViewUtilizatori.RowHeadersVisible = false;
            dataGridViewUtilizatori.RowHeadersWidth = 62;
            dataGridViewUtilizatori.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewUtilizatori.RowTemplate.Height = 32;
            dataGridViewUtilizatori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUtilizatori.Size = new Size(793, 176);
            dataGridViewUtilizatori.TabIndex = 0;
            dataGridViewUtilizatori.SelectionChanged += dataGridViewUtilizatori_SelectionChanged;
            // 
            // comboBoxRol
            // 
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FlatStyle = FlatStyle.Flat;
            comboBoxRol.Font = new Font("Segoe UI", 10F);
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(411, 235);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(200, 36);
            comboBoxRol.TabIndex = 3;
            // 
            // buttonSalvare
            // 
            buttonSalvare.Cursor = Cursors.Hand;
            buttonSalvare.FlatStyle = FlatStyle.Flat;
            buttonSalvare.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonSalvare.ForeColor = Color.White;
            buttonSalvare.Location = new Point(646, 229);
            buttonSalvare.Name = "buttonSalvare";
            buttonSalvare.Size = new Size(182, 38);
            buttonSalvare.TabIndex = 2;
            buttonSalvare.Text = "Salvare modificări";
            buttonSalvare.UseVisualStyleBackColor = true;
            buttonSalvare.Click += buttonSalvare_Click;
            // 
            // buttonSterge
            // 
            buttonSterge.Cursor = Cursors.Hand;
            buttonSterge.FlatStyle = FlatStyle.Flat;
            buttonSterge.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonSterge.ForeColor = Color.White;
            buttonSterge.Location = new Point(13, 220);
            buttonSterge.Name = "buttonSterge";
            buttonSterge.Size = new Size(150, 38);
            buttonSterge.TabIndex = 1;
            buttonSterge.Text = "Șterge utilizator";
            buttonSterge.UseVisualStyleBackColor = true;
            buttonSterge.Click += buttonSterge_Click;
            // 
            // panelSetari
            // 
            panelSetari.BackColor = Color.WhiteSmoke;
            panelSetari.Controls.Add(textBoxProgramWeekend);
            panelSetari.Controls.Add(label7);
            panelSetari.Controls.Add(textBoxProgramSaptamana);
            panelSetari.Controls.Add(label6);
            panelSetari.Controls.Add(label5);
            panelSetari.Controls.Add(buttonSetari);
            panelSetari.Controls.Add(textBoxTelefon);
            panelSetari.Controls.Add(textBoxAdresa);
            panelSetari.Controls.Add(textBoxNume);
            panelSetari.Controls.Add(label3);
            panelSetari.Controls.Add(label2);
            panelSetari.Controls.Add(label1);
            panelSetari.Location = new Point(200, 0);
            panelSetari.Name = "panelSetari";
            panelSetari.Size = new Size(900, 680);
            panelSetari.TabIndex = 2;
            // 
            // textBoxProgramWeekend
            // 
            textBoxProgramWeekend.BorderStyle = BorderStyle.FixedSingle;
            textBoxProgramWeekend.Font = new Font("Segoe UI", 10F);
            textBoxProgramWeekend.Location = new Point(169, 305);
            textBoxProgramWeekend.Name = "textBoxProgramWeekend";
            textBoxProgramWeekend.Size = new Size(280, 34);
            textBoxProgramWeekend.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label7.Location = new Point(30, 308);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 10;
            label7.Text = "Weekend: ";
            // 
            // textBoxProgramSaptamana
            // 
            textBoxProgramSaptamana.BorderStyle = BorderStyle.FixedSingle;
            textBoxProgramSaptamana.Font = new Font("Segoe UI", 10F);
            textBoxProgramSaptamana.Location = new Point(169, 247);
            textBoxProgramSaptamana.Name = "textBoxProgramSaptamana";
            textBoxProgramSaptamana.Size = new Size(280, 34);
            textBoxProgramSaptamana.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label6.Location = new Point(30, 250);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 8;
            label6.Text = "Luni - vineri: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label5.Location = new Point(30, 207);
            label5.Name = "label5";
            label5.Size = new Size(169, 25);
            label5.TabIndex = 7;
            label5.Text = "Program de lucru";
            // 
            // buttonSetari
            // 
            buttonSetari.Cursor = Cursors.Hand;
            buttonSetari.FlatStyle = FlatStyle.Flat;
            buttonSetari.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonSetari.Location = new Point(117, 361);
            buttonSetari.Name = "buttonSetari";
            buttonSetari.Size = new Size(180, 38);
            buttonSetari.TabIndex = 6;
            buttonSetari.Text = "Salvare modificări";
            buttonSetari.UseVisualStyleBackColor = true;
            buttonSetari.Click += buttonSetari_Click;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.BorderStyle = BorderStyle.FixedSingle;
            textBoxTelefon.Font = new Font("Segoe UI", 10F);
            textBoxTelefon.Location = new Point(30, 138);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(280, 34);
            textBoxTelefon.TabIndex = 5;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.BorderStyle = BorderStyle.FixedSingle;
            textBoxAdresa.Font = new Font("Segoe UI", 10F);
            textBoxAdresa.Location = new Point(331, 66);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(280, 34);
            textBoxAdresa.TabIndex = 4;
            // 
            // textBoxNume
            // 
            textBoxNume.BorderStyle = BorderStyle.FixedSingle;
            textBoxNume.Font = new Font("Segoe UI", 10F);
            textBoxNume.Location = new Point(30, 73);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(280, 34);
            textBoxNume.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.Location = new Point(331, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Adresă";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            // 
            // errorProviderSetare
            // 
            errorProviderSetare.ContainerControl = this;
            // 
            // dataGridViewServicii
            // 
            dataGridViewServicii.BackgroundColor = Color.WhiteSmoke;
            dataGridViewServicii.BorderStyle = BorderStyle.None;
            dataGridViewServicii.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewServicii.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewServicii.ColumnHeadersHeight = 36;
            dataGridViewServicii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewServicii.EnableHeadersVisualStyles = false;
            dataGridViewServicii.GridColor = Color.GhostWhite;
            dataGridViewServicii.Location = new Point(13, 12);
            dataGridViewServicii.Name = "dataGridViewServicii";
            dataGridViewServicii.RowHeadersVisible = false;
            dataGridViewServicii.RowHeadersWidth = 62;
            dataGridViewServicii.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewServicii.RowTemplate.Height = 32;
            dataGridViewServicii.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServicii.Size = new Size(783, 231);
            dataGridViewServicii.TabIndex = 0;
            // 
            // dataGridViewRapoarte
            // 
            dataGridViewRapoarte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRapoarte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRapoarte.BackgroundColor = Color.WhiteSmoke;
            dataGridViewRapoarte.BorderStyle = BorderStyle.None;
            dataGridViewRapoarte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRapoarte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRapoarte.ColumnHeadersHeight = 36;
            dataGridViewRapoarte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewRapoarte.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRapoarte.EnableHeadersVisualStyles = false;
            dataGridViewRapoarte.GridColor = Color.GhostWhite;
            dataGridViewRapoarte.Location = new Point(0, 12);
            dataGridViewRapoarte.Name = "dataGridViewRapoarte";
            dataGridViewRapoarte.ReadOnly = true;
            dataGridViewRapoarte.RowHeadersVisible = false;
            dataGridViewRapoarte.RowHeadersWidth = 62;
            dataGridViewRapoarte.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewRapoarte.RowTemplate.Height = 32;
            dataGridViewRapoarte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRapoarte.Size = new Size(875, 196);
            dataGridViewRapoarte.TabIndex = 1;
            // 
            // panelUtilizatori
            // 
            panelUtilizatori.BackColor = Color.WhiteSmoke;
            panelUtilizatori.Controls.Add(comboBoxFiltruRol);
            panelUtilizatori.Controls.Add(label4);
            panelUtilizatori.Controls.Add(comboBoxRol);
            panelUtilizatori.Controls.Add(dataGridViewUtilizatori);
            panelUtilizatori.Controls.Add(buttonSalvare);
            panelUtilizatori.Controls.Add(buttonSterge);
            panelUtilizatori.Location = new Point(200, 0);
            panelUtilizatori.Name = "panelUtilizatori";
            panelUtilizatori.Size = new Size(900, 680);
            panelUtilizatori.TabIndex = 5;
            // 
            // comboBoxFiltruRol
            // 
            comboBoxFiltruRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltruRol.FlatStyle = FlatStyle.Flat;
            comboBoxFiltruRol.Font = new Font("Segoe UI", 10F);
            comboBoxFiltruRol.FormattingEnabled = true;
            comboBoxFiltruRol.Location = new Point(148, 333);
            comboBoxFiltruRol.Name = "comboBoxFiltruRol";
            comboBoxFiltruRol.Size = new Size(200, 36);
            comboBoxFiltruRol.TabIndex = 5;
            comboBoxFiltruRol.SelectedIndexChanged += comboBoxFiltruRol_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label4.Location = new Point(13, 333);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 4;
            label4.Text = "Filtrare rol: ";
            // 
            // panelServicii
            // 
            panelServicii.Controls.Add(buttonStergeServiciu);
            panelServicii.Controls.Add(buttonModificaServiciu);
            panelServicii.Controls.Add(buttonAdaugaServiciu);
            panelServicii.Controls.Add(dataGridViewServicii);
            panelServicii.Location = new Point(200, 0);
            panelServicii.Name = "panelServicii";
            panelServicii.Size = new Size(1078, 624);
            panelServicii.TabIndex = 6;
            // 
            // buttonStergeServiciu
            // 
            buttonStergeServiciu.Cursor = Cursors.Hand;
            buttonStergeServiciu.FlatStyle = FlatStyle.Flat;
            buttonStergeServiciu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonStergeServiciu.Location = new Point(502, 249);
            buttonStergeServiciu.Name = "buttonStergeServiciu";
            buttonStergeServiciu.Size = new Size(150, 38);
            buttonStergeServiciu.TabIndex = 3;
            buttonStergeServiciu.Text = "Șterge";
            buttonStergeServiciu.UseVisualStyleBackColor = true;
            buttonStergeServiciu.Click += buttonStergeServiciu_Click;
            // 
            // buttonModificaServiciu
            // 
            buttonModificaServiciu.Cursor = Cursors.Hand;
            buttonModificaServiciu.FlatStyle = FlatStyle.Flat;
            buttonModificaServiciu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonModificaServiciu.Location = new Point(246, 249);
            buttonModificaServiciu.Name = "buttonModificaServiciu";
            buttonModificaServiciu.Size = new Size(150, 38);
            buttonModificaServiciu.TabIndex = 2;
            buttonModificaServiciu.Text = "Modifică";
            buttonModificaServiciu.UseVisualStyleBackColor = true;
            buttonModificaServiciu.Click += buttonModificaServiciu_Click;
            // 
            // buttonAdaugaServiciu
            // 
            buttonAdaugaServiciu.Cursor = Cursors.Hand;
            buttonAdaugaServiciu.FlatStyle = FlatStyle.Flat;
            buttonAdaugaServiciu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonAdaugaServiciu.Location = new Point(13, 249);
            buttonAdaugaServiciu.Name = "buttonAdaugaServiciu";
            buttonAdaugaServiciu.Size = new Size(150, 38);
            buttonAdaugaServiciu.TabIndex = 1;
            buttonAdaugaServiciu.Text = "Adaugă";
            buttonAdaugaServiciu.UseVisualStyleBackColor = true;
            buttonAdaugaServiciu.Click += buttonAdaugaServiciu_Click;
            // 
            // panelRapoarte
            // 
            panelRapoarte.BackColor = Color.WhiteSmoke;
            panelRapoarte.Controls.Add(buttonRapoarte);
            panelRapoarte.Controls.Add(dataGridViewRapoarte);
            panelRapoarte.Location = new Point(200, 0);
            panelRapoarte.Name = "panelRapoarte";
            panelRapoarte.Size = new Size(900, 680);
            panelRapoarte.TabIndex = 7;
            // 
            // buttonRapoarte
            // 
            buttonRapoarte.Cursor = Cursors.Hand;
            buttonRapoarte.FlatStyle = FlatStyle.Flat;
            buttonRapoarte.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            buttonRapoarte.Location = new Point(13, 235);
            buttonRapoarte.Name = "buttonRapoarte";
            buttonRapoarte.Size = new Size(202, 38);
            buttonRapoarte.TabIndex = 2;
            buttonRapoarte.Text = "Generează Rapoarte";
            buttonRapoarte.UseVisualStyleBackColor = true;
            buttonRapoarte.Click += buttonRapoarte_Click;
            // 
            // panelMeniu
            // 
            panelMeniu.BackColor = SystemColors.AppWorkspace;
            panelMeniu.Controls.Add(buttonNvgDelogare);
            panelMeniu.Controls.Add(buttonNvgRapoarte);
            panelMeniu.Controls.Add(buttonNvgServicii);
            panelMeniu.Controls.Add(buttonNvgSetari);
            panelMeniu.Controls.Add(buttonNvgUtilizatori);
            panelMeniu.Dock = DockStyle.Left;
            panelMeniu.Location = new Point(0, 0);
            panelMeniu.Name = "panelMeniu";
            panelMeniu.Size = new Size(200, 624);
            panelMeniu.TabIndex = 8;
            // 
            // buttonNvgDelogare
            // 
            buttonNvgDelogare.BackColor = SystemColors.AppWorkspace;
            buttonNvgDelogare.Cursor = Cursors.Hand;
            buttonNvgDelogare.Dock = DockStyle.Top;
            buttonNvgDelogare.FlatAppearance.BorderSize = 0;
            buttonNvgDelogare.FlatStyle = FlatStyle.Flat;
            buttonNvgDelogare.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNvgDelogare.ForeColor = Color.White;
            buttonNvgDelogare.Location = new Point(0, 220);
            buttonNvgDelogare.Name = "buttonNvgDelogare";
            buttonNvgDelogare.Padding = new Padding(20, 0, 0, 0);
            buttonNvgDelogare.Size = new Size(200, 55);
            buttonNvgDelogare.TabIndex = 13;
            buttonNvgDelogare.Text = "Ieșire Cont";
            buttonNvgDelogare.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgDelogare.UseVisualStyleBackColor = false;
            buttonNvgDelogare.Click += buttonNvgDelogare_Click;
            // 
            // buttonNvgRapoarte
            // 
            buttonNvgRapoarte.BackColor = SystemColors.AppWorkspace;
            buttonNvgRapoarte.Cursor = Cursors.Hand;
            buttonNvgRapoarte.Dock = DockStyle.Top;
            buttonNvgRapoarte.FlatAppearance.BorderSize = 0;
            buttonNvgRapoarte.FlatStyle = FlatStyle.Flat;
            buttonNvgRapoarte.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNvgRapoarte.ForeColor = Color.White;
            buttonNvgRapoarte.Location = new Point(0, 165);
            buttonNvgRapoarte.Name = "buttonNvgRapoarte";
            buttonNvgRapoarte.Padding = new Padding(20, 0, 0, 0);
            buttonNvgRapoarte.Size = new Size(200, 55);
            buttonNvgRapoarte.TabIndex = 12;
            buttonNvgRapoarte.Text = "Rapoarte";
            buttonNvgRapoarte.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgRapoarte.UseVisualStyleBackColor = false;
            buttonNvgRapoarte.Click += buttonNvgRapoarte_Click;
            // 
            // buttonNvgServicii
            // 
            buttonNvgServicii.BackColor = SystemColors.AppWorkspace;
            buttonNvgServicii.Cursor = Cursors.Hand;
            buttonNvgServicii.Dock = DockStyle.Top;
            buttonNvgServicii.FlatAppearance.BorderSize = 0;
            buttonNvgServicii.FlatStyle = FlatStyle.Flat;
            buttonNvgServicii.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNvgServicii.ForeColor = Color.White;
            buttonNvgServicii.Location = new Point(0, 110);
            buttonNvgServicii.Name = "buttonNvgServicii";
            buttonNvgServicii.Padding = new Padding(20, 0, 0, 0);
            buttonNvgServicii.Size = new Size(200, 55);
            buttonNvgServicii.TabIndex = 11;
            buttonNvgServicii.Text = "Servicii";
            buttonNvgServicii.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgServicii.UseVisualStyleBackColor = false;
            buttonNvgServicii.Click += buttonNvgServicii_Click;
            // 
            // buttonNvgSetari
            // 
            buttonNvgSetari.BackColor = SystemColors.AppWorkspace;
            buttonNvgSetari.Cursor = Cursors.Hand;
            buttonNvgSetari.Dock = DockStyle.Top;
            buttonNvgSetari.FlatAppearance.BorderSize = 0;
            buttonNvgSetari.FlatStyle = FlatStyle.Flat;
            buttonNvgSetari.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNvgSetari.ForeColor = Color.White;
            buttonNvgSetari.Location = new Point(0, 55);
            buttonNvgSetari.Name = "buttonNvgSetari";
            buttonNvgSetari.Padding = new Padding(20, 0, 0, 0);
            buttonNvgSetari.Size = new Size(200, 55);
            buttonNvgSetari.TabIndex = 10;
            buttonNvgSetari.Text = "Setări generale";
            buttonNvgSetari.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgSetari.UseVisualStyleBackColor = false;
            buttonNvgSetari.Click += buttonNvgSetari_Click;
            // 
            // buttonNvgUtilizatori
            // 
            buttonNvgUtilizatori.BackColor = SystemColors.AppWorkspace;
            buttonNvgUtilizatori.Cursor = Cursors.Hand;
            buttonNvgUtilizatori.Dock = DockStyle.Top;
            buttonNvgUtilizatori.FlatAppearance.BorderSize = 0;
            buttonNvgUtilizatori.FlatStyle = FlatStyle.Flat;
            buttonNvgUtilizatori.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNvgUtilizatori.ForeColor = Color.White;
            buttonNvgUtilizatori.Location = new Point(0, 0);
            buttonNvgUtilizatori.Name = "buttonNvgUtilizatori";
            buttonNvgUtilizatori.Padding = new Padding(20, 0, 0, 0);
            buttonNvgUtilizatori.Size = new Size(200, 55);
            buttonNvgUtilizatori.TabIndex = 9;
            buttonNvgUtilizatori.Text = "Utilizatori";
            buttonNvgUtilizatori.TextAlign = ContentAlignment.MiddleLeft;
            buttonNvgUtilizatori.UseVisualStyleBackColor = false;
            buttonNvgUtilizatori.Click += buttonNvgUtilizatori_Click;
            // 
            // FormDashBoardAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 624);
            Controls.Add(panelMeniu);
            Controls.Add(panelRapoarte);
            Controls.Add(panelServicii);
            Controls.Add(panelUtilizatori);
            Controls.Add(panelSetari);
            Font = new Font("Segoe UI", 9.5F);
            Name = "FormDashBoardAdmin";
            Text = "DashBoardAdmin";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormDashBoardAdmin_FormClosed;
            Load += FormDashBoardAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtilizatori).EndInit();
            panelSetari.ResumeLayout(false);
            panelSetari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderSetare).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicii).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapoarte).EndInit();
            panelUtilizatori.ResumeLayout(false);
            panelUtilizatori.PerformLayout();
            panelServicii.ResumeLayout(false);
            panelRapoarte.ResumeLayout(false);
            panelMeniu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUtilizatori;
        private Button buttonSalvare;
        private Button buttonSterge;
        private ComboBox comboBoxRol;
        private Panel panelSetari;
        private Button buttonSetari;
        private TextBox textBoxTelefon;
        private TextBox textBoxAdresa;
        private TextBox textBoxNume;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProviderSetare;
        private DataGridView dataGridViewServicii;
        private DataGridView dataGridViewRapoarte;
        private Panel panelServicii;
        private Panel panelUtilizatori;
        private Panel panelMeniu;
        private Button buttonNvgRapoarte;
        private Button buttonNvgServicii;
        private Button buttonNvgSetari;
        private Button buttonNvgUtilizatori;
        private Panel panelRapoarte;
        private Button buttonStergeServiciu;
        private Button buttonModificaServiciu;
        private Button buttonAdaugaServiciu;
        private Button buttonRapoarte;
        private Button buttonNvgDelogare;
        private ComboBox comboBoxFiltruRol;
        private Label label4;
        private TextBox textBoxProgramWeekend;
        private Label label7;
        private TextBox textBoxProgramSaptamana;
        private Label label6;
        private Label label5;
    }
}