using System.Collections.Generic;
using System.Linq;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.DbOperations
{
   public class ClientesDA
   {
      public bool SaveOrUpdate(Cliente cli)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            if (cli.ClienteId == 0)
               db.Clientes.Add(cli);
            else
            {
               var clienteExistente = db.Clientes.Single(c => c.ClienteId == cli.ClienteId);
               clienteExistente.Nombre = cli.Nombre;
               clienteExistente.Direccion = cli.Direccion;
               clienteExistente.Telefono = cli.Telefono;
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
            var itemToRemove = db.Clientes.Single(c => c.ClienteId == key);
            db.Clientes.Remove(itemToRemove);
            r = db.SaveChanges();
         }
         if (r >= 1)
            return true;
         else
            return false;
      }

      public List<ComboItem> GetClientes()
      {
         List<ComboItem> lista = new List<ComboItem>();
         lista.Add(new ComboItem("--SELECCIONE--", 0));
         using (StationaryContext db = new StationaryContext())
         {
            var query = db.Clientes.Select(r => new { r.ClienteId, r.Nombre });
            foreach (var item in query)
            {
               lista.Add(new ComboItem(item.Nombre, item.ClienteId));
            }
         }
         return lista;
      }
   }
}