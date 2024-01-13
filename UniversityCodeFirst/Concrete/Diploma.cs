using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCodeFirst.Concrete
{
    public class Diploma
    {
        public int Id { get; set; }
        public string No { get; set; }
        public DateTime Tarih { get; set; }
        //navigation property
        public Ogrenci Ogrenci { get; set; }

    }
}
