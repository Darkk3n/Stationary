using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.BL
{
   public class SellDetailBL
   {
      public bool Save(DescVenta desc)
      {
         var res = new DescVentaDA().Save(desc);
         return res;
      }
   }
}