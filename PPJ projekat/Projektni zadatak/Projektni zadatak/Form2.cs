using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projektni_zadatak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String konekStr = Form1.konekcioniString;

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
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
            fr1.Show();
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PrikazKorisnika();
        }
        private void PrikazKorisnika()
        {
            try
            {
                String query = "SELECT kupac_id AS 'ID korisnika', ime AS 'Ime'," +
                    " prezime AS 'Prezime', grad AS 'Grad', adresa AS 'Adresa', " +
                    " telefon AS 'Telefon', user AS 'Korisnicko ime', pass as 'Sifra'" +
                    " FROM kupac ";
  
                if (textBoxIme.Text != "")
                {
                    query += " where kupac.ime LIKE '" + textBoxIme.Text + "%' ";
                }
                if (textBoxPrezime.Text != "")
                {
                    query += " and kupac.prezime LIKE '" + textBoxPrezime.Text + "%' ";
                }

                query += " ORDER BY kupac_id ASC ";

                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void KreiranjeKupca()
        { 
            try
        {
            string query = "insert into kupac (ime, prezime, grad, adresa, telefon, user, pass) values" +
                    "('" + textBoxIme2.Text + "','" + textBoxPrezime2.Text + "','" + textBoxGrad.Text + "','"+textBoxAdresa.Text+"','"+textBoxTelefon.Text+"','"+textBoxKorIme.Text+"','"+textBoxSifra.Text+"')";
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();
            MySqlCommand cmd = new MySqlCommand(query, konekcija);
            cmd.ExecuteNonQuery();
            konekcija.Close();
        } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AzuriranjeKupca()
        {
            try
            {
                string query = " Update kupac set ime='" + textBoxIme2.Text +
                "', prezime='" + textBoxPrezime2.Text + "', grad='" + textBoxGrad.Text +
                "', adresa='" + textBoxAdresa.Text + "', telefon='" + textBoxTelefon.Text +
                "', user='" + textBoxKorIme.Text + "', pass='" + textBoxSifra.Text +
                "' where kupac_id='" + textBoxIDKupca.Text + "' ";
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            PrikazKorisnika();
        }

        private void buttonKreiranjeKupca_Click(object sender, EventArgs e)
        {
            KreiranjeKupca();
        }

        private void buttonAzuriranjeKupca_Click(object sender, EventArgs e)
        {
            AzuriranjeKupca();
        }
    }
}
