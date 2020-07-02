using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    public class Daire : Konut
    {
        public override string KonutTipi
        {
            get { return "Daire"; }
        }
        public string Kat { get; set; }
        public string Balkon { get; set; }
        public string Asansor { get; set; }
    }
}
