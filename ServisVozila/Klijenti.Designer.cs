namespace ServisVozila
{
    partial class Klijenti
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indexsniff = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(792, 419);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(72, 406);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 20);
            this.tbIme.TabIndex = 2;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(212, 406);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 3;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(340, 406);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 20);
            this.tbTel.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(467, 406);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(109, 20);
            this.tbMail.TabIndex = 5;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(593, 406);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(142, 20);
            this.tbAdress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresa";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(72, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(632, 290);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnIzmena
            // 
            this.btnIzmena.Location = new System.Drawing.Point(792, 448);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(75, 23);
            this.btnIzmena.TabIndex = 13;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(792, 477);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(75, 23);
            this.btnBrisanje.TabIndex = 14;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezime";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // indexsniff
            // 
            this.indexsniff.AutoSize = true;
            this.indexsniff.Location = new System.Drawing.Point(749, 258);
            this.indexsniff.Name = "indexsniff";
            this.indexsniff.Size = new System.Drawing.Size(0, 13);
            this.indexsniff.TabIndex = 15;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(1103, 772);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 16;
            // 
            // Klijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 526);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.indexsniff);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btnUnos);
            this.Name = "Klijenti";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Klijenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label indexsniff;
        private System.Windows.Forms.TextBox tbID;
    }
}