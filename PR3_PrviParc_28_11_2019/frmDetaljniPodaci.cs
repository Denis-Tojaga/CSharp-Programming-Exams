using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviParcijalniPR3
{
    public partial class frmDetaljniPodaci : Form
    {
        public Student studentForme;
        public frmDetaljniPodaci()
        {
            InitializeComponent();
        }
        public frmDetaljniPodaci(Student student) : this()
        {
            studentForme = student;
            dgvPredmeti.AutoGenerateColumns = false;
        }
        private void frmDetaljniPodaci_Load(object sender, EventArgs e)
        {
            txtBrojIndeksa.Text = studentForme.BrojIndeksa;
            txtIme.Text = studentForme.Ime;
            txtPrezime.Text = studentForme.Email;
            pbSlikaKorisnika.Image = studentForme.Slika;
            dgvPredmeti.DataSource = Student.Predmeti;
        }
    }
}
