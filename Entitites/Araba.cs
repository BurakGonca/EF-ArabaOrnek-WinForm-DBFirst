using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7mart2024.Entitites
{
    public class Araba
    {

        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }


        //plaka-araba arasi 1-1 iliski var

        //kisi-araba arasi 1-n iliski var
        //(bir kisinin birden cok arabasi olabilir, bir arabanin bir sahibi vardir)

        //muhendis-araba arasi n-n iliski vardir
        //(bir mühendis bir cok arabadan sorumludur, bir arabanin da bir cok sorumlu muhendisi vardir)
        //cross table olusacak

        public int PlakaID { get; set; } //foreign key
        public Plaka Plaka { get; set; } //navigation property


        public int KisiID { get; set; } //foreign key
        public Kisi Kisi { get; set; } //navigation property



        public List<Muhendis> Muhendisler { get; set; } //araba-muhendis n-n iliski icin koleksiyon
                                                        //türünde her iki tarafa da navigation prop yaziyoruz


        



    }
}
