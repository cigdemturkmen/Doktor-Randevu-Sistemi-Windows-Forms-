using DRS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRS.Models.Entities
{
    public class Doktor : Base
    {
        public Brans Brans { get; set; }
        public string MezunOlduguOkul { get; set; }
        public Unvan Unvan { get; set; }
    }
}
