using System;
using System.Windows.Forms;

namespace PapeleriaV3
{
   public partial class frmMenu : Form
   {
      public frmMenu()
      {
         InitializeComponent();
      }

      private void btnArticulos_Click(object sender, EventArgs e)
      {
         frmPurchase compraArt = new frmPurchase();
         compraArt.ShowDialog();
         compraArt.Dispose();
      }

      private void btnClientes_Click(object sender, EventArgs e)
      {
         frmClients clientes = new frmClients();
         clientes.ShowDialog();
         clientes.Dispose();
      }

      private void btnDep_Click(object sender, EventArgs e)
      {
         frmDepartaments departamentos = new frmDepartaments();
         departamentos.ShowDialog();
         departamentos.Dispose();
      }

      private void btnCat_Click(object sender, EventArgs e)
      {
         frmCategories categorias = new frmCategories();
         categorias.ShowDialog();
         categorias.Dispose();
      }
   }
}