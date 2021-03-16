using System;
using System.Windows.Forms;
using PapeleriaV3.BL;
using PapeleriaV3.DA.DbOperations;
using PapeleriaV3.DA.Models;

namespace PapeleriaV3
{
   public partial class frmInformatics : Form
   {
      decimal tot;
      public frmInformatics()
      {
         InitializeComponent();
      }

      private void frmInformatica_Load(object sender, EventArgs e)
      {
         cmbAcc.DataSource = new ArticlesBL().GetAccesorios();
         cmbCliente.DataSource = new ClientsBL().GetClientes();
         cmbTel.DataSource = new ArticlesBL().GetMemorias();
         cmbUSB.DataSource = new ArticlesBL().GetUSB();
      }

      private void btnMenu_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void btnAgrega_Click(object sender, EventArgs e)
      {
         if (cmbUSB.SelectedIndex != 0)
         {
            ComboItem art = (ComboItem)cmbUSB.SelectedItem;
            tot += new ArticlesBL().GetPrecio(art.intValue);
            lbArticulos.Items.Add(art.Name);
            txtSubTotal.Text = tot.ToString();
         }

         if (cmbAcc.SelectedIndex != 0)
         {
            ComboItem art = (ComboItem)cmbUSB.SelectedItem;
            tot += new ArticlesBL().GetPrecio(art.intValue);
            lbArticulos.Items.Add(art.Name);
            txtSubTotal.Text = tot.ToString();
         }

         if (cmbTel.SelectedIndex != 0)
         {
            ComboItem art = (ComboItem)cmbUSB.SelectedItem;
            tot += new ArticlesBL().GetPrecio(art.intValue);
            lbArticulos.Items.Add(art.Name);
            txtSubTotal.Text = tot.ToString();
         }
         cmbAcc.SelectedIndex = 0;
         cmbTel.SelectedIndex = 0;
         cmbUSB.SelectedIndex = 0;
      }

      private void btnQuitar_Click(object sender, EventArgs e)
      {
         if (lbArticulos.Items.Count >= 1)
         {
            try
            {
               tot -= new ArticlesBL().GetPrecio(int.Parse(lbArticulos.SelectedItem.ToString()));
               lbArticulos.Items.RemoveAt(lbArticulos.SelectedIndex);
               txtSubTotal.Text = tot.ToString();
            }
            catch (Exception)
            {
               MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Seleccione un Articulo", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
         }
      }

      private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
      {
         if (rbEfectivo.Checked)
         {
            gpbTarj.Visible = false;
            rbTarjeta.Checked = false;
         }
      }

      private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
      {
         if (rbTarjeta.Checked)
         {
            gpbTarj.Visible = true;
            rbEfectivo.Checked = false;
         }
      }

      private void txtTotal_TextChanged(object sender, EventArgs e)
      {
         decimal subt = decimal.Parse(txtSubTotal.Text);
         decimal iva = subt * 0.16m;
         decimal total = subt + (subt * 0.16m);
         txtIVA.Text = iva.ToString();
         txtTotal.Text = total.ToString();
      }

      private void btnCapt_Click(object sender, EventArgs e)
      {
         if (cmbCliente.SelectedIndex != 0)
         {
            bool r;
            ComboItem cl = (ComboItem)cmbCliente.SelectedItem;
            Venta vent = new Venta();
            vent.Cliente.ClienteId = cl.intValue;
            vent.SubTotal = decimal.Parse(txtSubTotal.Text);
            vent.Total = decimal.Parse(txtTotal.Text);
            if (rbEfectivo.Checked)
            {
               vent.FormaDePago = "Efectivo";
            }
            else
            {
               if (txtBanco.Text != "" & txtTarj.Text != "")
               {
                  vent.FormaDePago = "Tarjeta";
                  vent.NumTarjeta = txtTarj.Text;
                  vent.Banco = txtBanco.Text;
               }
               else
               {
                  MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Debe llenar todos los campos antes de continuar.", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
            }
            r = new SaleBL().SaveOrUpdate(vent);
            if (r)
            {
               MessageBox.Show("La venta fue capturada correctamente", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         else
         {
            MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Seleccione un Cliente.", "Papeleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}