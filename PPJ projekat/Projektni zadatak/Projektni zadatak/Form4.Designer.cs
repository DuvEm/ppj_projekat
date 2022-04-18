namespace Projektni_zadatak
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonBrisanjeNarudzbe = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeažuriranjeNovogKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.buttonBrisanjeNarudzbe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 256);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz / Brisanje narudžbe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 192);
            this.dataGridView1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID narudžbe:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(91, 229);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(77, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // buttonBrisanjeNarudzbe
            // 
            this.buttonBrisanjeNarudzbe.Location = new System.Drawing.Point(174, 221);
            this.buttonBrisanjeNarudzbe.Name = "buttonBrisanjeNarudzbe";
            this.buttonBrisanjeNarudzbe.Size = new System.Drawing.Size(151, 35);
            this.buttonBrisanjeNarudzbe.TabIndex = 12;
            this.buttonBrisanjeNarudzbe.Text = "Brisanje narudžbe:";
            this.buttonBrisanjeNarudzbe.UseVisualStyleBackColor = true;
            this.buttonBrisanjeNarudzbe.Click += new System.EventHandler(this.buttonBrisanjeNarudzbe_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem,
            this.dodavanjeažuriranjeNovogKupcaToolStripMenuItem,
            this.odjavaToolStripMenuItem,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // kreiranjeažuriranjeNovogKupcaToolStripMenuItem
            // 
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Name = "kreiranjeažuriranjeNovogKupcaToolStripMenuItem";
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Text = "Kreiranje/ažuriranje novog kupca";
            this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeažuriranjeNovogKupcaToolStripMenuItem_Click);
            // 
            // dodavanjeažuriranjeNovogKupcaToolStripMenuItem
            // 
            this.dodavanjeažuriranjeNovogKupcaToolStripMenuItem.Name = "dodavanjeažuriranjeNovogKupcaToolStripMenuItem";
            this.dodavanjeažuriranjeNovogKupcaToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.dodavanjeažuriranjeNovogKupcaToolStripMenuItem.Text = "Dodavanje/ažuriranje novog kupca";
            this.dodavanjeažuriranjeNovogKupcaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeažuriranjeNovogKupcaToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Prikaz / Brisanje narudžbe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonBrisanjeNarudzbe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeažuriranjeNovogKupcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeažuriranjeNovogKupcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
    }
}