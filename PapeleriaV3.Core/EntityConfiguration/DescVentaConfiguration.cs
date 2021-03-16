using System.Data.Entity.ModelConfiguration;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.EntityConfiguration
{
   public class DescVentaConfiguration : EntityTypeConfiguration<DescVenta>
   {
      public DescVentaConfiguration()
      {
         HasKey(d => d.DescVentaId);

         HasRequired(d => d.Venta)
            .WithMany(v => v.DescVentas)
            .HasForeignKey(d => d.VentaId);

         HasMany(d => d.Articulos)
            .WithMany(a => a.DescVentas);
      }
   }
}