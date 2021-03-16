using System.Collections.Generic;

namespace PapeleriaV3.DA.Models
{
   public class Departamento
   {
      public Departamento()
      {
         Articulos = new HashSet<Articulo>();
      }
      public int DepartamentoId { get; set; }
      public string Nombre { get; set; }
      public virtual ICollection<Articulo> Articulos { get; set; }
      public virtual Categoria Categoria { get; set; }
   }
}