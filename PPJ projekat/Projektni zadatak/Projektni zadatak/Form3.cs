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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        String konekStr = Form1.konekcioniString; 
   
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
            fr1.Show();
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            Application.Exit();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
            Application.Exit();
        }

        private void buttonDodavanjeArtikla_Click(object sender, EventArgs e)
        {
            KreiranjeArtikla();
            PrikazArtikla();
            brisanjeTeksta();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PrikazArtikla();
        }
        private void PrikazArtikla()
        {
            try
            {
                String query = "SELECT artikal.artikal_id AS 'ID artikla', artikal.naziv_artikla AS 'Naziv artikla'," +
                    " artikal.vrsta_artikla AS 'Vrsta artikla', artikal.cijena AS 'Cijena', skladiste.kolicina_stanje as 'Kolicina'" +
                    " FROM artikal, skladiste where artikal.artikal_id=skladiste.artikal_id";

                if (textBoxSifra.Text != "" || textBoxNazivArtikla.Text != "")
                {
                    query += " and artikal.artikal_id LIKE '" + textBoxSifra.Text + "%' and artikal.naziv_artikla LIKE '" + textBoxNazivArtikla.Text + "%' "; ;
                }
                query += " ORDER BY artikal.artikal_id ASC ";
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
        
        private void KreiranjeArtikla()
        { 
            
            String query = "INSERT INTO artikal (naziv_artikla,vrsta_artikla,cijena) VALUES " +
            "('" + textBoxNazivArtikla2.Text + "','" + textBoxVrstaArtikla.Text + "','" + textBoxCijena.Text + "')";
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();
            MySqlCommand cmd = new MySqlCommand(query, konekcija);
            cmd.ExecuteNonQuery();
            String query2 = "SELECT artikal_id from artikal where naziv_artikla='" + textBoxNazivArtikla2.Text + "'";
            MySqlCommand cmd2 = new MySqlCommand(query2, konekcija);
            MySqlDataReader reader;
            reader = cmd2.ExecuteReader();
            reader.Read(); 
            string artikal_id = reader[0].ToString();
            reader.Close();
            String query1 = "INSERT INTO skladiste (kolicina_stanje,artikal_id) VALUES ('" + textBoxKolicina.Text + "',";
            query1 += "' " + artikal_id + "')";
            MySqlCommand cmd1 = new MySqlCommand(query1, konekcija);
            
            cmd1.ExecuteNonQuery();
            konekcija.Close();
            }
            
        private void brisanjeTeksta()
        {
            textBoxID.Text = "";
            textBoxCijena.Text = "";
            textBoxKolicina.Text = "";
            textBoxNazivArtikla2.Text = "";
            textBoxVrstaArtikla.Text = "";
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            PrikazArtikla();
        }

        private void textBoxSifra_TextChanged(object sender, EventArgs e)
        {
            PrikazArtikla();
        }

        private void textBoxNazivArtikla_TextChanged(object sender, EventArgs e)
        {
            PrikazArtikla();
        }

        private void buttonAzuriranjeArtikla_Click(object sender, EventArgs e)
        {
            AzuriranjeArtikla();
            PrikazArtikla();
            textBoxID.Text = "";
            numericUpDown1.Value = 0;
        }
        private void AzuriranjeArtikla()
        {
            try
            {
                string query = " Update skladiste set kolicina_stanje=kolicina_stanje+'" + numericUpDown1.Value +
                "' where artikal_id='" + textBoxID.Text + "' ";
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Podaci su azurirani");
                konekcija.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }
         
    }
}
