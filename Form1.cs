using ProiectMSOA.Data;
using ProiectMSOA.Models;
namespace ProiectMSOA
{
    public partial class Form1 : Form
    {
        private AppDbContext dbContext = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
            dbContext.Database.EnsureCreated();
            this.BackColor = Color.FromArgb(245, 247, 250);
            textBoxNume.BackColor = Color.FromArgb(240, 244, 248);
            textBoxParola.BackColor = Color.FromArgb(240, 244, 248);
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label4.ForeColor = Color.FromArgb(30, 30, 30);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label6.ForeColor = Color.FromArgb(21, 101, 192);

            buttonAutentificare.BackColor = Color.FromArgb(21, 101, 192);
            buttonAutentificare.ForeColor = Color.White;
            buttonAutentificare.FlatStyle = FlatStyle.Flat;
            buttonAutentificare.FlatAppearance.BorderSize = 0;
            buttonAdaugaCont.BackColor = Color.White;
            buttonAdaugaCont.ForeColor = Color.FromArgb(21, 101, 192);
            buttonAdaugaCont.FlatAppearance.BorderColor = Color.FromArgb(21, 101, 192);
        }
        private bool UtilizatorGasit(string nume, string parola)
        {
            foreach (var u in dbContext.Utilizatori)
            {
                if (u.Nume == nume && u.Parola == parola)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            string nume = textBoxNume.Text;
            string parola = textBoxParola.Text;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile.");
                return;
            }
            else
            {
                if (UtilizatorGasit(nume, parola))
                {
                    MessageBox.Show($"Autentificare reușită! Bine ai venit, {nume}.");
                    var utilizator = dbContext.Utilizatori.FirstOrDefault(u => u.Nume == nume && u.Parola == parola);
                    if (utilizator.Rol == Rol.Admin)
                    {
                        FormDashBoardAdmin formAdmin = new FormDashBoardAdmin(utilizator);
                        formAdmin.Show();
                    }
                    else if (utilizator.Rol == Rol.Angajat)
                    {
                        FormAngajat formAngajat = new FormAngajat();
                        formAngajat.Show();
                    }
                    else if (utilizator.Rol == Rol.Client)
                    {
                        FormClient formClient = new FormClient(utilizator);
                        formClient.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Nume sau parolă incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdaugaCont_Click(object sender, EventArgs e)
        {
            FormAdaugaUtilizator formAdauga = new FormAdaugaUtilizator();
            formAdauga.ShowDialog();
        }
    }
}
