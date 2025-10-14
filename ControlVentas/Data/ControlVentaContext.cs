using ControlVentas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Data
{
    public class ControlVentaContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\Control de Ventas\ControlVentas\ControlVentas\controlventas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasIndex(p => p.nombre);
            modelBuilder.Entity<Producto>().Property(p => p.precio).HasPrecision(18, 2);
            modelBuilder.Entity<Gasto>().Property(g => g.monto).HasPrecision(18, 2);

        }
    }
}
