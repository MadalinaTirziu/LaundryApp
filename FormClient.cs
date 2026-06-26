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
    public partial class FormClient : Form
    {
        private AppDbContext dbContext = new AppDbContext();
        private Utilizator utilizatorLogat;
        private List<Serviciu> serviciiDisponibile;
        private bool loggedIn = false;
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
        public FormClient(Utilizator client)
        {
            InitializeComponent();
            utilizatorLogat = client;

            panelMeniu.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgComandaNoua.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgIstoric.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgCont.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgDelogare.BackColor = Color.FromArgb(13, 71, 161);
            buttonPlaseazaComanda.BackColor = Color.FromArgb(21, 101, 192);
            buttonSalvareParola.BackColor = Color.FromArgb(21, 101, 192);
            textBoxParolaNoua.BackColor = Color.FromArgb(240, 244, 248);
            buttonPlaseazaComanda.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label7.ForeColor = Color.FromArgb(100, 116, 139);
            label4.ForeColor = Color.FromArgb(100, 116, 139);
            comboBoxMetodaPlata.BackColor = Color.FromArgb(240, 244, 248);
            StyleGrid(dataGridViewIstoric);
            label2.Text = $"Bună ziua, {utilizatorLogat.Nume}!";
            label2.ForeColor = Color.FromArgb(21, 101, 192);
        }
        private void IncarcaServiciiDisponibile()
        {
            serviciiDisponibile = dbContext.Servicii.ToList();
            checkedListBoxServicii.Items.Clear();
            foreach (var sv in serviciiDisponibile)
            {
                checkedListBoxServicii.Items.Add($"Nume: {sv.Denumire}, Pret: {sv.Pret} lei, Durata: {sv.Durata} minute");
            }
        }
        private void SortarePret()
        {
            var serviciiSortate = dbContext.Servicii.AsQueryable();
            if (radioButtonCrescator.Checked)
            {
                serviciiSortate = serviciiSortate.OrderBy(s => s.Pret);
            }
            else if (radioButtonDescrescator.Checked)
            {
                serviciiSortate = serviciiSortate.OrderByDescending(s => s.Pret);
            }
            serviciiDisponibile = serviciiSortate.ToList();
            checkedListBoxServicii.Items.Clear();
            foreach (var sv in serviciiDisponibile)
            {
                checkedListBoxServicii.Items.Add($"Nume: {sv.Denumire}, Pret: {sv.Pret} lei, Durata: {sv.Durata} minute");
            }
        }
        private void IncarcaIstoric()
        {
            var comenziClient = dbContext.Comenzi
                .Where(c => c.UtilizatorId == utilizatorLogat.UtilizatorId)
                .OrderByDescending(c => c.DataComenzii)
                .ToList();
            dataGridViewIstoric.DataSource = comenziClient;
            if (dataGridViewIstoric.Columns["Utilizator"] != null)
                dataGridViewIstoric.Columns["Utilizator"].Visible = false;
            if (dataGridViewIstoric.Columns["UtilizatorId"] != null)
                dataGridViewIstoric.Columns["UtilizatorId"].Visible = false;
            if (dataGridViewIstoric.Columns["NumeClient"] != null)
                dataGridViewIstoric.Columns["NumeClient"].Visible = false;
        }
        private void IncarcaContulMeu()
        {
            label2.Text = $"Bună ziua, {utilizatorLogat.Nume}!";

            int totalComenzi = dbContext.Comenzi.Count(c => c.UtilizatorId == utilizatorLogat.UtilizatorId);
            decimal totalCheltuit = dbContext.Plati.Where(p => p.Comanda.UtilizatorId == utilizatorLogat.UtilizatorId)
                                                    .Sum(p => (decimal?)p.Suma) ?? 0;

            labelTotalComenzi.Text = totalComenzi.ToString();
            labelTotalCheltuit.Text = $"{totalCheltuit} lei";
        }

        private void buttonPlaseazaComanda_Click(object sender, EventArgs e)
        {
            if (checkedListBoxServicii.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vă rugăm să selectați cel puțin un serviciu.");
                return;
            }
            List<Serviciu> serviciiAlese = new List<Serviciu>();
            for (int i = 0; i < checkedListBoxServicii.Items.Count; i++)
            {
                if (checkedListBoxServicii.GetItemChecked(i))
                {
                    serviciiAlese.Add(serviciiDisponibile[i]);
                }
            }
            Comanda comanda = new Comanda
            {
                UtilizatorId = utilizatorLogat.UtilizatorId,
                DataComenzii = DateTime.Now,
                Status = StatusComanda.InAsteptare,
                ServiciiComandate = serviciiAlese,
                MetodaPlata = (MetodaPlata)comboBoxMetodaPlata.SelectedItem
            };
            dbContext.Comenzi.Add(comanda);
            dbContext.SaveChanges();

            decimal totalDePlata = serviciiAlese.Sum(s => s.Pret);
            Plata plataAutomata = new Plata
            {
                ComandaId = comanda.ComandaId,
                Suma = totalDePlata,
                Metoda = comanda.MetodaPlata,
                DataPlatii = DateTime.Now
            };
            dbContext.Plati.Add(plataAutomata);

            Notificare notificareNoua = new Notificare
            {
                UtilizatorId = utilizatorLogat.UtilizatorId,
                Mesaj = $"Comandă nouă! Clientul {utilizatorLogat.Nume} a plasat comanda #{comanda.ComandaId}.",
                DataNotificarii = DateTime.Now
            };
            dbContext.Notificari.Add(notificareNoua);
            dbContext.SaveChanges();

            MessageBox.Show("Comanda ta a fost plasată cu succes!.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (int i = 0; i < checkedListBoxServicii.Items.Count; i++)
            {
                checkedListBoxServicii.SetItemChecked(i, false);
            }
            if (radioButtonCrescator.Checked)
            {
                radioButtonCrescator.Checked = false;
            }
            if (radioButtonDescrescator.Checked)
            {
                radioButtonDescrescator.Checked = false;
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            panelComandaNoua.BringToFront();

            comboBoxMetodaPlata.DataSource = Enum.GetValues(typeof(MetodaPlata));
            IncarcaServiciiDisponibile();
            IncarcaIstoric();
        }

        private void buttonNvgComandaNoua_Click(object sender, EventArgs e)
        {
            IncarcaServiciiDisponibile();
            panelComandaNoua.BringToFront();
        }

        private void buttonNvgIstoric_Click(object sender, EventArgs e)
        {
            IncarcaIstoric();
            panelIstoric.BringToFront();
        }

        private void buttonNvgCont_Click(object sender, EventArgs e)
        {
            IncarcaContulMeu();
            panelCont.BringToFront();
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

        private void FormClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggedIn)
            {
                Application.Exit();
            }
        }

        private void radioButtonCrescator_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCrescator.Checked)
            {
                SortarePret();
            }
        }

        private void radioButtonDescrescator_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDescrescator.Checked)
            {
                SortarePret();
            }
        }
        private void buttonSalvareParola_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxParolaNoua.Text))
            {
                MessageBox.Show("Introduceți o parolă nouă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var utilizatorReal = dbContext.Utilizatori.FirstOrDefault(u => u.UtilizatorId == utilizatorLogat.UtilizatorId);
            if(utilizatorReal != null)
            {
                utilizatorReal.Parola = textBoxParolaNoua.Text;
                dbContext.SaveChanges();

                utilizatorLogat.Parola = textBoxParolaNoua.Text;
                textBoxParolaNoua.Clear();
                MessageBox.Show("Parola a fost actualizată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
