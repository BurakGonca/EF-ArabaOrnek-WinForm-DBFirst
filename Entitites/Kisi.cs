using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7mart2024.Entitites
{
    public class Kisi
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }


        public List<Araba> Arabalar { get; set; } // navigation prop.
        // dikkat 1-n iliski oldugu icin burayi Liste,ICollection vs. gibi koleksiyon hallerinde yazmaliyiz.

        //bir kisinin birden cok arabasi olur cümlesinin kod hali. kıps

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
