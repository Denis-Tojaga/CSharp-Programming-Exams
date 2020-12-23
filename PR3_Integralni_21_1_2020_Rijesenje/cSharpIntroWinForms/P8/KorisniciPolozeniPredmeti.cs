using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;
        private const string Warning = "This field is required!";
        private List<int> ListaOcjena = new List<int>();

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        async void IzvrsavanjeASYNCMetode(Korisnik korisnik,Predmeti odabrani)
        {
            await Task.Run(() =>
            {
                Dodaj500Predmeta(korisnik, odabrani);
            });
            MessageBox.Show($"Uspjesno dodano 500 predmeta!");
        }

        private void Dodaj500Predmeta(Korisnik korisnik,Predmeti odabrani)
        {
            for (int i = 1; i <=500; i++)
                korisnik.Uspjeh.Add(new KorisniciPredmeti()
                {
                    Predmet = odabrani,
                    Datum = DateTime.Now.ToShortDateString(),
                    Ocjena = 6
                });
        }

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajOcjene();
            UcitajPredmete();
            UcitajPolozene();
        }

        private void UcitajOcjene()
        {
            for (int i = 6; i < 11; i++)
                ListaOcjena.Add(i);
            cmbOcjene.DataSource = ListaOcjena;
        }

        private void UcitajPolozene()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = korisnik.Uspjeh;
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                korisnik.Uspjeh.Add(new KorisniciPredmeti()
                {
                    Predmet = cmbPredmeti.SelectedItem as Predmeti,
                    Ocjena = int.Parse(cmbOcjene.SelectedItem.ToString()),
                    Datum = dtpDatumPolaganja.Value.ToShortDateString()
                });
                konekcijaNaBazu.SaveChanges();
                MessageBox.Show($"Predmet {cmbPredmeti.SelectedItem as Predmeti} uspješno dodan -> {korisnik}u!");
                UcitajPolozene();
            }
        }

        private bool ValidirajUnos()=> Validator.ValidirajPolje(cmbOcjene, err, Warning) && Validator.ValidirajPolje(cmbPredmeti, err, Warning);

        private void cbUcitajNepolozene_CheckedChanged(object sender, EventArgs e)
        {
            if(cbUcitajNepolozene.Checked)
                UcitajNepolozeneUCMB();
            else
                UcitajPredmete();
        }

        private void UcitajNepolozeneUCMB()
        {
            //uzmi iz predmeta u tabeli predmeti kao enumerable,  gdje (u polozenomPredmetu u korisnikovom uspjehu njegov Id ne sadrzi Id predmeta iz tabele Predmeti,uzmi sve te predmete
            var query = from predmeti in konekcijaNaBazu.Predmeti.AsEnumerable()
                        where !(from polozeni in korisnik.Uspjeh select polozeni.Predmet.Id).Contains(predmeti.Id)
                        select predmeti;
            cmbPredmeti.DataSource = query.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            dtoKorisnikIzvjestaj objekat = new dtoKorisnikIzvjestaj();
            objekat.Ime = korisnik.Ime;
            objekat.Prezime = korisnik.Prezime;
            var nepolozeni = from predmeti in konekcijaNaBazu.Predmeti.AsEnumerable()
                                 where !(from polozeni in korisnik.Uspjeh select polozeni.Predmet.Id).Contains(predmeti.Id)
                                 select predmeti;
            objekat.Nepolozeni = nepolozeni.ToList();
            objekat.Polozeni = korisnik.Uspjeh;
            frmIzvjestaj izvjestaj = new frmIzvjestaj(objekat);
            izvjestaj.ShowDialog();
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            var postoji = korisnik.Uspjeh.Where(x => x.Predmet.Id == (cmbPredmeti.SelectedItem as Predmeti).Id).Count() > 0;
            //ako predmet postoji bit ce disabled ako nepostoji bit ce enabled, uvijek stavlja suprotno
            btnDodajPolozeni.Enabled = !postoji;
        }

        private void btnASYNC_Click(object sender, EventArgs e)
        {
            var odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
            IzvrsavanjeASYNCMetode(korisnik,odabraniPredmet);
        }
    }

    public class dtoKorisnikIzvjestaj
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<Predmeti> Nepolozeni { get; set; }
        public List<KorisniciPredmeti> Polozeni { get; set; }
    }
}
