namespace BoletoElectronicoDesktop.Login
{
    partial class frmRolSeccion
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
            this.lblRolSeleccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRolSeleccion
            // 
            this.lblRolSeleccion.AutoSize = true;
            this.lblRolSeleccion.Location = new System.Drawing.Point(55, 22);
            this.lblRolSeleccion.Name = "lblRolSeleccion";
            this.lblRolSeleccion.Size = new System.Drawing.Size(166, 13);
            this.lblRolSeleccion.TabIndex = 0;
            this.lblRolSeleccion.Text = "¿Qué rol desea usar en esta vez?";
            // 
            // frmRolSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblRolSeleccion);
            this.Name = "frmRolSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRolSeleccion;

    }
}