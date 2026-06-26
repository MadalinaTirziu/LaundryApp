using Microsoft.EntityFrameworkCore;
using ProiectMSOA.Data;
using ProiectMSOA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectMSOA
{
    public partial class FormAngajat : Form
    {
        private bool loggedIn = false;
        private AppDbContext dbContext = new AppDbContext();
        private void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 242, 253);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(21, 101, 192);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 248);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }
        public FormAngajat()
        {
            InitializeComponent();
            panelMeniu.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgComenzi.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgIncasari.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgPreturi.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgNotificari.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgDelogare.BackColor = Color.FromArgb(13, 71, 161);

            buttonSalveazaStatus.BackColor = Color.FromArgb(21, 101, 192); 
            buttonDetalii.BackColor = Color.FromArgb(21, 101, 192);

            StyleGrid(dataGridViewComenzi);
            StyleGrid(dataGridViewPlati);
            StyleGrid(dataGridViewNotificari);
            StyleGrid(dataGridViewPreturi);
        }
        private void IncarcaComenzi()
        {
            var listaComenzi = dbContext.Comenzi.Include(c => c.Utilizator).ToList();
            dataGridViewComenzi.DataSource = listaComenzi;
            if (dataGridViewComenzi.Columns["Utilizator"] != null)
                dataGridViewComenzi.Columns["Utilizator"].Visible = false;
        }

        private void IncarcaPlati()
        {
            var listaPlati = dbContext.Plati.Include(p => p.Comanda).ToList();
            dataGridViewPlati.DataSource = listaPlati;
            if (dataGridViewPlati.Columns["Comanda"] != null)
                dataGridViewPlati.Columns["Comanda"].Visible = false;

        }

        private void IncarcaPreturi()
        {
            var listaServicii = dbContext.Servicii.ToList();
            dataGridViewPreturi.DataSource = listaServicii;
            dataGridViewPreturi.Columns["ServiciuId"].Visible = false;
            dataGridViewPreturi.Columns["Durata"].Visible = false;

        }
        private void IncarcaNotificari()
        {
            var listaNotificari = dbContext.Notificari.ToList();
            dataGridViewNotificari.DataSource = listaNotificari;
            if (dataGridViewNotificari.Columns["Utilizator"] != null)
                dataGridViewNotificari.Columns["Utilizator"].Visible = false;
            if (dataGridViewNotificari.Columns["NotificareId"] != null)
            {
                dataGridViewNotificari.Columns["NotificareId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewNotificari.Columns["NotificareId"].Width = 40;
            }
            if (dataGridViewNotificari.Columns["UtilizatorId"] != null)
            {
                dataGridViewNotificari.Columns["UtilizatorId"].Visible = false;
            }
            if (dataGridViewNotificari.Columns["Mesaj"] != null)
            {
                dataGridViewNotificari.Columns["Mesaj"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void CautaComenzi()
        {
            string persoanaCautata = textBoxCautare.Text.Trim().ToLower();
            var cautare = dbContext.Comenzi.Include(c => c.Utilizator).Where(c => c.Utilizator.Nume.ToLower().Contains(persoanaCautata)).ToList();
            dataGridViewComenzi.DataSource = cautare;
        }
        private void FiltreazaComenzi()
        {
            if (comboBoxFiltru.SelectedIndex == 0)
            {
                IncarcaComenzi();
            }
            else
            {
                StatusComanda statusSelectat = (StatusComanda)comboBoxFiltru.SelectedItem;
                var comenziFiltrate = dbContext.Comenzi.Include(c => c.Utilizator).Where(c => c.Status == statusSelectat).ToList();
                dataGridViewComenzi.DataSource = comenziFiltrate;
                if (dataGridViewComenzi.Columns["Utilizator"] != null)
                    dataGridViewComenzi.Columns["Utilizator"].Visible = false;
            }
        }
        private void FiltreazaPlati()
        {
            if (comboBoxFiltrarePlata.SelectedIndex == 0)
            {
                IncarcaPlati();
            }
            else
            {
                MetodaPlata metodaSelectata = (MetodaPlata)comboBoxFiltrarePlata.SelectedItem;
                var platiFiltrate = dbContext.Plati.Include(p => p.Comanda).Where(p => p.Metoda == metodaSelectata).ToList();
                dataGridViewPlati.DataSource = platiFiltrate;
                if (dataGridViewPlati.Columns["Comanda"] != null)
                    dataGridViewPlati.Columns["Comanda"].Visible = false;
            }
        }

        private void FormAngajat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggedIn)
            {
                Application.Exit();
            }
        }

        private void FormAngajat_Load(object sender, EventArgs e)
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(StatusComanda));

            comboBoxFiltru.Items.Clear();
            comboBoxFiltru.Items.Add("Toate");
            foreach (var status in Enum.GetValues(typeof(StatusComanda)))
            {
                comboBoxFiltru.Items.Add(status);
            }
            comboBoxFiltru.SelectedIndex = 0;

            comboBoxFiltrarePlata.Items.Clear();
            comboBoxFiltrarePlata.Items.Add("Toate");
            foreach (var metoda in Enum.GetValues(typeof(MetodaPlata)))
            {
                comboBoxFiltrarePlata.Items.Add(metoda);
            }
            comboBoxFiltrarePlata.SelectedIndex = 0;

            panelComenzi.BringToFront();
            IncarcaComenzi();
            IncarcaPlati();
            IncarcaPreturi();
            IncarcaNotificari();
        }

        private void dataGridViewComenzi_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewComenzi.CurrentRow != null)
            {
                Comanda comandaSelectata = (Comanda)dataGridViewComenzi.CurrentRow.DataBoundItem;
                comboBoxStatus.SelectedItem = comandaSelectata.Status;
            }
        }

        private void buttonSalveazaStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewComenzi.CurrentRow != null)
            {
                Comanda comandaSelectata = (Comanda)dataGridViewComenzi.CurrentRow.DataBoundItem;
                comandaSelectata.Status = (StatusComanda)comboBoxStatus.SelectedItem;
                dbContext.SaveChanges();
                IncarcaComenzi();
                MessageBox.Show("Statusul comenzii a fost actualizat cu succes.");
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați o comandă pentru a actualiza statusul.");
            }
        }

        private void buttonDetalii_Click(object sender, EventArgs e)
        {
            if (dataGridViewComenzi.CurrentRow != null)
            {
                Comanda comandaSelectata = (Comanda)dataGridViewComenzi.CurrentRow.DataBoundItem;

                string detalii = $"Client: {comandaSelectata.Utilizator?.Nume}\n";
                detalii += $"Data: {comandaSelectata.DataComenzii}\n";
                detalii += "Servicii alese:\n";

                decimal total = 0;
                foreach (var serviciu in comandaSelectata.ServiciiComandate)
                {
                     detalii += $"- {serviciu.Denumire} ({serviciu.Pret} lei)\n";
                     total += serviciu.Pret;
                }
                detalii += $"TOTAL DE PLATĂ: {total} lei";

                MessageBox.Show(detalii, $"Detalii Comanda #{comandaSelectata.ComandaId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați o comandă pentru a vizualiza detaliile.");
            }
            
        }

        private void buttonNvgIncasari_Click(object sender, EventArgs e)
        {
            IncarcaPlati();
            panelPlati.BringToFront();
        }

        private void buttonNvgComenzi_Click(object sender, EventArgs e)
        {
            IncarcaComenzi();
            panelComenzi.BringToFront();
        }

        private void buttonNvgPreturi_Click(object sender, EventArgs e)
        {
            IncarcaPreturi();
            panelPreturi.BringToFront();
        }

        private void buttonNvgNotificari_Click(object sender, EventArgs e)
        {
            IncarcaNotificari();
            panelNotificari.BringToFront();
        }

        private void buttonNvgDelogare_Click(object sender, EventArgs e)
        {
            loggedIn = true;
            var raspuns = MessageBox.Show("Ești sigur că vrei să te deloghezi?", "Confirmare delogare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (raspuns == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxCautare_TextChanged(object sender, EventArgs e)
        {
            CautaComenzi();
        }

        private void comboBoxFiltru_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreazaComenzi();
        }

        private void comboBoxFiltrarePlata_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreazaPlati();
        }
    }
}
