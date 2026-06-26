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
    public partial class FormModificariServicii : Form
    {
        private Serviciu serviciuCurent = null;
        public Serviciu ServiciuRezultat { get; private set; }
        public FormModificariServicii()
        {
            InitializeComponent();
            this.Text = "Adaugă Serviciu Nou";
            buttonSalvare.Text = "Adaugă";
            buttonSalvare.BackColor = Color.FromArgb(21, 101, 192);
            buttonAnulare.BackColor = Color.FromArgb(194, 40, 40);

        }
        public FormModificariServicii(Serviciu ServiciuEditat)
        {
            InitializeComponent();
            this.Text = "Modifică Serviciu";
            buttonSalvare.Text = "Salvează Modificări";
            serviciuCurent = ServiciuEditat;

            textBoxDenumire.Text = serviciuCurent.Denumire;
            numericUpDownPret.Value = serviciuCurent.Pret;
            numericUpDownDurata.Value = serviciuCurent.Durata;
            buttonSalvare.BackColor = Color.FromArgb(21, 101, 192);
            buttonAnulare.BackColor = Color.FromArgb(194, 40, 40);
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDenumire.Text))
            {
                MessageBox.Show("Denumirea serviciului nu poate fi goală.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            else
            {
                if (serviciuCurent == null)
                {
                    ServiciuRezultat = new Serviciu
                    {
                        Denumire = textBoxDenumire.Text,
                        Pret = numericUpDownPret.Value,
                        Durata = (int)numericUpDownDurata.Value
                    };
                }
                else
                {
                    serviciuCurent.Denumire = textBoxDenumire.Text;
                    serviciuCurent.Pret = numericUpDownPret.Value;
                    serviciuCurent.Durata = (int)numericUpDownDurata.Value;
                    ServiciuRezultat = serviciuCurent;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
