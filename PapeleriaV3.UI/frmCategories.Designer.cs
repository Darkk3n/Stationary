namespace PapeleriaV3
{
   partial class frmCategories
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
         this.txtCat = new System.Windows.Forms.TextBox();
         this.cmbDepto = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnCancelar
         // 
         this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancelar.Location = new System.Drawing.Point(151, 111);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(75, 23);
         this.btnCancelar.TabIndex = 11;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // btnAceptar
         // 
         this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnAceptar.Location = new System.Drawing.Point(70, 111);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(75, 23);
         this.btnAceptar.TabIndex = 10;
         this.btnAceptar.Text = "Aceptar";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // txtCat
         // 
         this.txtCat.Location = new System.Drawing.Point(103, 52);
         this.txtCat.Name = "txtCat";
         this.txtCat.Size = new System.Drawing.Size(121, 20);
         this.txtCat.TabIndex = 9;
         // 
         // cmbDepto
         // 
         this.cmbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbDepto.FormattingEnabled = true;
         this.cmbDepto.Location = new System.Drawing.Point(103, 14);
         this.cmbDepto.Name = "cmbDepto";
         this.cmbDepto.Size = new System.Drawing.Size(121, 21);
         this.cmbDepto.TabIndex = 8;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(40, 55);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(57, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Categoría:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(20, 17);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(77, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Departamento:";
         // 
         // frmCategorias
         // 
         this.AcceptButton = this.btnAceptar;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancelar;
         this.ClientSize = new System.Drawing.Size(295, 150);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.txtCat);
         this.Controls.Add(this.cmbDepto);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "frmCategorias";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Agregar Categorias";
         this.Load += new System.EventHandler(this.frmCategorias_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCancelar;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.TextBox txtCat;
      private System.Windows.Forms.ComboBox cmbDepto;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}