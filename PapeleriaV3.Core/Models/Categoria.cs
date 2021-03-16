using System.Collections.Generic;

namespace PapeleriaV3.DA.Models
{
   public class Categoria
   {
      public Categoria()
      {
         Departamentos = new HashSet<Departamento>();
         Articulos = new HashSet<Articulo>();
      }
      public int CategoriaId { get; set; }
      public string Nombre { get; set; }
      public virtual ICollection<Departamento> Departamentos { get; set; }
      public int IdDepto { get; set; }
      public virtual ICollection<Articulo> Articulos { get; set; }
   }
}