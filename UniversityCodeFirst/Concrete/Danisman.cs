using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCodeFirst.Concrete
{
    public class Danisman
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
}
