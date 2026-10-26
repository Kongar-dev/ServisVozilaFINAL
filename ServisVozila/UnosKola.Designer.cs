namespace ServisVozila
{
    partial class UnosKola
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReg = new System.Windows.Forms.TextBox();
            this.tbGodiste = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(72, 54);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1260, 554);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezime";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mail";
            this.columnHeader3.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 687);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 687);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ime";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(528, 635);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(6);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            this.tbPrezime.Size = new System.Drawing.Size(196, 31);
            this.tbPrezime.TabIndex = 14;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(248, 635);
            this.tbIme.Margin = new System.Windows.Forms.Padding(6);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(196, 31);
            this.tbIme.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(806, 687);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(812, 635);
            this.tbMail.Margin = new System.Windows.Forms.Padding(6);
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(214, 31);
            this.tbMail.TabIndex = 18;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(982, 1227);
            this.tbID.Margin = new System.Windows.Forms.Padding(6);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(196, 31);
            this.tbID.TabIndex = 20;
            this.tbID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1070, 831);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Registracija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 831);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Godiste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 831);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 831);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Marka";
            // 
            // tbReg
            // 
            this.tbReg.Location = new System.Drawing.Point(1078, 767);
            this.tbReg.Margin = new System.Windows.Forms.Padding(8);
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(286, 31);
            this.tbReg.TabIndex = 29;
            // 
            // tbGodiste
            // 
            this.tbGodiste.Location = new System.Drawing.Point(742, 767);
            this.tbGodiste.Margin = new System.Windows.Forms.Padding(8);
            this.tbGodiste.Name = "tbGodiste";
            this.tbGodiste.Size = new System.Drawing.Size(284, 31);
            this.tbGodiste.TabIndex = 28;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(384, 767);
            this.tbModel.Margin = new System.Windows.Forms.Padding(8);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(278, 31);
            this.tbModel.TabIndex = 27;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(62, 767);
            this.tbMarka.Margin = new System.Windows.Forms.Padding(8);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(260, 31);
            this.tbMarka.TabIndex = 26;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(1608, 585);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(8);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(296, 135);
            this.btnUnos.TabIndex = 34;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1608, 736);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(296, 135);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // UnosKola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2072, 938);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbReg);
            this.Controls.Add(this.tbGodiste);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UnosKola";
            this.Text = "UnosKola";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnosKola_FormClosed);
            this.Load += new System.EventHandler(this.UnosKola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReg;
        private System.Windows.Forms.TextBox tbGodiste;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnExit;
    }
}