using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Katalog
{
    public class Konut
    {
        public virtual string KonutTipi
        {
            get;
        }
        public string Alan { get; set; }

        public string Fiyat { get; set; }

    }
}
