using cSharpIntroWinForms.Izvjestaj;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using cSharpIntroWinForms.P9;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestaj : Form
    {
        private KonekcijaNaBazu baza = DLWMS.DB;
        private dtoKorisnikIzvjestaj objekat;

        public frmIzvjestaj()
        {
            InitializeComponent();
            objekat = new dtoKorisnikIzvjestaj();
        }


        public frmIzvjestaj(dtoKorisnikIzvjestaj objekat) : this()
        {
            this.objekat = objekat;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            //odmah ukljuciti namespace microsoft.reporting.services
            //OBAVEZNO NA DIZAJNU REPORTVIEWERA STAVITI SOURCE DA JE IZVJESTAJ NAPRAVLJENI
            try
            {
                //dodamo parametre u kolekciju
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("Ime", objekat.Ime));
                rpc.Add(new ReportParameter("Prezime", objekat.Prezime));

                //SetParameters(kolekcijaParametara) da dodamo sve napravljene parametre u rptviewer



                //pravimo tabelu tipa dataSet
                dsPredmeti.tblPolozeniPredmetiDataTable tbl = new dsPredmeti.tblPolozeniPredmetiDataTable();

                //var predmetiIzBaze = baza.Predmeti.ToList();

                foreach (var predmet in objekat.Polozeni)
                {
                    //pravimo novi red tbl.NewtblPolozeniPredmetiRow();
                    dsPredmeti.tblPolozeniPredmetiRow noviRed = tbl.NewtblPolozeniPredmetiRow();
                    noviRed.Rb = predmet.Id;
                    noviRed.Ocjena = predmet.Ocjena.ToString();
                    noviRed.Predmet = predmet.Predmet.Naziv;
                    noviRed.Datum = predmet.Datum;
                    //OBAVEZNO DODATI NAPRAVLJENI RED U TABELU
                    tbl.Rows.Add(noviRed);
                }

                foreach (var nepolozeni in objekat.Nepolozeni)
                {
                    dsPredmeti.tblPolozeniPredmetiRow noviRed = tbl.NewtblPolozeniPredmetiRow();
                    noviRed.Rb = nepolozeni.Id;
                    noviRed.Ocjena = "NIJE POLOZENO";
                    noviRed.Predmet = nepolozeni.Naziv;
                    noviRed.Datum = "NIJE POLOZENO";
                    tbl.Rows.Add(noviRed);
                }


                //Pravimo source odakle ce report uzimati podatke, imenujemo ga kao u reportu sto je nazvan DataSet
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSetPredmeta";
                rds.Value = tbl;




                rpViewer.LocalReport.SetParameters(rpc);
                //u reportViewer dodajemo DataSource koji smo napravili iznad a u njega smo spremili vrijednosti
                rpViewer.LocalReport.DataSources.Add(rds);

                this.rpViewer.RefreshReport();
                //Redoslijed
                //-Napraviti kolekciju parametara i u nju dodati napravljene parametre
                //-Napraviti tabelu tipa dataset (data source u reportu)
                //-U tu tabelu dodati redove napravljene sa podacima
                //-Napraviti reportDataSource i imenovati ga kao DataSet u reportu
                //-Dodati kolekiju parametara i data source u report viewer 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }
    }
}
