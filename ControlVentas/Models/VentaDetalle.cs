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
    public class VentaDetalle
    {

        public int id { get; set; }
        [Required(ErrorMessage = "El producto es obligatorio")]
        public int ventaId { get; set; }
        public Venta venta { get; set; } = null!;
        public int productoId { get; set; }
        public Producto producto { get; set; } = null!;
        [Required(ErrorMessage = "La cantidad es obligatorio")]
        public int cantidad { get; set; }
        [Required(ErrorMessage = "El precio unitario es obligatorio")]
        public decimal precioUnitario { get; set; }
        [NotMapped]
        public decimal subtotal => cantidad * precioUnitario;
        
        [Required(ErrorMessage = "La forma de pago es obligatorio")]
        public FormaPagoEnum formaPagoEnum { get; set; }
        public bool eliminado { get; set; }

        public override string ToString()
        {
            return $"{producto.nombre} - Cantidad: {cantidad}, Precio Unitario: {precioUnitario.ToString("0.00")}, Subtotal: {subtotal.ToString("0.00")}, Forma de Pago: {formaPagoEnum}";
        }
    }
}
