using System;
using System.Windows.Forms;
using PapeleriaV3.BL;
using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3
{
   public partial class frmArticles : Form
   {
      public frmArticles()
      {
         InitializeComponent();
      }

      private void frmArticulos_Load(object sender, EventArgs e)
      {
         cmbDep.DataSource = new DepartamentsBL().GetDepartamentos();
      }

      private void cmbDep_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cmbDep.SelectedIndex != 0)
         {
            ComboItem dep = (ComboItem)cmbDep.SelectedItem;
            cmbCat.DataSource = new CategoriaBL().GetCategoriaDepto(dep.intValue);
         }
         else
         {
            cmbCat.Items.Clear();
         }
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         if (cmbDep.SelectedIndex != 0 && cmbCat.SelectedIndex != 0 && txtNombre.Text != "" && txtPrecio.Text != "")
         {
            ComboItem dep = (ComboItem)cmbDep.SelectedItem;
            ComboItem cat = (ComboItem)cmbCat.SelectedItem;
            Articulo articulo = new Articulo();
            articulo.Nombre = txtNombre.Text;
            articulo.Precio = decimal.Parse(txtPrecio.Text);
            articulo.Departamento.DepartamentoId = dep.intValue;
            articulo.Categoria.CategoriaId = cat.intValue;
            bool res = new ArticlesBL().SaveOrUpdate(articulo);
            if (res)
            {
               MessageBox.Show("Articulo guardado correctamente", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Close();
            }
         }
         else
            MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Revise los datos.", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
   }
}