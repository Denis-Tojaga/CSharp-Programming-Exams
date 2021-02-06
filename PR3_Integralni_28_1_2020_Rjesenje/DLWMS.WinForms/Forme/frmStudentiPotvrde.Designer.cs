namespace DLWMS.WinForms.Forme
{
    partial class frmStudentiPotvrde
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
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnUpisiUFajl = new System.Windows.Forms.Button();
            this.txtBrojPotvrda = new System.Windows.Forms.TextBox();
            this.dgvPotvrde = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojPotvrda = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumSlanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGenerisi.Location = new System.Drawing.Point(150, 22);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(128, 30);
            this.btnGenerisi.TabIndex = 10;
            this.btnGenerisi.Text = "Generisi potvrde";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBrisi.Location = new System.Drawing.Point(331, 22);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(131, 30);
            this.btnBrisi.TabIndex = 11;
            this.btnBrisi.Text = "Obrisi sve ";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnUpisiUFajl
            // 
            this.btnUpisiUFajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUpisiUFajl.Location = new System.Drawing.Point(545, 22);
            this.btnUpisiUFajl.Name = "btnUpisiUFajl";
            this.btnUpisiUFajl.Size = new System.Drawing.Size(134, 30);
            this.btnUpisiUFajl.TabIndex = 12;
            this.btnUpisiUFajl.Text = "Upisi u fajl";
            this.btnUpisiUFajl.UseVisualStyleBackColor = true;
            this.btnUpisiUFajl.Click += new System.EventHandler(this.btnUpisiUFajl_Click);
            // 
            // txtBrojPotvrda
            // 
            this.txtBrojPotvrda.Location = new System.Drawing.Point(12, 29);
            this.txtBrojPotvrda.Name = "txtBrojPotvrda";
            this.txtBrojPotvrda.Size = new System.Drawing.Size(122, 20);
            this.txtBrojPotvrda.TabIndex = 13;
            // 
            // dgvPotvrde
            // 
            this.dgvPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.DatumSlanja,
            this.Svrha,
            this.Izdata});
            this.dgvPotvrde.Location = new System.Drawing.Point(12, 58);
            this.dgvPotvrde.Name = "dgvPotvrde";
            this.dgvPotvrde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotvrde.Size = new System.Drawing.Size(667, 284);
            this.dgvPotvrde.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Broj potvrda:";
            // 
            // lblBrojPotvrda
            // 
            this.lblBrojPotvrda.AutoSize = true;
            this.lblBrojPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPotvrda.Location = new System.Drawing.Point(110, 345);
            this.lblBrojPotvrda.Name = "lblBrojPotvrda";
            this.lblBrojPotvrda.Size = new System.Drawing.Size(0, 18);
            this.lblBrojPotvrda.TabIndex = 16;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // DatumSlanja
            // 
            this.DatumSlanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumSlanja.DataPropertyName = "DatumSlanja";
            this.DatumSlanja.HeaderText = "Datum slanja";
            this.DatumSlanja.Name = "DatumSlanja";
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            // 
            // Izdata
            // 
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.Name = "Izdata";
            // 
            // frmStudentiPotvrde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 379);
            this.Controls.Add(this.lblBrojPotvrda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPotvrde);
            this.Controls.Add(this.txtBrojPotvrda);
            this.Controls.Add(this.btnUpisiUFajl);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Name = "frmStudentiPotvrde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentiPotvrde";
            this.Load += new System.EventHandler(this.frmStudentiPotvrde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnUpisiUFajl;
        private System.Windows.Forms.TextBox txtBrojPotvrda;
        private System.Windows.Forms.DataGridView dgvPotvrde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPotvrda;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSlanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}