using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka {

    public interface IAdministrativniZadaci
    {
        public void DodajKnjiguNaPolicu(string knjiga) { }
        public void IzbrisiKnjiguSaPolice(string knjiga) { }
    }
}
