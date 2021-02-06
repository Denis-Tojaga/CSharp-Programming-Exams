using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private dtoTransfer objekat;
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(dtoTransfer transfer) : this()
        {
            objekat = transfer;
        }
     
        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {
            var rpc = new ReportParameterCollection();

            dsStudenti.tblStudentiDataTable tbl = new dsStudenti.tblStudentiDataTable();
            foreach (var student in objekat.ListaStudenata)
            {
                dsStudenti.tblStudentiRow noviRed = tbl.NewtblStudentiRow();
                noviRed.RB = student.Id;
                noviRed.Indeks = student.Indeks;
                noviRed.Ime = student.Ime;
                noviRed.Prezime = student.Prezime;
                noviRed.Spol = student.Spol.ToString();
                noviRed.GodinaStudija = student.GodinaStudija;
                if (student.Aktivan)
                    noviRed.Aktivan = "DA";
                else
                    noviRed.Aktivan = "NE";
                tbl.Rows.Add(noviRed);
            }


            var rds = new ReportDataSource();
            rds.Name = "dsIzvorNeki";
            rds.Value = tbl;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
