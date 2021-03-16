using System.Data.Entity.ModelConfiguration;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.EntityConfiguration
{
   public class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
   {
      public CategoriaConfiguration()
      {
         HasKey(c => c.CategoriaId);

         Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(50);

         HasMany(c => c.Departamentos)
            .WithRequired(c => c.Categoria);

         HasMany(c => c.Articulos)
            .WithRequired(a => a.Categoria);
      }
   }
}