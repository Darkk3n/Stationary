using System;
using System.Windows.Forms;
using PapeleriaV3.BL;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3
{
   public partial class frmClients : Form
   {
      public frmClients()
      {
         InitializeComponent();
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         foreach (var item in Controls)
         {
            if (item is TextBox)
            {
               var t = (TextBox)item;
               if (t.Text == "")
               {
                  MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Llene todos los campos antes de continuar", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
            }
         }
         Cliente cli = new Cliente();
         cli.Nombre = txtNombre.Text;
         cli.Direccion = txtDir.Text;
         cli.Telefono = txtTel.Text;
         bool r = new ClientsBL().SaveOrUpdate(cli);
         if (r)
            MessageBox.Show("Cliente almacenado correctamente", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
   }
}