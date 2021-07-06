namespace DLWMS.WinForms.Forme
{
    partial class frmCovidTest
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRezultat = new System.Windows.Forms.ComboBox();
            this.dtpDatumTestiranja = new System.Windows.Forms.DateTimePicker();
            this.cbNalazDostavljen = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.dgvStudentiCovidTestovi = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nalazdostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiCovidTestovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rezultat testa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Datum testiranja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student";
            // 
            // cmbRezultat
            // 
            this.cmbRezultat.FormattingEnabled = true;
            this.cmbRezultat.Location = new System.Drawing.Point(335, 34);
            this.cmbRezultat.Name = "cmbRezultat";
            this.cmbRezultat.Size = new System.Drawing.Size(88, 21);
            this.cmbRezultat.TabIndex = 11;
            // 
            // dtpDatumTestiranja
            // 
            this.dtpDatumTestiranja.Location = new System.Drawing.Point(165, 36);
            this.dtpDatumTestiranja.Name = "dtpDatumTestiranja";
            this.dtpDatumTestiranja.Size = new System.Drawing.Size(153, 20);
            this.dtpDatumTestiranja.TabIndex = 10;
            // 
            // cbNalazDostavljen
            // 
            this.cbNalazDostavljen.AutoSize = true;
            this.cbNalazDostavljen.Location = new System.Drawing.Point(442, 36);
            this.cbNalazDostavljen.Name = "cbNalazDostavljen";
            this.cbNalazDostavljen.Size = new System.Drawing.Size(104, 17);
            this.cbNalazDostavljen.TabIndex = 17;
            this.cbNalazDostavljen.Text = "Nalaz dostavljen";
            this.cbNalazDostavljen.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(552, 32);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(90, 23);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Broj testova:";
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.AutoSize = true;
            this.lblBrojTestova.Location = new System.Drawing.Point(81, 346);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(0, 13);
            this.lblBrojTestova.TabIndex = 20;
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(7, 35);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(125, 21);
            this.cmbStudenti.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Generisanje testova";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Broj testova:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 24;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(270, 363);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(69, 23);
            this.btnGenerisi.TabIndex = 25;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(379, 362);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 23);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "Brisanje";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Brisanje testova";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(574, 361);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(68, 23);
            this.btnPrintaj.TabIndex = 28;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // dgvStudentiCovidTestovi
            // 
            this.dgvStudentiCovidTestovi.AllowUserToAddRows = false;
            this.dgvStudentiCovidTestovi.AllowUserToDeleteRows = false;
            this.dgvStudentiCovidTestovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiCovidTestovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.Nalazdostavljen});
            this.dgvStudentiCovidTestovi.Location = new System.Drawing.Point(7, 72);
            this.dgvStudentiCovidTestovi.Name = "dgvStudentiCovidTestovi";
            this.dgvStudentiCovidTestovi.ReadOnly = true;
            this.dgvStudentiCovidTestovi.Size = new System.Drawing.Size(635, 271);
            this.dgvStudentiCovidTestovi.TabIndex = 29;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            // 
            // Nalazdostavljen
            // 
            this.Nalazdostavljen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nalazdostavljen.DataPropertyName = "NalazDostavljen";
            this.Nalazdostavljen.HeaderText = "Nalaz dostavljen";
            this.Nalazdostavljen.Name = "Nalazdostavljen";
            this.Nalazdostavljen.ReadOnly = true;
            // 
            // frmCovidTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 411);
            this.Controls.Add(this.dgvStudentiCovidTestovi);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbNalazDostavljen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRezultat);
            this.Controls.Add(this.dtpDatumTestiranja);
            this.Name = "frmCovidTest";
            this.Text = "frmCovidTest";
            this.Load += new System.EventHandler(this.frmCovidTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiCovidTestovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRezultat;
        private System.Windows.Forms.DateTimePicker dtpDatumTestiranja;
        private System.Windows.Forms.CheckBox cbNalazDostavljen;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridView dgvStudentiCovidTestovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nalazdostavljen;
    }
}