using System.Collections.Generic;
using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.BL
{
   public class ArticlesBL
   {
      public bool SaveOrUpdate(Articulo art)
      {
         var res = new ArticulosDA().SaveOrUpdate(art);
         return res;
      }

      public bool Delete(int key)
      {
         var res = new ArticulosDA().Delete(key);
         return res;
      }

      public List<ComboItem> GetUSB()
      {
         var res = new ArticulosDA().GetUSB();
         return res;
      }

      public List<ComboItem> GetMemorias()
      {
         var res = new ArticulosDA().GetMemorias();
         return res;
      }

      public List<ComboItem> GetAccesorios()
      {
         var res = new ArticulosDA().GetAccesorios();
         return res;
      }

      public decimal GetPrecio(int key)
      {
         var res = new ArticulosDA().GetPrice(key);
         return res;
      }
   }
}