using System.Linq;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3.DA.DbOperations
{
   public class VentasDA
   {
      public bool SaveOrUpdate(Venta vent)
      {
         int r;
         using (StationaryContext db = new StationaryContext())
         {
            if (vent.VentaId == 0)
               db.Ventas.Add(vent);
            else
            {
               var ventaExistente = db.Ventas.Single(v => v.VentaId == vent.VentaId);
               ventaExistente.CveCliente = vent.CveCliente;
               ventaExistente.Banco = vent.Banco;
               ventaExistente.Cliente = vent.Cliente;
               ventaExistente.FormaDePago = vent.FormaDePago;
               ventaExistente.IVA = vent.IVA;
               ventaExistente.NumTarjeta = vent.NumTarjeta;
               ventaExistente.SubTotal = vent.SubTotal;
               ventaExistente.Total = vent.Total;
            }
            r = db.SaveChanges();
         }
         if (r >= 1)
            return true;
         else
            return false;
      }
   }
}