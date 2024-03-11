using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7mart2024.Entitites
{
    public class Plaka
    {
        public int PlakaID { get; set; }
        public string Numara { get; set; }


        public Araba Araba { get; set; } //navigation prop
        //araba-plaka arasinda 1-1 iliski var o yüzden bir tarafa hem "navi. prop. + fk " koyduk, diger tarafa sadece "navi prop koyduk "


        public override string ToString() //gorunmesi icin toString i override ediyoruz
        {
            return Numara;
        }

        
    }
}
