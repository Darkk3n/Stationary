using System.Data.Entity.ModelConfiguration;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.EntityConfiguration
{
   public class DepartamentoConfiguration : EntityTypeConfiguration<Departamento>
   {
      public DepartamentoConfiguration()
      {
         HasKey(d => d.DepartamentoId);

         Property(d => d.Nombre)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("varchar");

         HasRequired(d => d.Categoria);
      }
   }
}