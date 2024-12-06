using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka {
    internal class Osoba {

        public string Ime { get; set; }
        public string Prezime { get; set; }

        public virtual void PrikaziDetalje() {
                Console.WriteLine("Ime: " + Ime);
                Console.WriteLine("Prezime: " + Prezime);
        }
    }
}
