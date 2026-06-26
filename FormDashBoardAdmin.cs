using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProiectMSOA.Data;
using ProiectMSOA.Models;

namespace ProiectMSOA
{
    public partial class FormDashBoardAdmin : Form
    {
        private bool loggedIn = false;
        private AppDbContext dbContext = new AppDbContext();
        private SetareSistem setariCurente;
        private Utilizator utilizatorLogat;
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
        public FormDashBoardAdmin(Utilizator admin)
        {
            InitializeComponent();
            utilizatorLogat = admin;

            panelMeniu.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgUtilizatori.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgSetari.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgServicii.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgRapoarte.BackColor = Color.FromArgb(21, 101, 192);
            buttonNvgDelogare.BackColor = Color.FromArgb(13, 71, 161);
            buttonAdaugaServiciu.BackColor = Color.FromArgb(21, 101, 192);
            buttonModificaServiciu.BackColor = Color.FromArgb(21, 101, 192);
            buttonRapoarte.BackColor = Color.FromArgb(21, 101, 192);
            buttonSalvare.BackColor = Color.FromArgb(21, 101, 192);
            buttonSetari.BackColor = Color.FromArgb(21,101, 192);
            buttonSterge.BackColor = Color.FromArgb(194, 40, 40);
            buttonStergeServiciu.BackColor = Color.FromArgb(194, 40, 40);
            textBoxNume.BackColor = Color.FromArgb(240, 244, 248);
            textBoxAdresa.BackColor = Color.FromArgb(240, 244, 248);
            textBoxTelefon.BackColor = Color.FromArgb(240, 244, 248);

            StyleGrid(dataGridViewUtilizatori);
            StyleGrid(dataGridViewServicii);
            StyleGrid(dataGridViewRapoarte);
        }
        private void IncarcaServicii()
        {
            var listaServicii = dbContext.Servicii.ToList();
            dataGridViewServicii.DataSource = listaServicii;

            if (dataGridViewServicii.Columns["ServiciuId"] != null)
            {
                dataGridViewServicii.Columns["ServiciuId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewServicii.Columns["ServiciuId"].Width = 60;
            }           
            if (dataGridViewServicii.Columns["Denumire"] != null)
            {
                dataGridViewServicii.Columns["Denumire"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void IncarcaRapoarte()
        {
            var listaRapoarte = dbContext.Rapoarte.ToList();
            dataGridViewRapoarte.DataSource = listaRapoarte;
            if (dataGridViewRapoarte.Columns["RaportId"] != null)
            {
                dataGridViewRapoarte.Columns["RaportId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewRapoarte.Columns["RaportId"].Width = 60;
            }
            if (dataGridViewRapoarte.Columns["DataGenerarii"] != null)
            {
                dataGridViewRapoarte.Columns["DataGenerarii"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dataGridViewRapoarte.Columns["Descriere"] != null)
            {
                dataGridViewRapoarte.Columns["Descriere"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void IncarcaUtilizatori()
        {
            var listaUtilizatori = dbContext.Utilizatori.ToList();
            comboBoxRol.DataSource = Enum.GetValues(typeof(Rol));
            dataGridViewUtilizatori.DataSource = listaUtilizatori;
            dataGridViewUtilizatori.Columns["Parola"].Visible = false;
        }
        private void IncarcaSetariSistem()
        {
            setariCurente = dbContext.SetariSistem.FirstOrDefault();
            if (setariCurente != null)
            {
                textBoxNume.Text = setariCurente.Nume;
                textBoxAdresa.Text = setariCurente.Adresa;
                textBoxTelefon.Text = setariCurente.NumarTelefon;
                textBoxProgramSaptamana.Text = setariCurente.ProgramSaptamana;
                textBoxProgramWeekend.Text = setariCurente.ProgramWeekend;
            }
        }

        private void FormDashBoardAdmin_Load(object sender, EventArgs e)
        {
            panelUtilizatori.BringToFront();

            comboBoxFiltruRol.Items.Clear();
            comboBoxFiltruRol.Items.Add("Toate");
            foreach (var rol in Enum.GetValues(typeof(Rol)))
            {
                comboBoxFiltruRol.Items.Add(rol);
            }
            comboBoxFiltruRol.SelectedIndex = 0;

            IncarcaUtilizatori();
            IncarcaSetariSistem();
            IncarcaServicii();
            IncarcaRapoarte();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewUtilizatori.CurrentRow != null)
            {
                var utilizatorSelectat = (Utilizator)dataGridViewUtilizatori.CurrentRow.DataBoundItem;

                if(utilizatorSelectat.UtilizatorId == utilizatorLogat.UtilizatorId)
                {
                    MessageBox.Show("Nu puteti sterge utilizatorul logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultat = MessageBox.Show("Sunteti sigur ca doriti sa stergeti acest utilizator?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultat == DialogResult.Yes)
                {
                    dbContext.Utilizatori.Remove(utilizatorSelectat);
                    dbContext.SaveChanges();
                    IncarcaUtilizatori();
                }
            }
            else
            {
                MessageBox.Show("Selectati un utilizator pentru a-l sterge.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUtilizatori_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUtilizatori.CurrentRow != null)
            {
                var utilizatorSelectat = (Utilizator)dataGridViewUtilizatori.CurrentRow.DataBoundItem;
                comboBoxRol.SelectedItem = utilizatorSelectat.Rol;
            }
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if (dataGridViewUtilizatori.CurrentRow != null)
            {
                var utilizatorSelectat = (Utilizator)dataGridViewUtilizatori.CurrentRow.DataBoundItem;
                utilizatorSelectat.Rol = (Rol)comboBoxRol.SelectedItem;
                dbContext.SaveChanges();
                IncarcaUtilizatori();
            }
        }

        private void buttonSetari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNume.Text) || string.IsNullOrEmpty(textBoxAdresa.Text) || string.IsNullOrEmpty(textBoxTelefon.Text))
            {
                MessageBox.Show("Campurile nu pot fi goale!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (string.IsNullOrEmpty(textBoxNume.Text))
                {
                    errorProviderSetare.SetError(textBoxNume, "Campul Nume nu poate fi gol.");
                }
                if (string.IsNullOrEmpty(textBoxAdresa.Text))
                {
                    errorProviderSetare.SetError(textBoxAdresa, "Campul Adresa nu poate fi gol.");
                }
                if (string.IsNullOrEmpty(textBoxTelefon.Text))
                {
                    errorProviderSetare.SetError(textBoxTelefon, "Campul Telefon nu poate fi gol.");
                }
            }
            else
            {
                if (setariCurente == null)
                {
                    setariCurente = new SetareSistem
                    {
                        Nume = textBoxNume.Text,
                        Adresa = textBoxAdresa.Text,
                        NumarTelefon = textBoxTelefon.Text,
                        ProgramSaptamana = textBoxProgramSaptamana.Text,
                        ProgramWeekend = textBoxProgramWeekend.Text
                    };
                    dbContext.SetariSistem.Add(setariCurente);
                    dbContext.SaveChanges();
                    errorProviderSetare.Clear();
                    IncarcaSetariSistem();
                    MessageBox.Show("Setarile au fost adaugate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setariCurente.Nume = textBoxNume.Text.ToString();
                    setariCurente.Adresa = textBoxAdresa.Text.ToString();
                    setariCurente.NumarTelefon = textBoxTelefon.Text.ToString();
                    setariCurente.ProgramSaptamana = textBoxProgramSaptamana.Text;
                    setariCurente.ProgramWeekend = textBoxProgramWeekend.Text;

                    errorProviderSetare.Clear();
                    dbContext.SaveChanges();
                    IncarcaSetariSistem();
                    MessageBox.Show("Setarile au fost actualizate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void buttonNvgUtilizatori_Click(object sender, EventArgs e)
        {
            IncarcaUtilizatori();
            panelUtilizatori.BringToFront();
        }

        private void buttonNvgSetari_Click(object sender, EventArgs e)
        {
            IncarcaSetariSistem();
            panelSetari.BringToFront();
        }

        private void buttonNvgServicii_Click(object sender, EventArgs e)
        {
            IncarcaServicii();
            panelServicii.BringToFront();
        }

        private void buttonNvgRapoarte_Click(object sender, EventArgs e)
        {
            IncarcaRapoarte();
            panelRapoarte.BringToFront();
        }

        private void buttonAdaugaServiciu_Click(object sender, EventArgs e)
        {
            FormModificariServicii formAdaugare = new FormModificariServicii();
            if (formAdaugare.ShowDialog() == DialogResult.OK)
            {
                dbContext.Servicii.Add(formAdaugare.ServiciuRezultat);
                dbContext.SaveChanges();

                MessageBox.Show("Serviciul a fost adăugat cu succes!");
                IncarcaServicii();
            }
        }

        private void buttonModificaServiciu_Click(object sender, EventArgs e)
        {
            if (dataGridViewServicii.CurrentRow != null)
            {
                var serviciuSelectat = (Serviciu)dataGridViewServicii.CurrentRow.DataBoundItem;
                FormModificariServicii formModificare = new FormModificariServicii(serviciuSelectat);
                if (formModificare.ShowDialog() == DialogResult.OK)
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Serviciul a fost modificat cu succes!");
                    IncarcaServicii();
                }
            }
            else
            {
                MessageBox.Show("Selectați un serviciu pentru a-l modifica.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStergeServiciu_Click(object sender, EventArgs e)
        {
            if (dataGridViewServicii.CurrentRow != null)
            {
                var serviciuSelectat = (Serviciu)dataGridViewServicii.CurrentRow.DataBoundItem;
                DialogResult resultat = MessageBox.Show("Sunteti sigur ca doriti sa stergeti acest serviciu?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultat == DialogResult.Yes)
                {
                    dbContext.Servicii.Remove(serviciuSelectat);
                    dbContext.SaveChanges();
                    IncarcaServicii();
                }
            }
            else
            {
                MessageBox.Show("Selectati un serviciu pentru a-l sterge.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDashBoardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loggedIn)
            {
                Application.Exit();
            }
        }

        private void buttonRapoarte_Click(object sender, EventArgs e)
        {
            decimal totalIncasat = dbContext.Plati.Any() ? dbContext.Plati.Sum(s => s.Suma) : 0;
            int numarComenzi = dbContext.Comenzi.Count();
            var serviciuPreferat = dbContext.Comenzi
                .SelectMany(c => c.ServiciiComandate)
                .GroupBy(s => s.Denumire)
                .OrderByDescending(grup => grup.Count())
                .Select(grup => grup.Key)
                .FirstOrDefault();

            Raport raportIncasari = new Raport
            {
                Descriere = $"Financiar: Total încasări cumulate -> {totalIncasat} lei.",
                DataGenerarii = DateTime.Now
            };
            dbContext.Rapoarte.Add(raportIncasari);

            Raport raportComenzi = new Raport
            {
                Descriere = $"Sistem: Au fost procesate un număr total de {numarComenzi} comenzi.",
                DataGenerarii = DateTime.Now
            };
            dbContext.Rapoarte.Add(raportComenzi);

            if (serviciuPreferat != null)
            {
                Raport raportServicii = new Raport
                {
                    Descriere = $"Statistici: Cel mai căutat serviciu la momentul actual este '{serviciuPreferat}'.",
                    DataGenerarii = DateTime.Now
                };
                dbContext.Rapoarte.Add(raportServicii);
            }
            else
            {
                Raport raportServicii = new Raport
                {
                    Descriere = $"Statistici: Nu există servicii comandate în acest moment.",
                    DataGenerarii = DateTime.Now
                };
                dbContext.Rapoarte.Add(raportServicii);
            }
            dbContext.SaveChanges();
            IncarcaRapoarte();
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
        private void FiltrareRol()
        {
            if (comboBoxFiltruRol.SelectedIndex > 0)
            {
                Rol rolSelectat = (Rol)comboBoxFiltruRol.SelectedItem;
                var utilizatoriFiltrati = dbContext.Utilizatori.Where(u => u.Rol == rolSelectat).ToList();
                dataGridViewUtilizatori.DataSource = utilizatoriFiltrati;
            }
            else
            {
                IncarcaUtilizatori();
            }
        }
        private void comboBoxFiltruRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrareRol();
        }
    }
}
