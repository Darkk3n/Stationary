namespace PapeleriaV3.DA.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class InitialModel : DbMigration
   {
      public override void Up()
      {
         CreateTable(
             "dbo.Articulos",
             c => new
             {
                ArticuloId = c.Int(nullable: false, identity: true),
                Nombre = c.String(),
                Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                Categoria_CategoriaId = c.Int(),
                Departamento_DepartamentoId = c.Int(),
             })
             .PrimaryKey(t => t.ArticuloId)
             .ForeignKey("dbo.Categorias", t => t.Categoria_CategoriaId)
             .ForeignKey("dbo.Departamentos", t => t.Departamento_DepartamentoId)
             .Index(t => t.Categoria_CategoriaId)
             .Index(t => t.Departamento_DepartamentoId);

         CreateTable(
             "dbo.Categorias",
             c => new
             {
                CategoriaId = c.Int(nullable: false, identity: true),
                Nombre = c.String(),
                IdDepto = c.Int(nullable: false),
             })
             .PrimaryKey(t => t.CategoriaId);

         CreateTable(
             "dbo.Departamentos",
             c => new
             {
                DepartamentoId = c.Int(nullable: false, identity: true),
                Nombre = c.String(),
                Categoria_CategoriaId = c.Int(),
             })
             .PrimaryKey(t => t.DepartamentoId)
             .ForeignKey("dbo.Categorias", t => t.Categoria_CategoriaId)
             .Index(t => t.Categoria_CategoriaId);

         CreateTable(
             "dbo.DescVentas",
             c => new
             {
                DescVentaId = c.Int(nullable: false, identity: true),
                VentaId = c.Int(nullable: false),
                ArticuloId = c.Int(nullable: false),
             })
             .PrimaryKey(t => t.DescVentaId)
             .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
             .Index(t => t.VentaId);

         CreateTable(
             "dbo.Ventas",
             c => new
             {
                VentaId = c.Int(nullable: false, identity: true),
                SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                IVA = c.Decimal(nullable: false, precision: 18, scale: 2),
                Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                FormaDePago = c.String(),
                CveCliente = c.Int(nullable: false),
                NumTarjeta = c.String(),
                Banco = c.String(),
                Cliente_ClienteId = c.Int(),
             })
             .PrimaryKey(t => t.VentaId)
             .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
             .Index(t => t.Cliente_ClienteId);

         CreateTable(
             "dbo.Clientes",
             c => new
             {
                ClienteId = c.Int(nullable: false, identity: true),
                Nombre = c.String(),
                Direccion = c.String(),
                Telefono = c.String(),
             })
             .PrimaryKey(t => t.ClienteId);

         CreateTable(
             "dbo.DescVentaArticulos",
             c => new
             {
                DescVenta_DescVentaId = c.Int(nullable: false),
                Articulo_ArticuloId = c.Int(nullable: false),
             })
             .PrimaryKey(t => new { t.DescVenta_DescVentaId, t.Articulo_ArticuloId })
             .ForeignKey("dbo.DescVentas", t => t.DescVenta_DescVentaId, cascadeDelete: true)
             .ForeignKey("dbo.Articulos", t => t.Articulo_ArticuloId, cascadeDelete: true)
             .Index(t => t.DescVenta_DescVentaId)
             .Index(t => t.Articulo_ArticuloId);

      }

      public override void Down()
      {
         DropForeignKey("dbo.DescVentas", "VentaId", "dbo.Ventas");
         DropForeignKey("dbo.Ventas", "Cliente_ClienteId", "dbo.Clientes");
         DropForeignKey("dbo.DescVentaArticulos", "Articulo_ArticuloId", "dbo.Articulos");
         DropForeignKey("dbo.DescVentaArticulos", "DescVenta_DescVentaId", "dbo.DescVentas");
         DropForeignKey("dbo.Departamentos", "Categoria_CategoriaId", "dbo.Categorias");
         DropForeignKey("dbo.Articulos", "Departamento_DepartamentoId", "dbo.Departamentos");
         DropForeignKey("dbo.Articulos", "Categoria_CategoriaId", "dbo.Categorias");
         DropIndex("dbo.DescVentaArticulos", new[] { "Articulo_ArticuloId" });
         DropIndex("dbo.DescVentaArticulos", new[] { "DescVenta_DescVentaId" });
         DropIndex("dbo.Ventas", new[] { "Cliente_ClienteId" });
         DropIndex("dbo.DescVentas", new[] { "VentaId" });
         DropIndex("dbo.Departamentos", new[] { "Categoria_CategoriaId" });
         DropIndex("dbo.Articulos", new[] { "Departamento_DepartamentoId" });
         DropIndex("dbo.Articulos", new[] { "Categoria_CategoriaId" });
         DropTable("dbo.DescVentaArticulos");
         DropTable("dbo.Clientes");
         DropTable("dbo.Ventas");
         DropTable("dbo.DescVentas");
         DropTable("dbo.Departamentos");
         DropTable("dbo.Categorias");
         DropTable("dbo.Articulos");
      }
   }
}
