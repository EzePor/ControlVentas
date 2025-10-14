using ControlVentas.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Producto
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El rubro del producto es obligatorio")]
        public RubroEnum Rubro { get; set; }
        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        public decimal precio { get; set; }
        [NotMapped]
        public string precioformateado
        {
            get { return precio.ToString("0.00"); }
            set
            {
                if (decimal.TryParse(value, out var parsedValue))
                {
                    precio = Math.Round(parsedValue, 2);
                }
            }
        }
        public bool activo { get; set; }=true;
        public bool eliminado { get; set; }
        public override string ToString()
        {
                 return nombre;
        }
    }
}
