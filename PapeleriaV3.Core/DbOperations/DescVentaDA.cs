using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.DbOperations
{
   public class DescVentaDA
   {
      public bool Save(DescVenta desc)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            db.DescVentas.Add(desc);
            r = db.SaveChanges();
         }
         if (r >= 1)
            return true;
         else
            return false;
      }
   }
}