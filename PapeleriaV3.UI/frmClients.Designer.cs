namespace PapeleriaV3
{
   partial class frmClients
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
         this.txtTel = new System.Windows.Forms.TextBox();
         this.txtDir = new System.Windows.Forms.TextBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnCancelar
         // 
         this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancelar.Location = new System.Drawing.Point(147, 225);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(75, 23);
         this.btnCancelar.TabIndex = 13;
         this.btnCancelar.Text = "Cancelar";
         this.btnCancelar.UseVisualStyleBackColor = true;
         // 
         // btnAceptar
         // 
         this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnAceptar.Location = new System.Drawing.Point(66, 225);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(75, 23);
         this.btnAceptar.TabIndex = 12;
         this.btnAceptar.Text = "Aceptar";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // txtTel
         // 
         this.txtTel.Location = new System.Drawing.Point(122, 136);
         this.txtTel.Name = "txtTel";
         this.txtTel.Size = new System.Drawing.Size(100, 20);
         this.txtTel.TabIndex = 11;
         // 
         // txtDir
         // 
         this.txtDir.Location = new System.Drawing.Point(122, 50);
         this.txtDir.Multiline = true;
         this.txtDir.Name = "txtDir";
         this.txtDir.Size = new System.Drawing.Size(100, 63);
         this.txtDir.TabIndex = 9;
         // 
         // txtNombre
         // 
         this.txtNombre.Location = new System.Drawing.Point(122, 12);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(100, 20);
         this.txtNombre.TabIndex = 7;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(67, 139);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(49, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Telefono";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(63, 53);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(52, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "Direccion";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(63, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(44, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Nombre";
         // 
         // frmClientes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 261);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.txtTel);
         this.Controls.Add(this.txtDir);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmClientes";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Clientes";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCancelar;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.TextBox txtTel;
      private System.Windows.Forms.TextBox txtDir;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}