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
        static String konekcioniString = "Server=localhost; Port=3306; Database=ppj_projekatt; " +
                    "Uid=root; Pwd=emir1.";

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            String korisnickoIme = textBoxKorisnickoIme.Text;
            String sifra = textBoxSifra.Text;

            String query = "SELECT pass, CONCAT(ime, ' ', prezime), login_status, uloga " +
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
                    String loginStatus = reader[2].ToString();
                    String uloga = reader[3].ToString();
                    if (loginStatus == "1")
                    {
                        errorProvider1.SetError(buttonPrijava, "Korisnik je već logovan!!!");
                    }
                    else if (sifra == pass && uloga=="admin")
                    {
                        MessageBox.Show("Uspješno ste logovani " + imePrez);
                        PostaviStatusLogin();
                        Form2 fr2 = new Form2();
                        this.Hide();
                        fr2.Show();
                    }
                    else if (sifra == pass && uloga == "kupac")
                    {
                        MessageBox.Show("Uspješno ste logovani " + imePrez);
                        PostaviStatusLogin();
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

        private void PostaviStatusLogin()
        {
            String upit = "UPDATE Kupac SET login_status=1 " +
                    " WHERE kupac_id='" + kupacID + "' ";
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PostaviStatusLogout()
        {
            String upit = "UPDATE Kupac SET login_status=0 " +
                    " WHERE kupac_id='" + kupacID + "' ";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();
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
