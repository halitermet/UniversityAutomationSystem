using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCodeFirst.Concrete
{
    //eskisini silmemek için başka isimde bu tabloyu oluşturduk iki uygulamayıda görebiliriz.
    public class OgrenciDers
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }

        public int DersId { get; set; }
        public Ders Ders { get; set; }

        public int Not { get; set; }



    }
}
