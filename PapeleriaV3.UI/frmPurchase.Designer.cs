namespace PapeleriaV3
{
   partial class frmPurchase
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
         this.btnAgregaArt = new System.Windows.Forms.Button();
         this.btnSalir = new System.Windows.Forms.Button();
         this.btnContinuar = new System.Windows.Forms.Button();
         this.rbPapeleria = new System.Windows.Forms.RadioButton();
         this.rbInformatica = new System.Windows.Forms.RadioButton();
         this.rbOficina = new System.Windows.Forms.RadioButton();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnAgregaArt
         // 
         this.btnAgregaArt.Location = new System.Drawing.Point(171, 211);
         this.btnAgregaArt.Name = "btnAgregaArt";
         this.btnAgregaArt.Size = new System.Drawing.Size(75, 34);
         this.btnAgregaArt.TabIndex = 23;
         this.btnAgregaArt.Text = "Agregar Articulo";
         this.btnAgregaArt.UseVisualStyleBackColor = true;
         this.btnAgregaArt.Click += new System.EventHandler(this.btnAgregaArt_Click);
         // 
         // btnSalir
         // 
         this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnSalir.Location = new System.Drawing.Point(274, 217);
         this.btnSalir.Name = "btnSalir";
         this.btnSalir.Size = new System.Drawing.Size(75, 23);
         this.btnSalir.TabIndex = 22;
         this.btnSalir.Text = "Salir";
         this.btnSalir.UseVisualStyleBackColor = true;
         // 
         // btnContinuar
         // 
         this.btnContinuar.Location = new System.Drawing.Point(68, 217);
         this.btnContinuar.Name = "btnContinuar";
         this.btnContinuar.Size = new System.Drawing.Size(75, 23);
         this.btnContinuar.TabIndex = 21;
         this.btnContinuar.Text = "Continuar";
         this.btnContinuar.UseVisualStyleBackColor = true;
         this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
         // 
         // rbPapeleria
         // 
         this.rbPapeleria.AutoSize = true;
         this.rbPapeleria.Location = new System.Drawing.Point(264, 145);
         this.rbPapeleria.Name = "rbPapeleria";
         this.rbPapeleria.Size = new System.Drawing.Size(106, 17);
         this.rbPapeleria.TabIndex = 20;
         this.rbPapeleria.TabStop = true;
         this.rbPapeleria.Text = "Papeleria y Utiles";
         this.rbPapeleria.UseVisualStyleBackColor = true;
         // 
         // rbInformatica
         // 
         this.rbInformatica.AutoSize = true;
         this.rbInformatica.Location = new System.Drawing.Point(160, 145);
         this.rbInformatica.Name = "rbInformatica";
         this.rbInformatica.Size = new System.Drawing.Size(77, 17);
         this.rbInformatica.TabIndex = 19;
         this.rbInformatica.TabStop = true;
         this.rbInformatica.Text = "Informatica";
         this.rbInformatica.UseVisualStyleBackColor = true;
         // 
         // rbOficina
         // 
         this.rbOficina.AutoSize = true;
         this.rbOficina.Location = new System.Drawing.Point(68, 145);
         this.rbOficina.Name = "rbOficina";
         this.rbOficina.Size = new System.Drawing.Size(58, 17);
         this.rbOficina.TabIndex = 18;
         this.rbOficina.TabStop = true;
         this.rbOficina.Text = "Oficina";
         this.rbOficina.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(157, 81);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(109, 13);
         this.label2.TabIndex = 17;
         this.label2.Text = "Elija un departamento";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(61, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(309, 37);
         this.label1.TabIndex = 16;
         this.label1.Text = "Compra de Articulos";
         // 
         // frmCompraArt
         // 
         this.AcceptButton = this.btnContinuar;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnSalir;
         this.ClientSize = new System.Drawing.Size(431, 261);
         this.Controls.Add(this.btnAgregaArt);
         this.Controls.Add(this.btnSalir);
         this.Controls.Add(this.btnContinuar);
         this.Controls.Add(this.rbPapeleria);
         this.Controls.Add(this.rbInformatica);
         this.Controls.Add(this.rbOficina);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmCompraArt";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Papeleria - Compra de Articulos";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnAgregaArt;
      private System.Windows.Forms.Button btnSalir;
      private System.Windows.Forms.Button btnContinuar;
      private System.Windows.Forms.RadioButton rbPapeleria;
      private System.Windows.Forms.RadioButton rbInformatica;
      private System.Windows.Forms.RadioButton rbOficina;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}