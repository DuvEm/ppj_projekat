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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static String kupacID;
        public static String konekcioniString = "Server=localhost; Port=3306; Database=ppj_projekat; " +
                    "Uid=root; Pwd=emir1.";

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            String korisnickoIme = textBoxKorisnickoIme.Text;
            String sifra = textBoxSifra.Text;

            String query = "SELECT pass, CONCAT(ime, ' ', prezime), kupac_id" +
                " FROM Kupac WHERE user ='" + korisnickoIme + "' ";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);

                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(query, konekcija);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();

                if (!reader.HasRows)
                {
                    errorProvider1.SetError(textBoxKorisnickoIme, "Pogrešno korisničko ime !!!");
                }
                else
                {
                    String pass = reader[0].ToString();
                    String imePrez = reader[1].ToString();
                    kupacID = reader[2].ToString();
                    if (sifra == pass && kupacID=="1")
                    {
                        MessageBox.Show("Uspješno ste logovani " + imePrez);
                        Form2 fr2 = new Form2();
                        this.Hide();
                        fr2.Show();
                    }
                    else if (sifra == pass && kupacID!="1")
                    {
                        MessageBox.Show("Uspješno ste logovani " + imePrez);
                        Form5 fr5 = new Form5();
                        this.Hide();
                        fr5.Show();
                    }
                    else
                    {
                        errorProvider1.SetError(textBoxSifra, "Pogrešan password !!!");
                    }
                }
                reader.Close();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
