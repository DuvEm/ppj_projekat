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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.PostaviStatusLogout();
            Application.Exit();
        }

        private void kreiranjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fr5 = new Form5();
            fr5.Show();
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
    }
}
