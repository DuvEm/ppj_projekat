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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        String konekStr = Form1.konekcioniString;
        String kupacID = Form1.kupacID;

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
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
            fr1.Show();
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            PrikazNarudzbi();
        }
        private void PrikazNarudzbi()
        {
            String query = "SELECT narudzbenica.*, stavka_narudzbenice.stavka_id" +
                            " FROM narudzbenica, stavka_narudzbenice where narudzbenica.narudzbenica_id=stavka_narudzbenice.narudzbenica_id and kupac_id='" + kupacID + "';";
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open(); 
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, konekcija);
            DataTable tabela = new DataTable();
            dataAdapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataAdapter.Dispose();
            konekcija.Close();
        }

        private void buttonPrikazStavki_Click(object sender, EventArgs e)
        {
            prikazGrid2();
        }
        private void prikazGrid2()
        {
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                String query4 = "SELECT stavka_narudzbenice.stavka_id as 'ID narudzbenice', stavka_narudzbenice.kolicina as 'Kolicina',stavka_narudzbenice.narudzbenica_id as 'ID narudzbe', artikal.naziv_artikla AS 'Naziv artikla'" +
                                " FROM artikal, stavka_narudzbenice where artikal.artikal_id=stavka_narudzbenice.artikal_id and stavka_narudzbenice.narudzbenica_id='" + textBoxID.Text + "';";
                MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(query4, konekcija);
                DataTable tabela1 = new DataTable();
                dataAdapter1.Fill(tabela1);
                dataGridView2.DataSource = tabela1;
                dataAdapter1.Dispose();

                String query2 = "SELECT artikal_id,kolicina from stavka_narudzbenice where narudzbenica_id='" + textBoxID.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(query2, konekcija);
                MySqlDataReader reader;
                reader = cmd2.ExecuteReader();
                reader.Read();
                string artikal_id = reader[0].ToString();
                int kolicina = Convert.ToInt32(reader[1]);
                reader.Close();

                String query5 = "select sum(ukupno_novca) from stavka_narudzbenice where narudzbenica_id='" + textBoxID.Text + "';";
                MySqlCommand cmd5 = new MySqlCommand(query5, konekcija);
                MySqlDataReader reader2;
                reader2 = cmd5.ExecuteReader();
                reader2.Read();
                textBoxTotal.Text=reader2[0].ToString();
                reader2.Close();
                konekcija.Close();
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

    }
}
