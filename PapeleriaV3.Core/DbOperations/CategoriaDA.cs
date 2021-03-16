using System.Collections.Generic;
using System.Linq;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.DbOperations
{
   public class CategoriaDA
   {
      public bool SaveOrUpdate(Categoria cat)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            if (cat.CategoriaId == 0)
            {
               db.Categorias.Add(cat);
            }
            else
            {
               var catExistente = db.Categorias.SingleOrDefault(c => c.CategoriaId == cat.CategoriaId);
               catExistente.Nombre = cat.Nombre;
               catExistente.Departamentos = cat.Departamentos;
            }
            r = db.SaveChanges();
            if (r >= 1)
               return true;
            else
               return false;
         }
      }

      public bool Delete(Categoria cat)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            var itemToRemove = db.Categorias.Single(c => c.CategoriaId == cat.CategoriaId);
            db.Categorias.Remove(itemToRemove);
            r = db.SaveChanges();
            if (r >= 1)
               return true;
            else
               return false;
         }
      }

      public List<ComboItem> GetCategoriaDepto(int idDep)
      {
         List<ComboItem> lista = new List<ComboItem>();
         lista.Add(new ComboItem("--SELECCIONE--", 0));
         using (StationaryContext db = new StationaryContext())
         {
            var query = db.Categorias
               .Where(r => r.IdDepto == idDep)
               .Select(r => new { r.IdDepto, r.Nombre });

            foreach (var item in query)
            {
               lista.Add(new ComboItem(item.Nombre, item.IdDepto));
            }
         }
         return lista;
      }
   }
}