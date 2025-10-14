using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Gasto
    {
        public int id { get; set; }
        public DateTime fecha { get; set; } = DateTime.Now;
        public string descripcion { get; set; } = string.Empty;
        public decimal monto { get; set; }
        public bool eliminado { get; set; }
        public override string ToString()
        {
            return descripcion + " - " + monto.ToString("0.00");
        }
    }
}
