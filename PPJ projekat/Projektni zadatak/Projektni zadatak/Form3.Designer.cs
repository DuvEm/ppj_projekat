namespace Projektni_zadatak
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxNazivArtikla = new System.Windows.Forms.TextBox();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVrstaArtikla = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazivArtikla2 = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAzuriranjeArtikla = new System.Windows.Forms.Button();
            this.buttonDodavanjeArtikla = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazbrisanjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxKolicina);
            this.groupBox1.Controls.Add(this.textBoxSifra);
            this.groupBox1.Controls.Add(this.textBoxNazivArtikla);
            this.groupBox1.Controls.Add(this.buttonTrazi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxVrstaArtikla);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNazivArtikla2);
            this.groupBox1.Controls.Add(this.textBoxCijena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonAzuriranjeArtikla);
            this.groupBox1.Controls.Add(this.buttonDodavanjeArtikla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 383);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje/ažuriranje artikala";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(416, 314);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 192);
            this.dataGridView1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dodaj količinu:";
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(96, 316);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolicina.TabIndex = 6;
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(6, 19);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(59, 20);
            this.textBoxSifra.TabIndex = 7;
            this.textBoxSifra.TextChanged += new System.EventHandler(this.textBoxSifra_TextChanged);
            // 
            // textBoxNazivArtikla
            // 
            this.textBoxNazivArtikla.Location = new System.Drawing.Point(71, 19);
            this.textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            this.textBoxNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivArtikla.TabIndex = 8;
            this.textBoxNazivArtikla.TextChanged += new System.EventHandler(this.textBoxNazivArtikla_TextChanged);
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.Location = new System.Drawing.Point(177, 19);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(75, 23);
            this.buttonTrazi.TabIndex = 10;
            this.buttonTrazi.Text = "Traži";
            this.buttonTrazi.UseVisualStyleBackColor = true;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cijena:";
            // 
            // textBoxVrstaArtikla
            // 
            this.textBoxVrstaArtikla.Location = new System.Drawing.Point(96, 267);
            this.textBoxVrstaArtikla.Name = "textBoxVrstaArtikla";
            this.textBoxVrstaArtikla.Size = new System.Drawing.Size(100, 20);
            this.textBoxVrstaArtikla.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(416, 290);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(57, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv artikla:";
            // 
            // textBoxNazivArtikla2
            // 
            this.textBoxNazivArtikla2.Location = new System.Drawing.Point(96, 243);
            this.textBoxNazivArtikla2.Name = "textBoxNazivArtikla2";
            this.textBoxNazivArtikla2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazivArtikla2.TabIndex = 2;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(96, 293);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCijena.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vrsta artikla:";
            // 
            // buttonAzuriranjeArtikla
            // 
            this.buttonAzuriranjeArtikla.Location = new System.Drawing.Point(335, 346);
            this.buttonAzuriranjeArtikla.Name = "buttonAzuriranjeArtikla";
            this.buttonAzuriranjeArtikla.Size = new System.Drawing.Size(138, 35);
            this.buttonAzuriranjeArtikla.TabIndex = 12;
            this.buttonAzuriranjeArtikla.Text = "Ažurairanje podataka";
            this.buttonAzuriranjeArtikla.UseVisualStyleBackColor = true;
            this.buttonAzuriranjeArtikla.Click += new System.EventHandler(this.buttonAzuriranjeArtikla_Click);
            // 
            // buttonDodavanjeArtikla
            // 
            this.buttonDodavanjeArtikla.Location = new System.Drawing.Point(62, 349);
            this.buttonDodavanjeArtikla.Name = "buttonDodavanjeArtikla";
            this.buttonDodavanjeArtikla.Size = new System.Drawing.Size(134, 35);
            this.buttonDodavanjeArtikla.TabIndex = 11;
            this.buttonDodavanjeArtikla.Text = "Dodavanje artikla";
            this.buttonDodavanjeArtikla.UseVisualStyleBackColor = true;
            this.buttonDodavanjeArtikla.Click += new System.EventHandler(this.buttonDodavanjeArtikla_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem,
            this.prikazbrisanjeNarudžbeToolStripMenuItem,
            this.odjavaToolStripMenuItem,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // kreiranjeažuriranjeNovogKupcaToolStripMenuItem
            // 
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Name = "kreiranjeažuriranjeNovogKupcaToolStripMenuItem";
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Text = "Kreiranje/ažuriranje novog kupca";
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem_Click);
            // 
            // prikazbrisanjeNarudžbeToolStripMenuItem
            // 
            this.prikazbrisanjeNarudžbeToolStripMenuItem.Name = "prikazbrisanjeNarudžbeToolStripMenuItem";
            this.prikazbrisanjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.prikazbrisanjeNarudžbeToolStripMenuItem.Text = "Prikaz/brisanje narudžbe";
            this.prikazbrisanjeNarudžbeToolStripMenuItem.Click += new System.EventHandler(this.prikazbrisanjeNarudžbeToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Dodavanje / Ažuriranje artikala";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxNazivArtikla;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVrstaArtikla;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivArtikla2;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAzuriranjeArtikla;
        private System.Windows.Forms.Button buttonDodavanjeArtikla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeažuriranjeNovogKupcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazbrisanjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
    }
}