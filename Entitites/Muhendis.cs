using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7mart2024.Entitites
{
    public class Muhendis
    {
        public int MuhendisID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }


        public List<Araba> Arabalar { get; set; } //araba-muhendis n-n iliski icin koleksiyon
                                                  //türünde her iki tarafa da navigation prop yaziyoruz


        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }

    }
}
