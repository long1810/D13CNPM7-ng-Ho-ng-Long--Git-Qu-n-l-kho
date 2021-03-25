using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_GT1.Model
{
    public class hang
    {
        public string ma;
        public string ten;
        public int soluong;
        public string loai;
         public string nsx;
         public string tinhtrang;
         public int gia;

        //public string mahang { get; set; }
        //public string ten { get; set; }
        //public int soluong { get; set; }
        //public string loai { get; set; }
        //public string nsx { get; set; }
        //public string tinhtrang { get; set; }

         public hang()
         {
             ma = "";
             ten = "";
             soluong = 0;
             loai = "";
             nsx = "";
             tinhtrang ="";
             gia = 0;

         }
         public hang(string m, string t, int so, string l, string n, string ti,int g)
         {
             ma = m;
             ten = t;
             soluong = so;
             loai = l;
             nsx = n;
             tinhtrang = ti;
             g = gia;
         }
    }
}
