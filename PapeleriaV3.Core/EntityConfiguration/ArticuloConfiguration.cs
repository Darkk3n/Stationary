using System.Data.Entity.ModelConfiguration;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.EntityConfiguration
{
   public class ArticuloConfiguration : EntityTypeConfiguration<Articulo>
   {
      public ArticuloConfiguration()
      {
         HasKey(a => a.ArticuloId);
         Property(a => a.Nombre).IsRequired().HasMaxLength(50);
         Property(a => a.Precio).IsRequired();
      }
   }
}