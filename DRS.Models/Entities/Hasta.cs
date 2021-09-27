using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRS.Models.Entities
{
    public class Hasta : Base
    {
        public double Boy { get; set; }
        public double Kilo { get; set; }
        private int myVar;

        private int _yas;// field. asıl ram'e çıkan bu. 

        public int Yas
        {
            get 
            {
                var fark = DateTime.Now - DogumTarihi;
                var yas = fark.Days / 365;
                return _yas; 
            } 

            //set tanımlanmadı çünkü yaş property'sine dışarıdan giriş yapılmamalı
        }

    }
}
