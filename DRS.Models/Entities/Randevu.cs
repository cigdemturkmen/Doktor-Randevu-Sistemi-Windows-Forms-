using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRS.Models.Entities
{
    public class Randevu
    {
        public Hasta Hasta { get; set; }
        public Doktor  Doktor { get; set; }
        public DateTime RandevuTarihi { get; set; }
    }
}
