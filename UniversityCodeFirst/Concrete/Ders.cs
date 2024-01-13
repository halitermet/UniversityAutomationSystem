using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCodeFirst.Concrete
{
    public class Ders
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Kod { get; set; }
        public int Kredi { get; set; }
        
       public  List<Ogrenci> OgrenciList { get; set;}

        //kendi oluşturdugumuz many to many durmu için
        public List<OgrenciDers> OgrenciDers { get; set; }

    }
}
