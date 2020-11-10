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
            List<Student> filtrirani = new List<Student>();
            foreach (var student in InMemoryDB.Studenti)
                if(txtUnosBrojaIndeksa.Text.Contains(student.BrojIndeksa))
                    filtrirani.Add(student);
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = filtrirani;
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
