using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCodeFirst.Concrete
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi {  get; set; }
        public string Numara { get; set; }

        public int DiplomaId { get; set; }
        public Diploma Diploma { get; set; }
        //1-m
        //foreign key
        public int DanismanId { get; set; }
        //navigation property
        public Danisman Danisman { get; set; }
        public List<Ders> Dersler { get; set; }

        //kendi oluşturdugumuz many to many durmu için
        public List<OgrenciDers> OgrenciDers { get; set; }

    }
}
