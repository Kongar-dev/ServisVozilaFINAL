namespace ServisVozila
{
    partial class Vozila
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnIzmena = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReg = new System.Windows.Forms.TextBox();
            this.tbGodiste = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.tbIDvozila = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 33);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1049, 384);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID vozila";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Klijenta";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime Klijenta";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marka";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Godiste";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Registracija";
            this.columnHeader7.Width = 100;
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(1211, 647);
            this.btnBrisanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(148, 70);
            this.btnBrisanje.TabIndex = 27;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnIzmena
            // 
            this.btnIzmena.Location = new System.Drawing.Point(1211, 570);
            this.btnIzmena.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmena.Name = "btnIzmena";
            this.btnIzmena.Size = new System.Drawing.Size(148, 70);
            this.btnIzmena.TabIndex = 26;
            this.btnIzmena.Text = "Izmena";
            this.btnIzmena.UseVisualStyleBackColor = true;
            this.btnIzmena.Click += new System.EventHandler(this.btnIzmena_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 495);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Registracija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 495);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Godiste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 495);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 495);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ime";
            // 
            // tbReg
            // 
            this.tbReg.Location = new System.Drawing.Point(731, 462);
            this.tbReg.Margin = new System.Windows.Forms.Padding(4);
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(145, 22);
            this.tbReg.TabIndex = 20;
            // 
            // tbGodiste
            // 
            this.tbGodiste.Location = new System.Drawing.Point(563, 462);
            this.tbGodiste.Margin = new System.Windows.Forms.Padding(4);
            this.tbGodiste.Name = "tbGodiste";
            this.tbGodiste.Size = new System.Drawing.Size(144, 22);
            this.tbGodiste.TabIndex = 19;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(384, 462);
            this.tbModel.Margin = new System.Windows.Forms.Padding(4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(141, 22);
            this.tbModel.TabIndex = 18;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(223, 462);
            this.tbMarka.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(132, 22);
            this.tbMarka.TabIndex = 17;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(36, 462);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(132, 22);
            this.tbIme.TabIndex = 16;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(1211, 492);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(148, 70);
            this.btnUnos.TabIndex = 15;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // tbIDvozila
            // 
            this.tbIDvozila.Location = new System.Drawing.Point(1476, 1006);
            this.tbIDvozila.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDvozila.Name = "tbIDvozila";
            this.tbIDvozila.ReadOnly = true;
            this.tbIDvozila.Size = new System.Drawing.Size(188, 22);
            this.tbIDvozila.TabIndex = 28;
            // 
            // Vozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 740);
            this.Controls.Add(this.tbIDvozila);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnIzmena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReg);
            this.Controls.Add(this.tbGodiste);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vozila";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.Vozila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnIzmena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReg;
        private System.Windows.Forms.TextBox tbGodiste;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox tbIDvozila;
    }
}