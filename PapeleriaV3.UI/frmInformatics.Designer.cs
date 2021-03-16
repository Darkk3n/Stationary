namespace PapeleriaV3
{
   partial class frmInformatics
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.gpbPago = new System.Windows.Forms.GroupBox();
         this.txtIVA = new System.Windows.Forms.TextBox();
         this.label12 = new System.Windows.Forms.Label();
         this.btnCapt = new System.Windows.Forms.Button();
         this.gpbTarj = new System.Windows.Forms.GroupBox();
         this.txtBanco = new System.Windows.Forms.TextBox();
         this.txtTarj = new System.Windows.Forms.TextBox();
         this.label11 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.rbTarjeta = new System.Windows.Forms.RadioButton();
         this.rbEfectivo = new System.Windows.Forms.RadioButton();
         this.txtTotal = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.cmbCliente = new System.Windows.Forms.ComboBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtSubTotal = new System.Windows.Forms.TextBox();
         this.btnMenu = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.cmbAcc = new System.Windows.Forms.ComboBox();
         this.cmbTel = new System.Windows.Forms.ComboBox();
         this.cmbUSB = new System.Windows.Forms.ComboBox();
         this.btnAgrega = new System.Windows.Forms.Button();
         this.btnPagar = new System.Windows.Forms.Button();
         this.btnQuitar = new System.Windows.Forms.Button();
         this.lbArticulos = new System.Windows.Forms.ListBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.gpbPago.SuspendLayout();
         this.gpbTarj.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // gpbPago
         // 
         this.gpbPago.Controls.Add(this.txtIVA);
         this.gpbPago.Controls.Add(this.label12);
         this.gpbPago.Controls.Add(this.btnCapt);
         this.gpbPago.Controls.Add(this.gpbTarj);
         this.gpbPago.Controls.Add(this.groupBox2);
         this.gpbPago.Controls.Add(this.txtTotal);
         this.gpbPago.Controls.Add(this.label9);
         this.gpbPago.Controls.Add(this.cmbCliente);
         this.gpbPago.Controls.Add(this.label8);
         this.gpbPago.Controls.Add(this.label4);
         this.gpbPago.Controls.Add(this.txtSubTotal);
         this.gpbPago.Enabled = false;
         this.gpbPago.Location = new System.Drawing.Point(3, 321);
         this.gpbPago.Name = "gpbPago";
         this.gpbPago.Size = new System.Drawing.Size(515, 186);
         this.gpbPago.TabIndex = 47;
         this.gpbPago.TabStop = false;
         this.gpbPago.Text = "Pago";
         // 
         // txtIVA
         // 
         this.txtIVA.Enabled = false;
         this.txtIVA.Location = new System.Drawing.Point(168, 60);
         this.txtIVA.Name = "txtIVA";
         this.txtIVA.Size = new System.Drawing.Size(65, 20);
         this.txtIVA.TabIndex = 31;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(138, 60);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(24, 13);
         this.label12.TabIndex = 30;
         this.label12.Text = "IVA";
         // 
         // btnCapt
         // 
         this.btnCapt.Location = new System.Drawing.Point(429, 155);
         this.btnCapt.Name = "btnCapt";
         this.btnCapt.Size = new System.Drawing.Size(75, 23);
         this.btnCapt.TabIndex = 29;
         this.btnCapt.Text = "Capturar";
         this.btnCapt.UseVisualStyleBackColor = true;
         this.btnCapt.Click += new System.EventHandler(this.btnCapt_Click);
         // 
         // gpbTarj
         // 
         this.gpbTarj.Controls.Add(this.txtBanco);
         this.gpbTarj.Controls.Add(this.txtTarj);
         this.gpbTarj.Controls.Add(this.label11);
         this.gpbTarj.Controls.Add(this.label10);
         this.gpbTarj.Location = new System.Drawing.Point(285, 25);
         this.gpbTarj.Name = "gpbTarj";
         this.gpbTarj.Size = new System.Drawing.Size(219, 85);
         this.gpbTarj.TabIndex = 28;
         this.gpbTarj.TabStop = false;
         this.gpbTarj.Text = "Datos de Tarjeta";
         this.gpbTarj.Visible = false;
         // 
         // txtBanco
         // 
         this.txtBanco.Location = new System.Drawing.Point(108, 53);
         this.txtBanco.Name = "txtBanco";
         this.txtBanco.Size = new System.Drawing.Size(100, 20);
         this.txtBanco.TabIndex = 3;
         // 
         // txtTarj
         // 
         this.txtTarj.Location = new System.Drawing.Point(108, 17);
         this.txtTarj.Name = "txtTarj";
         this.txtTarj.Size = new System.Drawing.Size(100, 20);
         this.txtTarj.TabIndex = 2;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(64, 53);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(38, 13);
         this.label11.TabIndex = 1;
         this.label11.Text = "Banco";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(7, 20);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(95, 13);
         this.label10.TabIndex = 0;
         this.label10.Text = "Número de Tarjeta";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.rbTarjeta);
         this.groupBox2.Controls.Add(this.rbEfectivo);
         this.groupBox2.Location = new System.Drawing.Point(67, 120);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(96, 66);
         this.groupBox2.TabIndex = 27;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Forma de Pago";
         // 
         // rbTarjeta
         // 
         this.rbTarjeta.AutoSize = true;
         this.rbTarjeta.Location = new System.Drawing.Point(6, 43);
         this.rbTarjeta.Name = "rbTarjeta";
         this.rbTarjeta.Size = new System.Drawing.Size(58, 17);
         this.rbTarjeta.TabIndex = 29;
         this.rbTarjeta.Text = "Tarjeta";
         this.rbTarjeta.UseVisualStyleBackColor = true;
         this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
         // 
         // rbEfectivo
         // 
         this.rbEfectivo.AutoSize = true;
         this.rbEfectivo.Checked = true;
         this.rbEfectivo.Location = new System.Drawing.Point(6, 19);
         this.rbEfectivo.Name = "rbEfectivo";
         this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
         this.rbEfectivo.TabIndex = 28;
         this.rbEfectivo.TabStop = true;
         this.rbEfectivo.Text = "Efectivo";
         this.rbEfectivo.UseVisualStyleBackColor = true;
         this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
         // 
         // txtTotal
         // 
         this.txtTotal.Enabled = false;
         this.txtTotal.Location = new System.Drawing.Point(67, 94);
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.Size = new System.Drawing.Size(65, 20);
         this.txtTotal.TabIndex = 26;
         this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(30, 97);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(31, 13);
         this.label9.TabIndex = 25;
         this.label9.Text = "Total";
         // 
         // cmbCliente
         // 
         this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbCliente.FormattingEnabled = true;
         this.cmbCliente.Location = new System.Drawing.Point(67, 25);
         this.cmbCliente.Name = "cmbCliente";
         this.cmbCliente.Size = new System.Drawing.Size(121, 21);
         this.cmbCliente.TabIndex = 1;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(22, 28);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(39, 13);
         this.label8.TabIndex = 0;
         this.label8.Text = "Cliente";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(11, 63);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(50, 13);
         this.label4.TabIndex = 23;
         this.label4.Text = "SubTotal";
         // 
         // txtSubTotal
         // 
         this.txtSubTotal.Enabled = false;
         this.txtSubTotal.Location = new System.Drawing.Point(67, 60);
         this.txtSubTotal.Name = "txtSubTotal";
         this.txtSubTotal.Size = new System.Drawing.Size(65, 20);
         this.txtSubTotal.TabIndex = 24;
         // 
         // btnMenu
         // 
         this.btnMenu.Location = new System.Drawing.Point(405, 286);
         this.btnMenu.Name = "btnMenu";
         this.btnMenu.Size = new System.Drawing.Size(102, 23);
         this.btnMenu.TabIndex = 46;
         this.btnMenu.Text = "Regresar al Menu";
         this.btnMenu.UseVisualStyleBackColor = true;
         this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(265, 186);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(59, 13);
         this.label7.TabIndex = 45;
         this.label7.Text = "Accesorios";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(216, 143);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(108, 13);
         this.label6.TabIndex = 44;
         this.label6.Text = "Memorias p/Telefono";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(286, 100);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(29, 13);
         this.label5.TabIndex = 43;
         this.label5.Text = "USB";
         // 
         // cmbAcc
         // 
         this.cmbAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbAcc.FormattingEnabled = true;
         this.cmbAcc.Location = new System.Drawing.Point(330, 183);
         this.cmbAcc.Name = "cmbAcc";
         this.cmbAcc.Size = new System.Drawing.Size(177, 21);
         this.cmbAcc.TabIndex = 42;
         // 
         // cmbTel
         // 
         this.cmbTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbTel.FormattingEnabled = true;
         this.cmbTel.Location = new System.Drawing.Point(330, 140);
         this.cmbTel.Name = "cmbTel";
         this.cmbTel.Size = new System.Drawing.Size(177, 21);
         this.cmbTel.TabIndex = 41;
         // 
         // cmbUSB
         // 
         this.cmbUSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbUSB.FormattingEnabled = true;
         this.cmbUSB.Location = new System.Drawing.Point(330, 97);
         this.cmbUSB.Name = "cmbUSB";
         this.cmbUSB.Size = new System.Drawing.Size(177, 21);
         this.cmbUSB.TabIndex = 40;
         // 
         // btnAgrega
         // 
         this.btnAgrega.Location = new System.Drawing.Point(432, 222);
         this.btnAgrega.Name = "btnAgrega";
         this.btnAgrega.Size = new System.Drawing.Size(75, 38);
         this.btnAgrega.TabIndex = 39;
         this.btnAgrega.Text = "Agregar al Carrito";
         this.btnAgrega.UseVisualStyleBackColor = true;
         this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
         // 
         // btnPagar
         // 
         this.btnPagar.Location = new System.Drawing.Point(31, 191);
         this.btnPagar.Name = "btnPagar";
         this.btnPagar.Size = new System.Drawing.Size(75, 38);
         this.btnPagar.TabIndex = 38;
         this.btnPagar.Text = "Finalizar Compra";
         this.btnPagar.UseVisualStyleBackColor = true;
         // 
         // btnQuitar
         // 
         this.btnQuitar.Location = new System.Drawing.Point(117, 191);
         this.btnQuitar.Name = "btnQuitar";
         this.btnQuitar.Size = new System.Drawing.Size(75, 38);
         this.btnQuitar.TabIndex = 37;
         this.btnQuitar.Text = "Quitar Articulo";
         this.btnQuitar.UseVisualStyleBackColor = true;
         this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
         // 
         // lbArticulos
         // 
         this.lbArticulos.DisplayMember = "nombre";
         this.lbArticulos.FormattingEnabled = true;
         this.lbArticulos.Location = new System.Drawing.Point(15, 81);
         this.lbArticulos.Name = "lbArticulos";
         this.lbArticulos.Size = new System.Drawing.Size(190, 95);
         this.lbArticulos.TabIndex = 36;
         this.lbArticulos.ValueMember = "cvearticulo";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(327, 64);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(170, 13);
         this.label3.TabIndex = 35;
         this.label3.Text = "Selecciona lo que deseas comprar";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(11, 64);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(158, 13);
         this.label2.TabIndex = 34;
         this.label2.Text = "Lista de Articulos seleccionados";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(139, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(176, 37);
         this.label1.TabIndex = 33;
         this.label1.Text = "Informática";
         // 
         // frmInformatica
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(520, 514);
         this.Controls.Add(this.gpbPago);
         this.Controls.Add(this.btnMenu);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.cmbAcc);
         this.Controls.Add(this.cmbTel);
         this.Controls.Add(this.cmbUSB);
         this.Controls.Add(this.btnAgrega);
         this.Controls.Add(this.btnPagar);
         this.Controls.Add(this.btnQuitar);
         this.Controls.Add(this.lbArticulos);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmInformatica";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Informatica";
         this.Load += new System.EventHandler(this.frmInformatica_Load);
         this.gpbPago.ResumeLayout(false);
         this.gpbPago.PerformLayout();
         this.gpbTarj.ResumeLayout(false);
         this.gpbTarj.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox gpbPago;
      private System.Windows.Forms.TextBox txtIVA;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Button btnCapt;
      private System.Windows.Forms.GroupBox gpbTarj;
      private System.Windows.Forms.TextBox txtBanco;
      private System.Windows.Forms.TextBox txtTarj;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.RadioButton rbTarjeta;
      private System.Windows.Forms.RadioButton rbEfectivo;
      private System.Windows.Forms.TextBox txtTotal;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.ComboBox cmbCliente;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtSubTotal;
      private System.Windows.Forms.Button btnMenu;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox cmbAcc;
      private System.Windows.Forms.ComboBox cmbTel;
      private System.Windows.Forms.ComboBox cmbUSB;
      private System.Windows.Forms.Button btnAgrega;
      private System.Windows.Forms.Button btnPagar;
      private System.Windows.Forms.Button btnQuitar;
      private System.Windows.Forms.ListBox lbArticulos;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}