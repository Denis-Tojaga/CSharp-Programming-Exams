using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private List<string> ListaGodina = new List<string>();
        private List<string> ListaAktivnosti = new List<string>();

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            UcitajListeGodina();
            UcitajAktivnost();
        }


        /// <summary>
        /// Ucitavanje godina i aktivnosti u cmb
        /// </summary>
        private void UcitajAktivnost()
        {
            ListaAktivnosti.Add("Svi");
            ListaAktivnosti.Add("Aktivni");
            ListaAktivnosti.Add("Neaktivni");
            cmbAktivnost.DataSource = ListaAktivnosti;
        }
        private void UcitajListeGodina()
        {
            ListaGodina.Add("Sve");
            ListaGodina.Add("1");
            ListaGodina.Add("2");
            ListaGodina.Add("3");
            cmbGodineStudija.DataSource = ListaGodina;
        }




        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();
            if(studenti!=null)
            {
                lblBrojStudenata.Text = studenti.Count().ToString();
                lblProsjekOcjena.Text = PostaviProsjek(studenti);
            }else
            {
                lblBrojStudenata.Text = _baza.Studenti.Count().ToString();
                lblProsjekOcjena.Text = PostaviProsjek(_baza.Studenti.ToList());
            }
        }

        private string PostaviProsjek(List<Student> studenti)
        {
            float prosjek = 0;
            if (studenti.Count() == 0)
                return "0,00";
            else
                foreach (var student in studenti)
                    prosjek += student.ProsjekStudenta();

            return Math.Round((prosjek / studenti.Count()),2).ToString();
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6)
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }


        //profesorov kod
        //private bool PretragaStudenata(Student s)
        //{
        //    return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
        //            || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        //}

        private bool ValidanUnos() => Validator.ValidirajKontrolu(txtPretraga, err, "This field is required!");


        //Pretrage
        private void PokreniPretragu(string filter1, string filter2, string filter3)
        {
            List<Student> rezultat = new List<Student>();
            if(filter2 == "Sve" && filter3=="Svi")
                rezultat = _baza.Studenti.Where(x => x.Ime.ToLower().Contains(filter1) || x.Prezime.ToLower().Contains(filter1)).ToList();
            else if(filter2 !="Sve" && filter3=="Svi")
            {
                int brojGodine = int.Parse(filter2);
                rezultat = _baza.Studenti.Where(x => x.Ime.ToLower().Contains(filter1) || x.Prezime.ToLower().Contains(filter1) && x.GodinaStudija==brojGodine).ToList();
            }else if(filter2 == "Sve" && filter3!="Svi")
            {
                bool aktivnost = false;
                if (filter3 == "Aktivni")
                    aktivnost = true;
                rezultat = _baza.Studenti.Where(x => x.Ime.ToLower().Contains(filter1) || x.Prezime.ToLower().Contains(filter1) && x.Aktivan == aktivnost).ToList();
            }else if(filter2!="Sve" && filter3!="Svi")
            {
                int brojGodine = int.Parse(filter2);
                bool aktivnost = false;
                if (filter3 == "Aktivni")
                    aktivnost = true;
                rezultat = _baza.Studenti.Where(x => (x.Ime.ToLower().Contains(filter1) || x.Prezime.ToLower().Contains(filter1)) && x.GodinaStudija== brojGodine && x.Aktivan == aktivnost).ToList();
            }


            UcitajPodatkeOStudentima(rezultat);
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            //profesorov kod
            //var filter = txtPretraga.Text.ToLower();
            //UcitajPodatkeOStudentima(_baza.Studenti
            //  .Where(s => s.Ime.ToLower().Contains(filter)
            //      || s.Prezime.ToLower().Contains(filter)).ToList());

            if (ValidanUnos())
            {
                var filter1 = txtPretraga.Text.ToLower();
                var filter2 = cmbGodineStudija.SelectedItem.ToString();
                var filter3 = cmbAktivnost.SelectedItem.ToString();
                PokreniPretragu(filter1, filter2, filter3);
            }
        }
        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var filter1 = txtPretraga.Text.ToLower();
                var filter2 = cmbGodineStudija.SelectedItem.ToString();
                var filter3 = cmbAktivnost.SelectedItem.ToString();
                PokreniPretragu(filter1, filter2, filter3);
            }
        }
        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var filter1 = txtPretraga.Text.ToLower();
                var filter2 = cmbGodineStudija.SelectedItem.ToString();
                var filter3 = cmbAktivnost.SelectedItem.ToString();
                PokreniPretragu(filter1, filter2, filter3);
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            dtoTransfer objekat = new dtoTransfer();
            objekat.ListaStudenata = dgvStudenti.DataSource as List<Student>;
            frmIzvjestaji izvjestaj = new frmIzvjestaji(objekat);
            izvjestaj.Show();
        }

        private void btnOtvoriPotvrde_Click(object sender, EventArgs e)
        {
            frmStudentiPotvrde forma = new frmStudentiPotvrde();
            forma.ShowDialog();
        }
    }
}
