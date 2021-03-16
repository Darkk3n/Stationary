using System;
using System.Windows.Forms;
using PapeleriaV3.BL;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3
{
   public partial class frmDepartaments : Form
   {
      public frmDepartaments()
      {
         InitializeComponent();
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         if (txtDepto.Text != "")
         {
            Departamento dep = new Departamento();
            dep.Nombre = txtDepto.Text;
            bool r = new DepartamentsBL().SaveOrUpdate(dep);
            if (r)
            {
               MessageBox.Show("Departamento: " + txtDepto.Text + " almacenado correctamente", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         else
            MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Escriba un nombre de Departamento", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
   }
}