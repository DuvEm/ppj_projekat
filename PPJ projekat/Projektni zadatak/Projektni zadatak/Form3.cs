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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void kreiranjeažuriranjeNovogKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fr2 = new Form2();
            fr2.Show();
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

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.PostaviStatusLogout();
            Application.Exit();
        }
    }
}
