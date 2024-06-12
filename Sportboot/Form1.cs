using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sportboot
{
    public partial class Form1 : Form
    {
        List<Sportboot> listeSportboote = new List<Sportboot>();
        Random random = new Random();

        string filename = @"..\..\daten\Sportboote.csv";

        public Form1()
        {
            InitializeComponent();

            string content = "";

            if (File.Exists(filename))
            {
                StreamReader myFile = new StreamReader(filename);
                while (!myFile.EndOfStream)
                {
                    content = myFile.ReadLine();
                    string[] split = content.Split(';');
                    listeSportboote.Add(new Sportboot(Convert.ToInt16(split[0]), Convert.ToInt16(split[1]), Convert.ToInt16(split [2])));
                }
                myFile.Close();
            }
            else
            {
                MessageBox.Show("Datei zum einlesen nicht gefunden!");
            }

            Ausgabe();
        }

        private void btn_eingabe_Click(object sender, EventArgs e)
        {
            try
            {
                int bootsnummer = Convert.ToInt16(txt_bootsnummer.Text);
                int laenge = Convert.ToInt16(txt_laenge.Text);
                int leistung = Convert.ToInt16(txt_leistung.Text);

                if (bootsnummer >= 100 && bootsnummer <= 999)
                {
                    listeSportboote.Add(new Sportboot(bootsnummer, laenge, leistung));
                    Ausgabe();
                }
                else
                {
                    MessageBox.Show("3-stellige Bootsnummer eingeben!");
                }
            }
            catch
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
            }
        }

        private void btn_fuehrerschein_Click(object sender, EventArgs e)
        {
            lbl_fuehrerschein.Text = Convert.ToString(listeSportboote[0].FuehrerscheinPlicht);
        }

        private void btn_gewicht_Click(object sender, EventArgs e)
        {
            lbl_gewicht.Text = Convert.ToString(listeSportboote[0].Gewicht) + " kg";
        }

        private void Ausgabe()
        {
            txt_ausgabe.Clear();

            foreach (Sportboot boot in listeSportboote)
            {
                txt_ausgabe.Text += boot.ToString() + Environment.NewLine;
            }

            txt_bootsnummer.Clear();
            txt_laenge.Clear();
            txt_leistung.Clear();
        }

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                StreamWriter myFile = new StreamWriter(filename);

                foreach (Sportboot boot in listeSportboote)
                {
                    myFile.WriteLine(boot.AusgabeCSV());
                }

                myFile.Close();

                MessageBox.Show("Gespeichert!");
            }
            else
            {
                MessageBox.Show("Datei zum speichern nicht gefunden!");
            }
        }
    }
}
