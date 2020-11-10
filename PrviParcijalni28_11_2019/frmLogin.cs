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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            GenerisiBrojIndeksa(txtBrojIndeksa);
            GenerisiMail(txtBrojIndeksa);
        }
        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajPolja())
            {
                Student noviStudent = new Student();
                noviStudent.BrojIndeksa = txtBrojIndeksa.Text;
                noviStudent.Ime = txtIme.Text;
                noviStudent.Prezime = txtPrezime.Text;
                noviStudent.Slika = pbSlikaKorisnika.Image;
                noviStudent.Email = txtEmail.Text;
                noviStudent.Prosjek = Student.ProsjekStudenta();
                InMemoryDB.Studenti.Add(noviStudent);
                MessageBox.Show("Korisnik uspjeno dodan!");
                DialogResult = DialogResult.OK;
                Close();
            }else
                MessageBox.Show("Unesite sva polja predvidjena za registraciju!");
        }
        private bool ValidirajPolja()
        {
            return ProvjeraText(txtIme,err,"Ovo polje je obavezno") && ProvjeraText(txtPrezime,err, "Ovo polje je obavezno") && ProvjeraSlike(pbSlikaKorisnika, err, "Ovo polje je obavezno");
        }
        private bool ProvjeraText(Control polje,ErrorProvider error,string poruka)
        {
            if (string.IsNullOrEmpty(polje.Text) || polje == null)
            { 
                error.SetError(polje, poruka);
                return false;
            }
            else
            {
                err.Clear();
                return true;
            }
        }
        private bool ProvjeraSlike(PictureBox polje,ErrorProvider error,string poruka)
        {
            if(polje.Image==null)
            {
                error.SetError(polje, poruka);
                return false;
            }
            else
            {
                error.Clear();
                return true;
            }
        }
        private void GenerisiBrojIndeksa(TextBox polje)
        {
            InMemoryDB.GenerisiCifre();
            if (!string.IsNullOrEmpty(polje.Text))
                txtBrojIndeksa.Text = polje.Text + InMemoryDB.IndeksGeneratorZadnjaCifra.ToString() + InMemoryDB.IndeksGeneratorSrednjaCifra.ToString() + InMemoryDB.IndeksGeneratorPrvaCifra.ToString();
            else
                MessageBox.Show("Unesite predvidjena polja!");
        }
        private void GenerisiMail(TextBox polje)
        {
            if (!string.IsNullOrEmpty(polje.Text))
                txtEmail.Text = polje.Text + "@edu.fit.ba";
            else
                MessageBox.Show("Unesite predvidjena polja!");
        }
        private void pbSlikaKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                if(ofdSlika.ShowDialog() == DialogResult.OK)
                {
                    string putanjaDoFajla = ofdSlika.FileName;
                    Image slikaKorisnika = Image.FromFile(putanjaDoFajla);
                    pbSlikaKorisnika.Image = slikaKorisnika;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska-> {ex.Message}");;
            }
        }
      
    }
}
