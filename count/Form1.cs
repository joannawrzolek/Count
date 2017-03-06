using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net;

namespace count
{
    public partial class Form1 : Form
    {
        string imie;
        int samoglImie;
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;


        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = string.Empty;
            imie = textBox1.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IleSamoglosek(imie);
            samoglImie = IleSamoglosek(imie);
            //textBox1.Text = samoglImie.ToString();
            MessageBox.Show(samoglImie.ToString());
        }


        static public int IleSamoglosek(string zdanie)
        {
            int licznik = 0;
            string samogloski = "aeiouyAEIOUYęąśćżółńźĄĘŻŹĆŁÓ";

            foreach (char litera in zdanie)
            {
                if (samogloski.Contains(litera))
                {
                    licznik++;
                }
            }
            return licznik;
        }

        static public int IleSamoglosek(char literka)
        {
            int licznik = 0;
            string samogloski = "aeiouyAEIOUYęąśćżółńźĄĘŻŹĆŁÓ";

            if (samogloski.Contains(literka))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static public int IleSamoglosek(string[] slownik)
        {
            int licznik = 0;

            foreach (string wyraz in slownik)
            {
                //licznik += IleSamoglosek(wyraz);
                int licznikSamWyraz = 0;
                licznikSamWyraz = IleSamoglosek(wyraz);
                licznik = licznik + licznikSamWyraz;
            }
            return licznik;
        }

        static public int IleSamoglosek(string[] slownik, int start, int koniec)
        {
            int licznik = 0;

            for (int i = start; i <= koniec; i++)
            {
                licznik += IleSamoglosek(slownik[i]);
            }
            return licznik;
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString(" HH:mm:ss yyyy-MM-dd ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

   
    }
}
