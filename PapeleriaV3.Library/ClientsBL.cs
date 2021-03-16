using System.Collections.Generic;
using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.BL
{
   public class ClientsBL
   {
      public bool SaveOrUpdate(Cliente cli)
      {
         var res = new ClientesDA().SaveOrUpdate(cli);
         return res;
      }

      public bool Delete(int key)
      {
         var res = new ClientesDA().Delete(key);
         return res;
      }

      public List<ComboItem> GetClientes()
      {
         var res = new ClientesDA().GetClientes();
         return res;
      }
   }
}