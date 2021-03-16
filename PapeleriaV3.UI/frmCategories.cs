using System;
using System.Windows.Forms;
using PapeleriaV3.BL;
using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3
{
   public partial class frmCategories : Form
   {
      public frmCategories()
      {
         InitializeComponent();
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         bool r;
         if (txtCat.Text != "" && cmbDepto.SelectedIndex != 0)
         {
            Categoria cat = new Categoria();
            ComboItem dep = (ComboItem)cmbDepto.SelectedItem;
            cat.Nombre = txtCat.Text;
            cat.IdDepto = dep.intValue;
            try
            {
               r = new CategoriaBL().SaveOrUpdate(cat);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocurrio un error: " + Environment.NewLine + ex.Message, "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            if (r)
            {
               MessageBox.Show("Categoría: " + txtCat.Text + " almacenado correctamente", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
      }

      private void frmCategorias_Load(object sender, EventArgs e)
      {
         cmbDepto.DataSource = new DepartamentsBL().GetDepartamentos();
      }
   }
}