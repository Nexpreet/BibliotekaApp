using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka {
    internal class ClanBiblioteke : Osoba{

           public string BrojClanskeKarte { get; set; }
           List<string> ListaPozajmljenihKnjiga = new List<string>();

            public void DodajKnjigu(string knjiga) {
                ListaPozajmljenihKnjiga.Add(knjiga);
            }

            public override void PrikaziDetalje() {
                base.PrikaziDetalje();

                Console.WriteLine("Broj clanske karte: " + BrojClanskeKarte);
            }

    }
}
