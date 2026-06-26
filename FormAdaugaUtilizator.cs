using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProiectMSOA.Models;
using ProiectMSOA.Data;

namespace ProiectMSOA
{
    public partial class FormAdaugaUtilizator : Form
    {
        private AppDbContext dbContext = new AppDbContext();
        public FormAdaugaUtilizator()
        {
            InitializeComponent();
            comboBoxRol.DataSource = Enum.GetValues(typeof(Rol));

            this.BackColor = Color.FromArgb(245, 247, 250);
            panel1.BackColor = Color.White;

            textBoxNume.BackColor = Color.FromArgb(240, 244, 248);
            textBoxParola.BackColor = Color.FromArgb(240, 244, 248);
            comboBoxRol.BackColor = Color.FromArgb(240, 244, 248);
            buttonSalvare.BackColor = Color.FromArgb(21, 101, 192);
            buttonSalvare.ForeColor = Color.White;
            buttonAnulare.BackColor = Color.White;
            buttonAnulare.ForeColor = Color.FromArgb(100, 116, 139);

        }
        private bool UtilizatorExistent(string nume, Rol rol)
        {
            foreach(var u in dbContext.Utilizatori)
            {
                if (u.Nume == nume && u.Rol == rol)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            string nume = textBoxNume.Text;
            string parola = textBoxParola.Text;
            Rol rol = (Rol)comboBoxRol.SelectedItem;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile.");
                return;
            }
            if (UtilizatorExistent(nume, rol))
            {
                MessageBox.Show("Acest utilizator există deja în sistem!", "Eroare");
                return;
            }

            Utilizator utilizatorNou = new Utilizator
            {
                Nume = nume,
                Parola = parola,
                Rol = rol
            };

            dbContext.Utilizatori.Add(utilizatorNou);
            dbContext.SaveChanges();

            MessageBox.Show($"Contul pentru {nume} (Rol: {rol}) a fost creat cu succes!");
            this.Close();
        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
