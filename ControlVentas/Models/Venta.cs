using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Venta
    {
        public int id { get; set; }
        [Required(ErrorMessage = "La fecha es obligatorio")]
        public DateTime fecha { get; set; } = DateTime.Now;
       
        [NotMapped]
        public decimal total => detalles?.Sum(d => d.subtotal) ?? 0;
        public ICollection<VentaDetalle>? detalles { get; set; } = new List<VentaDetalle>();
        public bool eliminado { get; set; } 
        public override string ToString()
        {
            return $"Venta {id} - {fecha.ToShortDateString()} - Total: {total.ToString("0.00")}";
        }
    }
}
