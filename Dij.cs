using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dij
    {
        string evszam;
        string tipus;
        string keresztNev;
        string vezetekNev;

        public Dij(string[] adatok)
        {
            this.evszam = adatok[0];
            this.tipus = adatok[1];
            this.keresztNev = adatok[2];
            this.vezetekNev = adatok[3];
        }
        public string Evszam { get => evszam; set => evszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string KeresztNev { get => keresztNev; set => keresztNev = value; }
        public string VezetekNev { get => vezetekNev; set => vezetekNev = value; }
    }
}
