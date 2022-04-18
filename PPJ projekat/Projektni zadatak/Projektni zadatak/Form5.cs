﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        String konekStr = Form1.konekcioniString;
        String kupacID = Form1.kupacID;
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
            Application.Exit();
        }

        private void prikazNarudžbiIStavkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 fr6 = new Form6();
            fr6.Show();
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

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void PrikazArtikla()
        {
            try
            {
                String query = "SELECT artikal.artikal_id AS 'ID', artikal.naziv_artikla AS 'Naziv artikla'," +
                    " artikal.vrsta_artikla AS 'Vrsta artikla', artikal.cijena AS 'Cijena', skladiste.kolicina_stanje as 'Kolicina'" +
                    " FROM artikal, skladiste where artikal.artikal_id=skladiste.artikal_id";
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

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodavanjeNarudzba();
            PrikazArtikla();
        }

        private void DodavanjeNarudzba()
        {
            try
            {
                //Dohvatanje stanja u skladistu radi provjere 
                string query7 = "select kolicina_stanje from skladiste where artikal_id=" + textBoxID.Text;
                MySqlConnection konekcija = new MySqlConnection(konekStr);
                konekcija.Open();
                MySqlCommand cmd7 = new MySqlCommand(query7, konekcija);
                MySqlDataReader reader3; 
                reader3 = cmd7.ExecuteReader();
                reader3.Read();
                int stanje = Convert.ToInt32(reader3[0]);
                reader3.Close();
                int kolicina = Convert.ToInt32(textBoxKol.Text); 
                //provjera da li je moguce realizovati narudzbu
                if (stanje > kolicina)
                {
                    //skida sa skladista broj narucenih artikala
                    string query = " Update skladiste set kolicina_stanje=kolicina_stanje-" +textBoxKol.Text +
                    " where artikal_id='" + textBoxID.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, konekcija);
                    cmd.ExecuteNonQuery();
                    //dohvatanje posljednjeg id narudzbenice radi "ubacanja" u stavka_narudzbenice

                    string query2 = "select max(narudzbenica_id) from narudzbenica where kupac_id="+kupacID;
                    MySqlCommand cmd2 = new MySqlCommand(query2, konekcija);
                    MySqlDataReader reader;
                    reader = cmd2.ExecuteReader();
                    reader.Read();
                    string narudzbenica_id = reader[0].ToString();
                    reader.Close(); 

                    //dodavanje u tabelu stavka_narudzbenice

                    String query1 = "INSERT INTO stavka_narudzbenice (narudzbenica_id,artikal_id,kolicina) VALUES " +
                "('" + narudzbenica_id + "','" + textBoxID.Text + "','" + textBoxKol.Text + "');";
                    MySqlCommand cmd1 = new MySqlCommand(query1, konekcija);
                    cmd1.ExecuteNonQuery(); 

                    //prikaz u datagridview2
 
                    String query4 = "SELECT stavka_narudzbenice.stavka_id as 'ID narudzbenice', stavka_narudzbenice.kolicina as 'Kolicina',stavka_narudzbenice.narudzbenica_id as 'ID narudzbe', artikal.naziv_artikla AS 'Naziv artikla'" +
                            " FROM artikal, stavka_narudzbenice where artikal.artikal_id=stavka_narudzbenice.artikal_id and stavka_narudzbenice.narudzbenica_id='" + narudzbenica_id + "';";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query4, konekcija);
                    DataTable tabela = new DataTable();
                    dataAdapter.Fill(tabela);
                    dataGridView2.DataSource = tabela;
                    dataAdapter.Dispose(); 

                    //ispis ukupne cijene 

                    String query5 = "select cijena from artikal where artikal_id='" + textBoxID.Text + "';";
                    MySqlCommand cmd5 = new MySqlCommand(query5, konekcija);
                    MySqlDataReader reader2;
                    reader2 = cmd5.ExecuteReader();
                    reader2.Read();
                    int cijena = Convert.ToInt32(reader2[0]);
                    reader2.Close();
                    int ukupno = cijena * kolicina;
                    textBoxUkupno.Text = ukupno.ToString();
                }
                else { MessageBox.Show("Nema dovoljno na stanju"); }
                konekcija.Close(); 
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonKreirajNarudzbu_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Omoguceno vam je kreiranje narudzbe");
            PrikazArtikla();
            KreirajNarudzbenicu();
        }

        private void KreirajNarudzbenicu()
        {
            string query = "insert into narudzbenica (kupac_id, datum_narudzbe) values" +
                            "('" + kupacID + "'," + "now());";
                           
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();
            MySqlCommand cmd = new MySqlCommand(query, konekcija);
            cmd.ExecuteNonQuery();
            konekcija.Close();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            ObrisiNarudzbu();

        }
        private void ObrisiNarudzbu()
        {
            string query2 = "select max(narudzbenica_id) from narudzbenica where kupac_id=" + kupacID+";";
            MySqlConnection konekcija = new MySqlConnection(konekStr);
            konekcija.Open();
            MySqlCommand cmd2 = new MySqlCommand(query2, konekcija);
            MySqlDataReader reader;
            reader = cmd2.ExecuteReader();
            reader.Read();
            string narudzbenica_id = reader[0].ToString();
            reader.Close();
            string query = "SET FOREIGN_KEY_CHECKS=0;Delete from narudzbenica" + " where narudzbenica_id='" + narudzbenica_id + "'; SET FOREIGN_KEY_CHECKS=0;";
            MySqlCommand cmd = new MySqlCommand(query, konekcija);
            cmd.ExecuteNonQuery();
            string query3 = "Delete from stavka_narudzbenice" + " where narudzbenica_id='" + narudzbenica_id + "'";
            MySqlCommand cmd3 = new MySqlCommand(query3, konekcija);
            cmd3.ExecuteNonQuery();
            string query4 = " Update skladiste set kolicina_stanje=kolicina_stanje+" + textBoxKol.Text +
                    " where artikal_id='" + textBoxID.Text + "' ";
            MySqlCommand cmd4 = new MySqlCommand(query4, konekcija);
            cmd4.ExecuteNonQuery();
            PrikazArtikla();
            dataGridView2.DataSource = null;
            konekcija.Close();
            textBoxID.Text = "";
            textBoxKol.Text = "";
            textBoxUkupno.Text = "";
        }
    }
}
