using System.Collections.Generic;
using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.BL
{
   public class CategoriaBL
   {
      public bool SaveOrUpdate(Categoria cat)
      {
         var res = new CategoriaDA().SaveOrUpdate(cat);
         return res;
      }

      public bool Delete(Categoria cat)
      {
         var res = new CategoriaDA().Delete(cat);
         return res;
      }

      public List<ComboItem> GetCategoriaDepto(int idDep)
      {
         var res = new CategoriaDA().GetCategoriaDepto(idDep);
         return res;
      }
   }
}