using System.Data.Entity.ModelConfiguration;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.EntityConfiguration
{
   public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
   {
      public ClienteConfiguration()
      {
         HasKey(c => c.ClienteId);

         HasMany(c => c.Ventas)
            .WithRequired(v => v.Cliente);

         Property(c => c.Nombre)
            .HasMaxLength(50)
            .HasColumnType("varchar");

         Property(c => c.Direccion)
            .HasMaxLength(200)
            .HasColumnType("varchar");

         Property(c => c.Telefono)
            .HasMaxLength(15)
            .HasColumnType("varchar");
      }
   }
}