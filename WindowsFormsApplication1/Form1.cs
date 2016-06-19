using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        List<Firma> firmy = new List<Firma>();

        public Form1()
        {
            InitializeComponent();
            wczytaj_Firmy();
            odswiez();
          
        }

        public void read()
        {
            listBox1.Items.Clear();
            using (StreamReader sr = new StreamReader(@"C:\Users\Ewa\Documents\plik.txt"))
            {
                // Read the stream to a string, and write the string to the console.
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line + "\n");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String przedrostek;
            String nazwa;
            int numer;
            nazwa = textBox1.Text;
            przedrostek = textBox2.Text;
            dodaj_Firme(nazwa, przedrostek);
            zapisz();
            odswiez();
          
        }

        public void zapisz()
        {
            string path = @"C:\Users\Ewa\Documents\plik.txt";
            StreamWriter sw = new StreamWriter(path);

            foreach (var firma in firmy)
            {
                String line = firma.nazwa + ',' + firma.przedrostek + ',' + firma.licznik;
                sw.WriteLine(line);
               
            }
            sw.Close();
            odswiez();
        }

        public void dodaj_Firme(String nazwa, String przedrostek)
        {
            Firma firma = new Firma(nazwa, przedrostek);
            firmy.Add(firma);
        }

        public void wczytaj_Firmy()
        {
            
            using (StreamReader sr = new StreamReader(@"C:\Users\Ewa\Documents\plik.txt"))
            {
                // Read the stream to a string, and write the string to the console.
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var n = line.Split(',');

                    firmy.Add(new Firma(n[0], n[1], Int32.Parse(n[2])));
                   // listBox1.Items.Add(n[0] + "\n");
                }
            }
        }
        public void odswiez()
        {
            listBox1.Items.Clear();
            foreach (var firma in firmy) {
                listBox1.Items.Add(firma.nazwa + "\n");
            }
           

        }
    }
}
