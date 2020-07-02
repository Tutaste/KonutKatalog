using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    public class Villa : Konut
    {
        public override string KonutTipi
        {
            get { return "Villa"; }
        }

        public string BahceAln { get; set; }
        public string Garaj { get; set; }
        public string Tip { get; set; }
    }
}
