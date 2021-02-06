using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviParcijalniPR3
{
    public partial class frmStudenti : Form
    {
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            InMemoryDB baza = new InMemoryDB();
            dgvStudenti.DataSource = InMemoryDB.Studenti;
            lblPrikazaniStud.Text = "Prikazano je " + InMemoryDB.Studenti.Count + " studenta i njihov prosjek je " + ProsjekSvihStudenata().ToString();
        }

        private double ProsjekSvihStudenata()
        {
            double prosjek = 0;
            if (InMemoryDB.Studenti.Count == 0)
                return prosjek;
            foreach (var student in InMemoryDB.Studenti)
                prosjek += student.Prosjek;
            return prosjek / InMemoryDB.Studenti.Count;
        }
        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            frmLogin loginForma = new frmLogin();
            if(loginForma.ShowDialog() == DialogResult.OK)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = InMemoryDB.Studenti;
                lblPrikazaniStud.Text = "Prikazano je " + InMemoryDB.Studenti.Count + " studenta i njihov prosjek je " + ProsjekSvihStudenata().ToString();
            }
        }
       
        private void txtUnosBrojaIndeksa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnosBrojaIndeksa.Text))
            {
                //ukoliko postoje studenti koji sadrze uneseni tekst u pretragu onda ih spremi u posebnu listu koja ce postati izvor dataGrid-a
                string pretraga = txtUnosBrojaIndeksa.Text;
                var filtriraniStudenti = InMemoryDB.Studenti.Where(student => pretraga.ToUpper().Contains(student.BrojIndeksa)).ToList();
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = filtriraniStudenti;
                return;
            }

            //ukoliko se opet vrati u pocetno stanje gdje je prazan textBox ili korisnik obrise uneseni sadrzaj onda izvod opet postaju trenutni studenti iz baze
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = InMemoryDB.Studenti;
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                if (student != null)
                {
                    frmDetaljniPodaci forma = new frmDetaljniPodaci(student);
                    forma.ShowDialog();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Greska-> {ex.Message}");
            }
        }
    }
}
