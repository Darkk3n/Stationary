using System.Windows.Forms;

namespace PapeleriaV3
{
   public partial class frmPurchase : Form
   {
      public frmPurchase()
      {
         InitializeComponent();
      }

      private void btnContinuar_Click(object sender, System.EventArgs e)
      {
         if (rbInformatica.Checked == true)
         {
            frmInformatics inf = new frmInformatics();
            inf.ShowDialog();
            inf.Dispose();
         }
      }

      private void btnAgregaArt_Click(object sender, System.EventArgs e)
      {
         frmArticles art = new frmArticles();
         art.ShowDialog();
         art.Dispose();
      }
   }
}