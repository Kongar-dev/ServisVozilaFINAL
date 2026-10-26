namespace ServisVozila
{
    partial class Servisi
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
            this.tbKilometraza = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.LVtabela = new System.Windows.Forms.ListView();
            this.ServisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VoziloID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumServisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpisKvara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpisUsluge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilometraza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUnos = new System.Windows.Forms.Button();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbOpisUsluge = new System.Windows.Forms.TextBox();
            this.tbOpisKvara = new System.Windows.Forms.TextBox();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.tbIDvozila = new System.Windows.Forms.TextBox();
            this.tbIdServisa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbKilometraza
            // 
            this.tbKilometraza.Location = new System.Drawing.Point(1316, 654);
            this.tbKilometraza.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbKilometraza.Name = "tbKilometraza";
            this.tbKilometraza.Size = new System.Drawing.Size(196, 31);
            this.tbKilometraza.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1316, 697);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 44);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Izbrisi iz baze";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIzmena
            // 
            this.btnIzmena.Location = new System.Drawing.Point(692, 697);
            this.btnIzmena.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(196, 44);
            this.btnIzmena.TabIndex = 20;
            this.btnIzmena.Text = "Promeni podatke";
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.button2_Click);
            // 
            // LVtabela
            // 
            this.LVtabela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServisID,
            this.VoziloID,
            this.DatumServisa,
            this.OpisKvara,
            this.OpisUsluge,
            this.Cena,
            this.Kilometraza});
            this.LVtabela.FullRowSelect = true;
            this.LVtabela.HideSelection = false;
            this.LVtabela.Location = new System.Drawing.Point(15, 15);
            this.LVtabela.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LVtabela.MultiSelect = false;
            this.LVtabela.Name = "LVtabela";
            this.LVtabela.Size = new System.Drawing.Size(1574, 627);
            this.LVtabela.TabIndex = 19;
            this.LVtabela.UseCompatibleStateImageBehavior = false;
            this.LVtabela.View = System.Windows.Forms.View.Details;
            this.LVtabela.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ServisID
            // 
            this.ServisID.Text = "ServisID";
            this.ServisID.Width = 100;
            // 
            // VoziloID
            // 
            this.VoziloID.Text = "VoziloID";
            this.VoziloID.Width = 100;
            // 
            // DatumServisa
            // 
            this.DatumServisa.Text = "DatumServisa";
            this.DatumServisa.Width = 250;
            // 
            // OpisKvara
            // 
            this.OpisKvara.Text = "OpisKvara";
            this.OpisKvara.Width = 400;
            // 
            // OpisUsluge
            // 
            this.OpisUsluge.Text = "OpisUsluge";
            this.OpisUsluge.Width = 400;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 170;
            // 
            // Kilometraza
            // 
            this.Kilometraza.Text = "Kilometraza";
            this.Kilometraza.Width = 150;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(68, 697);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(196, 44);
            this.btnUnos.TabIndex = 18;
            this.btnUnos.Text = "Dodaj u bazu";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(1108, 654);
            this.tbCena.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(196, 31);
            this.tbCena.TabIndex = 17;
            // 
            // tbOpisUsluge
            // 
            this.tbOpisUsluge.Location = new System.Drawing.Point(900, 654);
            this.tbOpisUsluge.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbOpisUsluge.Name = "tbOpisUsluge";
            this.tbOpisUsluge.Size = new System.Drawing.Size(196, 31);
            this.tbOpisUsluge.TabIndex = 16;
            // 
            // tbOpisKvara
            // 
            this.tbOpisKvara.Location = new System.Drawing.Point(692, 654);
            this.tbOpisKvara.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbOpisKvara.Name = "tbOpisKvara";
            this.tbOpisKvara.Size = new System.Drawing.Size(196, 31);
            this.tbOpisKvara.TabIndex = 15;
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(484, 654);
            this.tbDatum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(196, 31);
            this.tbDatum.TabIndex = 14;
            // 
            // tbIDvozila
            // 
            this.tbIDvozila.Location = new System.Drawing.Point(276, 654);
            this.tbIDvozila.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbIDvozila.Name = "tbIDvozila";
            this.tbIDvozila.Size = new System.Drawing.Size(196, 31);
            this.tbIDvozila.TabIndex = 13;
            // 
            // tbIdServisa
            // 
            this.tbIdServisa.Location = new System.Drawing.Point(68, 654);
            this.tbIdServisa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbIdServisa.Name = "tbIdServisa";
            this.tbIdServisa.ReadOnly = true;
            this.tbIdServisa.Size = new System.Drawing.Size(196, 31);
            this.tbIdServisa.TabIndex = 12;
            // 
            // Servisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 756);
            this.Controls.Add(this.tbKilometraza);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.LVtabela);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbOpisUsluge);
            this.Controls.Add(this.tbOpisKvara);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.tbIDvozila);
            this.Controls.Add(this.tbIdServisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Servisi";
            this.Text = "Servisi";
            this.Load += new System.EventHandler(this.Servisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKilometraza;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.ListView LVtabela;
        private System.Windows.Forms.ColumnHeader ServisID;
        private System.Windows.Forms.ColumnHeader VoziloID;
        private System.Windows.Forms.ColumnHeader DatumServisa;
        private System.Windows.Forms.ColumnHeader OpisKvara;
        private System.Windows.Forms.ColumnHeader OpisUsluge;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.ColumnHeader Kilometraza;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbOpisUsluge;
        private System.Windows.Forms.TextBox tbOpisKvara;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.TextBox tbIDvozila;
        private System.Windows.Forms.TextBox tbIdServisa;
    }
}