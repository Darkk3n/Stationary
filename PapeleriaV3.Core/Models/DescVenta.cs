using System.Collections.Generic;

namespace PapeleriaV3.DA.Models
{
   public class DescVenta
   {
      public int DescVentaId { get; set; }
      public virtual Venta Venta { get; set; }
      public ICollection<Articulo> Articulos { get; set; }
      public virtual int VentaId { get; set; }
      public virtual int ArticuloId { get; set; }
   }
}