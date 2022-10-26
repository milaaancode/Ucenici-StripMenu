using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UceniciForma
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }

        public Ucenik(string i, string p, string br)
        {
            Ime = i;
            Prezime = p;
            BrojTelefona = br;
        }
    }
}
