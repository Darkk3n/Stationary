namespace PapeleriaV3
{
   partial class frmMenu
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
         this.btnClientes = new System.Windows.Forms.Button();
         this.btnCat = new System.Windows.Forms.Button();
         this.btnDep = new System.Windows.Forms.Button();
         this.btnArticulos = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnClientes
         // 
         this.btnClientes.Location = new System.Drawing.Point(306, 117);
         this.btnClientes.Name = "btnClientes";
         this.btnClientes.Size = new System.Drawing.Size(75, 44);
         this.btnClientes.TabIndex = 12;
         this.btnClientes.Text = "Agregar Clientes";
         this.btnClientes.UseVisualStyleBackColor = true;
         this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
         // 
         // btnCat
         // 
         this.btnCat.Location = new System.Drawing.Point(225, 117);
         this.btnCat.Name = "btnCat";
         this.btnCat.Size = new System.Drawing.Size(75, 44);
         this.btnCat.TabIndex = 11;
         this.btnCat.Text = "Agregar Categorías";
         this.btnCat.UseVisualStyleBackColor = true;
         this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
         // 
         // btnDep
         // 
         this.btnDep.Location = new System.Drawing.Point(129, 117);
         this.btnDep.Name = "btnDep";
         this.btnDep.Size = new System.Drawing.Size(90, 44);
         this.btnDep.TabIndex = 10;
         this.btnDep.Text = "Agregar Departamentos";
         this.btnDep.UseVisualStyleBackColor = true;
         this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
         // 
         // btnArticulos
         // 
         this.btnArticulos.Location = new System.Drawing.Point(48, 117);
         this.btnArticulos.Name = "btnArticulos";
         this.btnArticulos.Size = new System.Drawing.Size(75, 44);
         this.btnArticulos.TabIndex = 9;
         this.btnArticulos.Text = "Comprar Articulos";
         this.btnArticulos.UseVisualStyleBackColor = true;
         this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("osaka_unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(131, 69);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(175, 15);
         this.label2.TabIndex = 8;
         this.label2.Text = "Seleccione una opción";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(152, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(128, 31);
         this.label1.TabIndex = 7;
         this.label1.Text = "Papeleria";
         // 
         // frmMenuP
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(429, 177);
         this.Controls.Add(this.btnClientes);
         this.Controls.Add(this.btnCat);
         this.Controls.Add(this.btnDep);
         this.Controls.Add(this.btnArticulos);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmMenuP";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Menu Principal";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnClientes;
      private System.Windows.Forms.Button btnCat;
      private System.Windows.Forms.Button btnDep;
      private System.Windows.Forms.Button btnArticulos;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}