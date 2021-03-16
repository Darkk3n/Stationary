namespace PapeleriaV3
{
   partial class frmDepartaments
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
         this.txtDepto = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnCancelar
         // 
         this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancelar.Location = new System.Drawing.Point(210, 71);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(75, 23);
         this.btnCancelar.TabIndex = 7;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // btnAceptar
         // 
         this.btnAceptar.Location = new System.Drawing.Point(128, 71);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(75, 23);
         this.btnAceptar.TabIndex = 6;
         this.btnAceptar.Text = "Aceptar";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // txtDepto
         // 
         this.txtDepto.Location = new System.Drawing.Point(199, 18);
         this.txtDepto.Name = "txtDepto";
         this.txtDepto.Size = new System.Drawing.Size(156, 20);
         this.txtDepto.TabIndex = 5;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(61, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(132, 13);
         this.label1.TabIndex = 4;
         this.label1.Text = "Nombre de Departamento:";
         // 
         // frmDepartamentos
         // 
         this.AcceptButton = this.btnAceptar;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancelar;
         this.ClientSize = new System.Drawing.Size(390, 116);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.txtDepto);
         this.Controls.Add(this.label1);
         this.Name = "frmDepartamentos";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Agregar Departamentos";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCancelar;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.TextBox txtDepto;
      private System.Windows.Forms.Label label1;
   }
}