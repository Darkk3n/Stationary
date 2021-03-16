namespace PapeleriaV3
{
   partial class frmArticles
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
         this.btnCancelar = new System.Windows.Forms.Button();
         this.btnAceptar = new System.Windows.Forms.Button();
         this.txtPrecio = new System.Windows.Forms.TextBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.cmbCat = new System.Windows.Forms.ComboBox();
         this.cmbDep = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnCancelar
         // 
         this.btnCancelar.Location = new System.Drawing.Point(167, 160);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(75, 23);
         this.btnCancelar.TabIndex = 19;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // btnAceptar
         // 
         this.btnAceptar.Location = new System.Drawing.Point(54, 160);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(75, 23);
         this.btnAceptar.TabIndex = 18;
         this.btnAceptar.Text = "Aceptar";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // txtPrecio
         // 
         this.txtPrecio.Location = new System.Drawing.Point(95, 46);
         this.txtPrecio.Name = "txtPrecio";
         this.txtPrecio.Size = new System.Drawing.Size(121, 20);
         this.txtPrecio.TabIndex = 17;
         // 
         // txtNombre
         // 
         this.txtNombre.Location = new System.Drawing.Point(95, 13);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(121, 20);
         this.txtNombre.TabIndex = 16;
         // 
         // cmbCat
         // 
         this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbCat.FormattingEnabled = true;
         this.cmbCat.Location = new System.Drawing.Point(95, 112);
         this.cmbCat.Name = "cmbCat";
         this.cmbCat.Size = new System.Drawing.Size(121, 21);
         this.cmbCat.TabIndex = 15;
         // 
         // cmbDep
         // 
         this.cmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbDep.FormattingEnabled = true;
         this.cmbDep.Location = new System.Drawing.Point(95, 80);
         this.cmbDep.Name = "cmbDep";
         this.cmbDep.Size = new System.Drawing.Size(121, 21);
         this.cmbDep.TabIndex = 14;
         this.cmbDep.SelectedIndexChanged += new System.EventHandler(this.cmbDep_SelectedIndexChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(37, 115);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(52, 13);
         this.label4.TabIndex = 13;
         this.label4.Text = "Categoria";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(16, 83);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(74, 13);
         this.label3.TabIndex = 12;
         this.label3.Text = "Departamento";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(52, 49);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(37, 13);
         this.label2.TabIndex = 11;
         this.label2.Text = "Precio";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(45, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(44, 13);
         this.label1.TabIndex = 10;
         this.label1.Text = "Nombre";
         // 
         // frmArticulos
         // 
         this.AcceptButton = this.btnAceptar;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancelar;
         this.ClientSize = new System.Drawing.Size(287, 203);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.txtPrecio);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.cmbCat);
         this.Controls.Add(this.cmbDep);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmArticulos";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Articulos";
         this.Load += new System.EventHandler(this.frmArticulos_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCancelar;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.TextBox txtPrecio;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.ComboBox cmbCat;
      private System.Windows.Forms.ComboBox cmbDep;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}