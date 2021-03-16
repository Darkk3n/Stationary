using System.Collections.Generic;
using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.BL
{
   public class DepartamentsBL
   {
      public bool SaveOrUpdate(Departamento dep)
      {
         var res = new DepartamentosDA().SaveOrUpdate(dep);
         return res;
      }

      public bool Delete(int key)
      {
         var res = new DepartamentosDA().Delete(key);
         return res;
      }

      public List<ComboItem> GetDepartamentos()
      {
         var res = new DepartamentosDA().GetDepartamentos();
         return res;
      }
   }
}