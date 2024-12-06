using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka {
    internal class Bibliotekar : Osoba, IAdministrativniZadaci {

        public List<string> ListaKnjigaNaPolici = new List<string>();

        public void DodajKnjiguNaPolicu(string knjiga) {

            ListaKnjigaNaPolici.Add(knjiga);
        }

        public void ObrisiKnjiguSaPolice(string knjiga) {

            ListaKnjigaNaPolici.Remove(knjiga);
        }

        public override void PrikaziDetalje() {
            base.PrikaziDetalje();
            Console.WriteLine("Broj knjiga na polici: " + ListaKnjigaNaPolici.Count);
        }
    }
}
