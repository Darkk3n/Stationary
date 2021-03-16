using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.BL
{
   public class SaleBL
   {
      public bool SaveOrUpdate(Venta vent)
      {
         var res = new VentasDA().SaveOrUpdate(vent);
         return res;
      }
   }
}