using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                listeSportboote.Add(new Sportboot(random.Next(100, 999), random.Next(7, 40), random.Next(5, 25)));
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

                if(bootsnummer >= 100 && bootsnummer <= 999)
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
    }
}
