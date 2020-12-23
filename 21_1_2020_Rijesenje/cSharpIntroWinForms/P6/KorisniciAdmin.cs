using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;
                lblProsjek.Text = IzracunajProsjek(rezultati).ToString();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private float IzracunajProsjek(List<Korisnik> listaKorisnika)
        {
            float prosjek = 0;
            if (listaKorisnika.Count() == 0)
                return prosjek;
            foreach (var korisnik in listaKorisnika)
                prosjek += korisnik.ProsjekKorisnika();
            return prosjek / listaKorisnika.Count();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            LoadData(konekcijaNaBazu.Korisnici.Where(x => x.Ime.ToLower().Contains(txtPretraga.Text.ToLower()) || x.Prezime.ToLower().Contains(txtPretraga.Text.ToLower())).ToList());
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            var grid = (DataGridView)sender;
            Form forma = null;
            if(korisnik!=null)
            {
                if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    forma = new KorisniciPolozeniPredmeti(korisnik);
                    forma.ShowDialog();
                }
            }
        }
    }
}
