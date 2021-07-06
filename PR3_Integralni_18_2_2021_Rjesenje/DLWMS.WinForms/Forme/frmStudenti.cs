using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
        private List<int> Ocjene = new List<int>();
        private List<string> Operatori = new List<string>();

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            UcitajOcjene();
            UcitajOperatore();
        }

        private void UcitajOperatore()
        {
            Operatori.Add(">");
            Operatori.Add(">=");
            Operatori.Add("=");
            Operatori.Add("<");
            Operatori.Add("<=");
            cmbOperatori.DataSource = Operatori;
        }

        private void UcitajOcjene()
        {
            for (int i = 6; i <= 10; i++)
                Ocjene.Add(i);
            cmbOcjene.DataSource = Ocjene;
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
        
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbOperatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(ValidanUnos())
            {
                var ocjena = int.Parse(cmbOcjene.SelectedItem.ToString());
                var datumOD = dtpOD.Value;
                var datumDO = dtpDO.Value;
                var komparacija = cmbOperatori.SelectedItem as string;
                IzvrsiPretragu(ocjena, datumOD, datumDO, komparacija);
            }

        }

        private void IzvrsiPretragu(int ocjena, DateTime datumOD, DateTime datumDO, string komparacija)
        {
            List<Student> studenti = new List<Student>();
            List<StudentiPredmeti> polozeniPredmeti = new List<StudentiPredmeti>();

            //izvrsi se provjera
            if(komparacija==">")
            {
                polozeniPredmeti = _baza.StudentiPredmeti.Where(polozeni => polozeni.Datum > datumOD && polozeni.Datum < datumDO
                                                      && polozeni.Ocjena > ocjena).ToList();
            }else if(komparacija==">=")
            {
                polozeniPredmeti = _baza.StudentiPredmeti.Where(polozeni => polozeni.Datum > datumOD && polozeni.Datum < datumDO
                                                      && polozeni.Ocjena >= ocjena).ToList();
            }else if(komparacija=="=")
            {
                polozeniPredmeti = _baza.StudentiPredmeti.Where(polozeni => polozeni.Datum > datumOD && polozeni.Datum < datumDO
                                                     && polozeni.Ocjena == ocjena).ToList();
            }else if(komparacija=="<")
            {
                polozeniPredmeti = _baza.StudentiPredmeti.Where(polozeni => polozeni.Datum > datumOD && polozeni.Datum < datumDO
                                                    && polozeni.Ocjena < ocjena).ToList();
            }else if(komparacija=="<=")
            {
                polozeniPredmeti = _baza.StudentiPredmeti.Where(polozeni => polozeni.Datum > datumOD && polozeni.Datum < datumDO
                                                    && polozeni.Ocjena <= ocjena).ToList();
            }


            //preuzmu se studenti koji su polozili te predmete
            foreach (var polozeni in polozeniPredmeti)
            {
                var student = _baza.Studenti.Find(polozeni.Student.Id);
                //onemogucimo dupliranje studenata
                if(!studenti.Contains(student))
                    studenti.Add(student);
            }
            UcitajPodatkeOStudentima(studenti);
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(cmbOcjene, err, "Ovo polje je obavezno!") && 
                   Validator.ValidirajKontrolu(cmbOperatori,err,"Ovo polje je obavezno");
        }

        private void cmbOcjene_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var ocjena = int.Parse(cmbOcjene.SelectedItem.ToString());
                var datumOD = dtpOD.Value;
                var datumDO = dtpDO.Value;
                var komparacija = cmbOperatori.SelectedItem as string;
                IzvrsiPretragu(ocjena, datumOD, datumDO, komparacija);
            }
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            frmCovidTest forma = new frmCovidTest();
            forma.ShowDialog();
        }
    }
}
