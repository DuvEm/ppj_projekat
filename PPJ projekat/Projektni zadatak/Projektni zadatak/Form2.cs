using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projektni_zadatak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.PostaviStatusLogout();
            Application.Exit();
        }

        private void dodavanjeažuriranjeNovogArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void prikazbrisanjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.PostaviStatusLogout();
            fr1.Show();
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.PostaviStatusLogout();
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
