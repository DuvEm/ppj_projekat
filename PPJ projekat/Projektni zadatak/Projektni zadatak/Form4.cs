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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void dodavanjeažuriranjeNovogKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr3 = new Form3();
            fr3.Show();
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

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
        }
        private void PrikazNarudzbi()
        {
            try
            {
                String query = "SELECT n.narudzbenica_id as 'Broj narudzbe',n.datum_narudzbe as 'Datum narudzbe' ,a.naziv_artikla as 'Naziv artikla',s.kolicina as 'Kolicina', concat(k.ime,' ',k.prezime) as 'Kupac'" +
                    " FROM narudzbenica n, stavka_narudzbenice s, kupac k, artikal a "+ 
                    " where n.narudzbenica_id=s.narudzbenica_id and k.kupac_id=n.kupac_id and s.artikal_id=a.artikal_id "
                    +" order by n.narudzbenica_id";

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

        private void BrisanjeNarudzbe()
        {
            try
            {
                string query = "SET FOREIGN_KEY_CHECKS=0;Delete from narudzbenica" + " where narudzbenica_id='" + textBoxID.Text + "'; SET FOREIGN_KEY_CHECKS=0;";
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                cmd.ExecuteNonQuery();
                string query3 = "select artikal_id, kolicina from stavka_narudzbenice where narudzbenica_id='" + textBoxID.Text + "';";
                MySqlCommand cmd3 = new MySqlCommand(query3, konekcija);
                MySqlDataReader reader;
                reader = cmd3.ExecuteReader();
                reader.Read();
                string artikal_id = reader[0].ToString();
                string kolicina = reader[1].ToString();
                reader.Close();
                string query2 = "Delete from stavka_narudzbenice" + " where narudzbenica_id='" + textBoxID.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(query2, konekcija);
                cmd2.ExecuteNonQuery();
                string query4 = " Update skladiste set kolicina_stanje=kolicina_stanje+'" + kolicina +
                "' where artikal_id='" + artikal_id + "' ";
                MySqlCommand cmd4 = new MySqlCommand(query4, konekcija);
                cmd4.ExecuteNonQuery();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBrisanjeNarudzbe_Click_1(object sender, EventArgs e)
        {
            BrisanjeNarudzbe();
            PrikazNarudzbi();
            textBoxID.Text = "";
        }
    }
}
