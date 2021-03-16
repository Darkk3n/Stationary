using System.Collections.Generic;
using System.Linq;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.DbOperations
{
   public class DepartamentosDA
   {
      public bool SaveOrUpdate(Departamento dep)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            if (dep.DepartamentoId == 0)
               db.Departamentos.Add(dep);
            else
            {
               var deptoExistente = db.Departamentos.Single(d => d.DepartamentoId == dep.DepartamentoId);
               deptoExistente.Nombre = dep.Nombre;
               deptoExistente.Categoria = dep.Categoria;
            }
            r = db.SaveChanges();
            if (r >= 1)
               return true;
            else
               return false;
         }
      }

      public bool Delete(int key)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            var itemToRemove = db.Departamentos.Single(c => c.DepartamentoId == key);
            db.Departamentos.Remove(itemToRemove);
            r = db.SaveChanges();
         }
         if (r >= 1)
            return true;
         else
            return false;
      }

      public List<ComboItem> GetDepartamentos()
      {
         List<ComboItem> lista = new List<ComboItem>();
         lista.Add(new ComboItem("--SELECCIONE--", 0));
         using (StationaryContext db = new StationaryContext())
         {
            var query = db.Departamentos.Select(r => new { r.DepartamentoId, r.Nombre });
            foreach (var item in query)
            {
               lista.Add(new ComboItem(item.Nombre, item.DepartamentoId));
            }
         }
         return lista;
      }
   }
}