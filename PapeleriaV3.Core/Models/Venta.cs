using System.Collections.Generic;

namespace PapeleriaV3.DA.Models
{
   public class Venta
   {
      public Venta()
      {
         DescVentas = new HashSet<DescVenta>();
      }
      public int VentaId { get; set; }
      public decimal SubTotal { get; set; }
      public decimal IVA { get; set; }
      public decimal Total { get; set; }
      public string FormaDePago { get; set; }
      public virtual Cliente Cliente { get; set; }
      public virtual int CveCliente { get; set; }
      public string NumTarjeta { get; set; }
      public string Banco { get; set; }
      public virtual ICollection<DescVenta> DescVentas { get; set; }
   }
}