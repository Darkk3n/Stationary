using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using PapeleriaV3.DA.EntityConfiguration;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA
{
   public class StationaryContext : DbContext
   {
      public virtual DbSet<Articulo> Articulos { get; set; }
      public virtual DbSet<Categoria> Categorias { get; set; }
      public virtual DbSet<Cliente> Clientes { get; set; }
      public virtual DbSet<Departamento> Departamentos { get; set; }
      public virtual DbSet<Venta> Ventas { get; set; }
      public virtual DbSet<DescVenta> DescVentas { get; set; }

      public StationaryContext() : base("PapeleriaV3")
      {

      }
      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Configurations.Add(new EntityTypeConfiguration<ArticuloConfiguration>());
         modelBuilder.Configurations.Add(new EntityTypeConfiguration<CategoriaConfiguration>());
         modelBuilder.Configurations.Add(new EntityTypeConfiguration<DepartamentoConfiguration>());
         modelBuilder.Configurations.Add(new EntityTypeConfiguration<ClienteConfiguration>());
         modelBuilder.Configurations.Add(new EntityTypeConfiguration<DescVentaConfiguration>());
         modelBuilder.Configurations.Add(new EntityTypeConfiguration<VentasConfiguration>());
      }
   }
}