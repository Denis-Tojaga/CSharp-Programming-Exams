using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmCovidTest : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private List<string> Rezultati = new List<string>();
        public frmCovidTest()
        {
            InitializeComponent();
            dgvStudentiCovidTestovi.AutoGenerateColumns = false;
        }

        private void frmCovidTest_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            UcitajRezultate();
            UcitajTestove();
        }

        private void UcitajTestove()
        {
            var testovi = _baza.StudentiCovidTestovi.ToList(); 
            dgvStudentiCovidTestovi.DataSource = null;
            dgvStudentiCovidTestovi.DataSource = testovi;
        }

        private void UcitajRezultate()
        {
            Rezultati.Add("Pozitivan");
            Rezultati.Add("Negativan");
            cmbRezultat.DataSource = Rezultati;
        }

        private void UcitajStudente()
        {
            var studenti = _baza.Studenti.ToList();
            cmbStudenti.DataSource = studenti;
            cmbStudenti.DisplayMember = "Ime";
            cmbStudenti.ValueMember = "Id";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var student = cmbStudenti.SelectedItem as Student;
            var datum = dtpDatumTestiranja.Value.ToString();
            var pomocna = cmbRezultat.SelectedItem as string;
            int rezultat = 0;
            if (pomocna == "Pozitivan")
                rezultat = 1;
            var nalazDostavljen = cbNalazDostavljen.Checked;
            int dostavljen = 0;
            if (nalazDostavljen)
                dostavljen = 1;


            _baza.StudentiCovidTestovi.Add(new StudentiCovidTestovi()
            {
                Datum = datum,
                Rezultat = rezultat,
                NalazDostavljen = dostavljen,
                Student = student
            });

            _baza.SaveChanges();
            MessageBox.Show($"Uspjesno dodan test");
            UcitajTestove();
        }
    }
}
