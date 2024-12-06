namespace Biblioteka {
    internal class Program {
        static void Main(string[] args) {
            
            Bibliotekar bibliotekar = new Bibliotekar();
            bibliotekar.Ime = "Marko";
            bibliotekar.Prezime = "Markovic";
            bibliotekar.DodajKnjiguNaPolicu("Knjiga 1");
            bibliotekar.DodajKnjiguNaPolicu("Knjiga 2");
            bibliotekar.DodajKnjiguNaPolicu("Knjiga 3");
            bibliotekar.PrikaziDetalje();
            bibliotekar.ObrisiKnjiguSaPolice("Knjiga 2");
            bibliotekar.PrikaziDetalje();

            foreach (string knjiga in bibliotekar.ListaKnjigaNaPolici) {
                Console.WriteLine(knjiga);
            }

            ClanBiblioteke clan = new ClanBiblioteke();
            clan.Ime = "Petar";
            clan.Prezime = "Petrovic";
            clan.BrojClanskeKarte = "123";
            clan.DodajKnjigu("Knjiga 1");
            clan.DodajKnjigu("Knjiga 2");
            clan.PrikaziDetalje();

        }
    }
}
