using System.Collections.Generic;

namespace PapeleriaV3.DA.Models
{
   public class Articulo
   {
      public int ArticuloId { get; set; }
      public string Nombre { get; set; }
      public decimal Precio { get; set; }

      public virtual Departamento Departamento { get; set; }
      public virtual Categoria Categoria { get; set; }
      public virtual ICollection<DescVenta> DescVentas { get; set; }
   }
}