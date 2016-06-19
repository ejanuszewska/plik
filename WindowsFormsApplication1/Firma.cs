using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Firma
    {
        public String nazwa;
        public String przedrostek;
        public int licznik;
        public Firma(String nazwa, String przedrostek)
        {
            this.nazwa = nazwa;
            this.przedrostek = przedrostek;
            this.licznik = 0;
        }

        public Firma(String nazwa, String przedrostek, int licznik)
        {
            this.nazwa = nazwa;
            this.przedrostek = przedrostek;
            this.licznik = licznik;
        }

    }
}
