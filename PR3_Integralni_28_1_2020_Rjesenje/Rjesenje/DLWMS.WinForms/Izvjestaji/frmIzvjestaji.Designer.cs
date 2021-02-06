
namespace DLWMS.WinForms.Izvjestaji
{
    partial class frmIzvjestaji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PorukeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsStudenti = new DLWMS.WinForms.Izvjestaji.dsStudenti();
            this.tblStudentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PorukeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsIzvor";
            reportDataSource1.Value = this.tblStudentiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.Izvjestaji.rptIzvjestajStudenata.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(724, 632);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsStudenti
            // 
            this.dsStudenti.DataSetName = "dsStudenti";
            this.dsStudenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentiBindingSource
            // 
            this.tblStudentiBindingSource.DataMember = "tblStudenti";
            this.tblStudentiBindingSource.DataSource = this.dsStudenti;
            // 
            // frmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 632);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvjestaji";
            this.Text = "frmIzvjestaji";
            this.Load += new System.EventHandler(this.frmIzvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PorukeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PorukeBindingSource;
        private System.Windows.Forms.BindingSource tblStudentiBindingSource;
        private dsStudenti dsStudenti;
    }
}