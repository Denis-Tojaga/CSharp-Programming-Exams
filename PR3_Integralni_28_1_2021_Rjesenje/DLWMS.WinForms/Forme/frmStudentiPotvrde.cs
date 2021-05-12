using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudentiPotvrde : Form
    {
        private KonekcijaNaBazu baza = DLWMSdb.Baza;
        public frmStudentiPotvrde()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
                AsinhronoGenerisanje();
        }
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da zelite obrisati sve potvrde", "Pitanje za korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                AsinhronoBrisanje();
        }
        private void btnUpisiUFajl_Click(object sender, EventArgs e)
        {
            AsinhronoUpisivanjeUFajl();
        }



        //async methods
        private async void AsinhronoGenerisanje()
        {
            int brojPotvrda = int.Parse(txtBrojPotvrda.Text);
            await Task.Run(() =>
            {

                var student = baza.Studenti.Find(1);
                for (int i = 0; i < brojPotvrda; i++)
                {
                    StudentiPotvrde novaPotvrda = new StudentiPotvrde();
                    novaPotvrda.DatumSlanja = DateTime.Now.ToShortDateString();
                    novaPotvrda.Student = student;
                    novaPotvrda.Svrha = "Ovo je nova generisana potvrda!";
                    novaPotvrda.Izdata = false;
                    baza.StudentiPotvrde.Add(novaPotvrda);
                }
            });

            baza.SaveChanges();
            MessageBox.Show($"Uspjesno generisano {brojPotvrda} potvrda");
            UcitajPotvrde();
        }
        private async void AsinhronoBrisanje()
        {
            await Task.Run(() =>
            {

                List<int> ListaIDeva = new List<int>();
                foreach (var potvrda in baza.StudentiPotvrde)
                    ListaIDeva.Add(potvrda.Id);

                foreach (var id in ListaIDeva)
                {
                    var potvrda = baza.StudentiPotvrde.Find(id);
                    baza.StudentiPotvrde.Remove(potvrda);
                }
            });

            baza.SaveChanges();
            MessageBox.Show($"Sve potvrde uspjesno obrisane!");
            UcitajPotvrde();
        }
        private async void AsinhronoUpisivanjeUFajl()
        {
            await Task.Run(() =>
            {
                using (StreamWriter sw = new StreamWriter("../../potvrde.csv", false))
                {
                    sw.WriteLine("Id Potvrde;Student;Datum slanja;Svrha;Izdata;");
                    foreach (var potvrda in dgvPotvrde.DataSource as List<StudentiPotvrde>)
                        sw.WriteLine(potvrda.Id + ";" + potvrda.Student.ToString() + ";" + potvrda.DatumSlanja + ";" + potvrda.Svrha + ";" + potvrda.Izdata);
                }
            });
            MessageBox.Show($"Uspjesno upisano u file!");
        }


        //Input validation
        private void UcitajPotvrde()
        {
            dgvPotvrde.DataSource = null;
            dgvPotvrde.DataSource = baza.StudentiPotvrde.ToList();
            lblBrojPotvrda.Text = baza.Studenti.Count().ToString();
        }
        private bool ValidanUnos() => Validator.ValidirajKontrolu(txtBrojPotvrda, err, "Input nije dobar!") && ValidanBroj();
        private bool ValidanBroj()
        {
            long broj;
            if (long.TryParse(txtBrojPotvrda.Text, out broj))
                return true;
            else
            {
                err.SetError(txtBrojPotvrda, "Niste unijeli broj!");
                return false;
            }
        }



        private void frmStudentiPotvrde_Load(object sender, EventArgs e)
        {
            UcitajPotvrde();
        }
    }
}
