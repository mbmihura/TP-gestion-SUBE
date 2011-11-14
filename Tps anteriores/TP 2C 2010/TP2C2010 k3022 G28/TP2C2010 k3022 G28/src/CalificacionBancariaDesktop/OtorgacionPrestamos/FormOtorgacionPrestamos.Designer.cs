namespace CalificacionBancariaDesktop.OtorgacionPrestamos
{
    partial class FormOtorgacionPrestamos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbBANCO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butEjecutarPrestamo = new System.Windows.Forms.Button();
            this.tbIDPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(15, 36);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 0;
            // 
            // tbBANCO
            // 
            this.tbBANCO.Location = new System.Drawing.Point(15, 87);
            this.tbBANCO.Name = "tbBANCO";
            this.tbBANCO.Size = new System.Drawing.Size(100, 20);
            this.tbBANCO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT Banco";
            // 
            // butEjecutarPrestamo
            // 
            this.butEjecutarPrestamo.Location = new System.Drawing.Point(157, 46);
            this.butEjecutarPrestamo.Name = "butEjecutarPrestamo";
            this.butEjecutarPrestamo.Size = new System.Drawing.Size(75, 38);
            this.butEjecutarPrestamo.TabIndex = 4;
            this.butEjecutarPrestamo.Text = "Otorgar Prestamo";
            this.butEjecutarPrestamo.UseVisualStyleBackColor = true;
            this.butEjecutarPrestamo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIDPrestamo
            // 
            this.tbIDPrestamo.Location = new System.Drawing.Point(268, 55);
            this.tbIDPrestamo.Name = "tbIDPrestamo";
            this.tbIDPrestamo.Size = new System.Drawing.Size(173, 20);
            this.tbIDPrestamo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID del Préstamo";
            // 
            // FormOtorgacionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIDPrestamo);
            this.Controls.Add(this.butEjecutarPrestamo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBANCO);
            this.Controls.Add(this.tbDNI);
            this.Name = "FormOtorgacionPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Otorgación de Préstamos";
            this.Load += new System.EventHandler(this.FormOtorgacionPrestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbBANCO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butEjecutarPrestamo;
        private System.Windows.Forms.TextBox tbIDPrestamo;
        private System.Windows.Forms.Label label3;
    }
}