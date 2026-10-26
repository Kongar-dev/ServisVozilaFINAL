namespace ServisVozila
{
    partial class Start
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
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnServisi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.Location = new System.Drawing.Point(41, 405);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(75, 23);
            this.btnKlijenti.TabIndex = 0;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.Location = new System.Drawing.Point(357, 405);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(75, 23);
            this.btnVozila.TabIndex = 1;
            this.btnVozila.Text = "Vozila";
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnServisi
            // 
            this.btnServisi.Location = new System.Drawing.Point(685, 405);
            this.btnServisi.Name = "btnServisi";
            this.btnServisi.Size = new System.Drawing.Size(75, 23);
            this.btnServisi.TabIndex = 2;
            this.btnServisi.Text = "Servisi";
            this.btnServisi.UseVisualStyleBackColor = true;
            this.btnServisi.Click += new System.EventHandler(this.btnServisi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServisVozila.Properties.Resources.slika;
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 375);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServisi);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnKlijenti);
            this.Name = "Start";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnServisi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

