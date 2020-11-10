namespace PrviParcijalniPR3
{
    partial class frmStudenti
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnosBrojaIndeksa = new System.Windows.Forms.TextBox();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            this.lblPrikazaniStud = new System.Windows.Forms.Label();
            this.BrojIndeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojIndeksa,
            this.Ime,
            this.Prezime,
            this.Email,
            this.BrojPolozenih});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 92);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(802, 314);
            this.dgvStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite broj indeksa:";
            // 
            // txtUnosBrojaIndeksa
            // 
            this.txtUnosBrojaIndeksa.Location = new System.Drawing.Point(169, 43);
            this.txtUnosBrojaIndeksa.Name = "txtUnosBrojaIndeksa";
            this.txtUnosBrojaIndeksa.Size = new System.Drawing.Size(349, 20);
            this.txtUnosBrojaIndeksa.TabIndex = 2;
            this.txtUnosBrojaIndeksa.TextChanged += new System.EventHandler(this.txtUnosBrojaIndeksa_TextChanged);
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(533, 35);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(130, 35);
            this.btnPrikaziDetalje.TabIndex = 3;
            this.btnPrikaziDetalje.Text = "Prikazi detalje";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStudenta.Location = new System.Drawing.Point(678, 35);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(120, 35);
            this.btnDodajStudenta.TabIndex = 4;
            this.btnDodajStudenta.Text = "Novi student";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // lblPrikazaniStud
            // 
            this.lblPrikazaniStud.AutoEllipsis = true;
            this.lblPrikazaniStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazaniStud.Location = new System.Drawing.Point(14, 417);
            this.lblPrikazaniStud.Name = "lblPrikazaniStud";
            this.lblPrikazaniStud.Size = new System.Drawing.Size(310, 24);
            this.lblPrikazaniStud.TabIndex = 5;
            this.lblPrikazaniStud.Text = "Prikazano je 2 studenta i njihov prosjek je 0,00";
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojIndeksa.DataPropertyName = "BrojIndeksa";
            this.BrojIndeksa.HeaderText = "Broj Indeksa";
            this.BrojIndeksa.Name = "BrojIndeksa";
            this.BrojIndeksa.ReadOnly = true;
            this.BrojIndeksa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozenih.DataPropertyName = "BrojPolozenihPredmeta";
            this.BrojPolozenih.HeaderText = "Broj Polozenih";
            this.BrojPolozenih.Name = "BrojPolozenih";
            this.BrojPolozenih.ReadOnly = true;
            this.BrojPolozenih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lblPrikazaniStud);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.txtUnosBrojaIndeksa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "frmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnosBrojaIndeksa;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.Button btnDodajStudenta;
        private System.Windows.Forms.Label lblPrikazaniStud;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojIndeksa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
    }
}

