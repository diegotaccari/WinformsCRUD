using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsCRUD
{
    public class Ventas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string ProductoVendido { get; set; }
        public double CantidadVendida { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int ProductoId { get; set; }

        public double TotalVenta { get; set; }


    }
}
