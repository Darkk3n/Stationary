using System.Collections.Generic;

namespace PapeleriaV3.DA.Models
{
   public class Cliente
   {
      public int ClienteId { get; set; }
      public string Nombre { get; set; }
      public string Direccion { get; set; }
      public string Telefono { get; set; }
      public ICollection<Venta> Ventas { get; set; }
   }
}