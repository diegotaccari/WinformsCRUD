using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsCRUD
{
    public class Productoc
    {
        public int Id { get; set; }
        public string Denominacion { get; set; }
        public decimal  PrecioVenta { get; set; }
        public decimal  PrecioCosto { get; set; }
        public  int  Stock { get; set; }

    }
}
