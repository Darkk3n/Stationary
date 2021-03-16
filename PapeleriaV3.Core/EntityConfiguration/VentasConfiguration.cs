using System.Data.Entity.ModelConfiguration;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.EntityConfiguration
{
   public class VentasConfiguration : EntityTypeConfiguration<Venta>
   {
      public VentasConfiguration()
      {
         HasKey(v => v.VentaId);

         HasMany(v => v.DescVentas)
            .WithRequired(d => d.Venta);

         HasRequired(v => v.Cliente)
            .WithMany(c => c.Ventas)
            .HasForeignKey(c => c.CveCliente);

         Property(v => v.FormaDePago)
            .HasColumnType("varchar")
            .HasMaxLength(30);

         Property(v => v.NumTarjeta)
            .HasColumnType("varchar")
            .HasMaxLength(30);

         Property(v => v.Banco)
            .HasColumnType("varchar")
            .HasMaxLength(30);
      }
   }
}