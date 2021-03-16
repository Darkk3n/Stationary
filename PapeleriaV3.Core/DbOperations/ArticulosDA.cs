using System.Collections.Generic;
using System.Linq;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.DbOperations
{
   public class ArticulosDA
   {
      public bool SaveOrUpdate(Articulo art)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            if (art.ArticuloId == 0)
            {
               db.Articulos.Add(art);
            }
            else
            {
               var articuloExistente = db.Articulos.SingleOrDefault(a => a.ArticuloId == art.ArticuloId);
               articuloExistente.Nombre = art.Nombre;
               articuloExistente.Precio = art.Precio;
               articuloExistente.Departamento = art.Departamento;
               articuloExistente.Categoria = art.Categoria;
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
            var remove = db.Articulos.SingleOrDefault(a => a.ArticuloId == key);
            db.Articulos.Remove(remove);
            r = db.SaveChanges();
         }
         if (r >= 1)
            return true;
         else
            return false;
      }

      public List<ComboItem> GetUSB()
      {
         List<ComboItem> lista = new List<ComboItem>();
         lista.Add(new ComboItem("--SELECCIONE--", 0));
         using (StationaryContext db = new StationaryContext())
         {
            var query = db.Articulos.
               Where(r => r.Categoria.CategoriaId == 1 && r.Departamento.DepartamentoId == 1)
               .Select(r => (new { r.ArticuloId, r.Nombre }))
               .OrderBy(r => r.ArticuloId);
            foreach (var item in query)
            {
               lista.Add(new ComboItem(item.Nombre, item.ArticuloId));
            }
         }
         return lista;
      }

      public List<ComboItem> GetMemorias()
      {
         List<ComboItem> lista = new List<ComboItem>();
         lista.Add(new ComboItem("--SELECCIONE--", 0));
         using (StationaryContext db = new StationaryContext())
         {
            var query = db.Articulos.
               Where(r => r.Categoria.CategoriaId == 1 && r.Departamento.DepartamentoId == 2)
               .Select(r => (new { r.ArticuloId, r.Nombre }))
               .OrderBy(r => r.ArticuloId);
            foreach (var item in query)
            {
               lista.Add(new ComboItem(item.Nombre, item.ArticuloId));
            }
         }
         return lista;
      }

      public List<ComboItem> GetAccesorios()
      {
         List<ComboItem> lista = new List<ComboItem>();
         lista.Add(new ComboItem("--SELECCIONE--", 0));
         using (StationaryContext db = new StationaryContext())
         {
            var query = db.Articulos.
               Where(r => r.Categoria.CategoriaId == 1 && r.Departamento.DepartamentoId == 3)
               .Select(r => (new { r.ArticuloId, r.Nombre }))
               .OrderBy(r => r.ArticuloId);
            foreach (var item in query)
            {
               lista.Add(new ComboItem(item.Nombre, item.ArticuloId));
            }
         }
         return lista;
      }

      public decimal GetPrice(int key)
      {
         using (StationaryContext db = new StationaryContext())
         {
            return db.Articulos.Single(r => r.ArticuloId == key).Precio;
         }
      }
   }
}