namespace BoletoElectronicoDesktop.AbmClientes
{
    partial class FormAbmClientesIngresodatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbmClientesIngresodatos));
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.checkHabilitado = new System.Windows.Forms.CheckBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.lbNroDNI = new System.Windows.Forms.Label();
            this.comboDNI = new System.Windows.Forms.ComboBox();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.tbDpto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.limpia_camposCli = new System.Windows.Forms.Button();
            this.gbClientes.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClientes.Controls.Add(this.checkHabilitado);
            this.gbClientes.Controls.Add(this.tbDNI);
            this.gbClientes.Controls.Add(this.lbNroDNI);
            this.gbClientes.Controls.Add(this.comboDNI);
            this.gbClientes.Controls.Add(this.gbDireccion);
            this.gbClientes.Controls.Add(this.label10);
            this.gbClientes.Controls.Add(this.tbTelefono);
            this.gbClientes.Controls.Add(this.tbCorreo);
            this.gbClientes.Controls.Add(this.tbApellido);
            this.gbClientes.Controls.Add(this.tbNombre);
            this.gbClientes.Controls.Add(this.label5);
            this.gbClientes.Controls.Add(this.label7);
            this.gbClientes.Controls.Add(this.label8);
            this.gbClientes.Controls.Add(this.label11);
            this.gbClientes.Controls.Add(this.label12);
            this.gbClientes.Location = new System.Drawing.Point(19, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(454, 316);
            this.gbClientes.TabIndex = 2;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Alta de clientes";
            // 
            // checkHabilitado
            // 
            this.checkHabilitado.AutoSize = true;
            this.checkHabilitado.Location = new System.Drawing.Point(355, 88);
            this.checkHabilitado.Name = "checkHabilitado";
            this.checkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.checkHabilitado.TabIndex = 24;
            this.checkHabilitado.Text = "Habilitado";
            this.checkHabilitado.UseVisualStyleBackColor = true;
            this.checkHabilitado.CheckedChanged += new System.EventHandler(this.checkHabilitado_CheckedChanged);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(117, 144);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(78, 20);
            this.tbDNI.TabIndex = 23;
            // 
            // lbNroDNI
            // 
            this.lbNroDNI.AutoSize = true;
            this.lbNroDNI.Location = new System.Drawing.Point(25, 144);
            this.lbNroDNI.Name = "lbNroDNI";
            this.lbNroDNI.Size = new System.Drawing.Size(62, 13);
            this.lbNroDNI.TabIndex = 22;
            this.lbNroDNI.Text = "(*) Nro. DNI";
            // 
            // comboDNI
            // 
            this.comboDNI.FormattingEnabled = true;
            this.comboDNI.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE",
            "PASAPORTE"});
            this.comboDNI.Location = new System.Drawing.Point(102, 105);
            this.comboDNI.Name = "comboDNI";
            this.comboDNI.Size = new System.Drawing.Size(93, 21);
            this.comboDNI.Sorted = true;
            this.comboDNI.TabIndex = 21;
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.tbDpto);
            this.gbDireccion.Controls.Add(this.label4);
            this.gbDireccion.Controls.Add(this.tbPiso);
            this.gbDireccion.Controls.Add(this.label3);
            this.gbDireccion.Controls.Add(this.tbNro);
            this.gbDireccion.Controls.Add(this.label2);
            this.gbDireccion.Controls.Add(this.tbCalle);
            this.gbDireccion.Controls.Add(this.label1);
            this.gbDireccion.Controls.Add(this.comboProvincia);
            this.gbDireccion.Controls.Add(this.label9);
            this.gbDireccion.Location = new System.Drawing.Point(17, 190);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(420, 92);
            this.gbDireccion.TabIndex = 20;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Dirección";
            // 
            // tbDpto
            // 
            this.tbDpto.Location = new System.Drawing.Point(286, 55);
            this.tbDpto.Name = "tbDpto";
            this.tbDpto.Size = new System.Drawing.Size(50, 20);
            this.tbDpto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(*) Dpto";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(175, 55);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(50, 20);
            this.tbPiso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(*) Piso";
            // 
            // tbNro
            // 
            this.tbNro.Location = new System.Drawing.Point(72, 55);
            this.tbNro.Name = "tbNro";
            this.tbNro.Size = new System.Drawing.Size(50, 20);
            this.tbNro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(*) Número";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(55, 19);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(155, 20);
            this.tbCalle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(*) Calle";
            // 
            // comboProvincia
            // 
            this.comboProvincia.AllowDrop = true;
            this.comboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(287, 18);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(125, 21);
            this.comboProvincia.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Provincia (*):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Los campos marcados con asterisco (*) son obligatorios.";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(280, 62);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(149, 20);
            this.tbTelefono.TabIndex = 14;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(280, 30);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(149, 20);
            this.tbCorreo.TabIndex = 13;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(89, 64);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(106, 20);
            this.tbApellido.TabIndex = 11;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(86, 31);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(109, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "(*) Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "(*) Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "(*) Tipo DNI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "(*) Apellido";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "(*) Nombre";
            // 
            // bGuardar
            // 
            this.bGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuardar.Location = new System.Drawing.Point(374, 334);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 23);
            this.bGuardar.TabIndex = 3;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // limpia_camposCli
            // 
            this.limpia_camposCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.limpia_camposCli.Location = new System.Drawing.Point(19, 334);
            this.limpia_camposCli.Name = "limpia_camposCli";
            this.limpia_camposCli.Size = new System.Drawing.Size(100, 23);
            this.limpia_camposCli.TabIndex = 4;
            this.limpia_camposCli.Text = "Limpiar";
            this.limpia_camposCli.UseVisualStyleBackColor = true;
            this.limpia_camposCli.Click += new System.EventHandler(this.limpia_camposCli_Click);
            // 
            // FormAbmClientesIngresodatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 369);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.limpia_camposCli);
            this.Controls.Add(this.bGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbmClientesIngresodatos";
            this.Text = "Alta Clientes";
            this.Load += new System.EventHandler(this.FormAbmClientesIngresodatos_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label lbNroDNI;
        private System.Windows.Forms.ComboBox comboDNI;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.TextBox tbDpto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox comboProvincia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button limpia_camposCli;
        private System.Windows.Forms.CheckBox checkHabilitado;
    }
}