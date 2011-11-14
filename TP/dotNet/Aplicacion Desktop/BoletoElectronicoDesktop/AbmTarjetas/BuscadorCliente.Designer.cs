namespace BoletoElectronicoDesktop.AbmTarjetas
{
    partial class BuscadorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscadorCliente));
            this.BusquedaCliente = new System.Windows.Forms.GroupBox();
            this.lblTipoDni = new System.Windows.Forms.Label();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTpoDni = new System.Windows.Forms.ComboBox();
            this.nudDni = new System.Windows.Forms.NumericUpDown();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BusquedaCliente.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BusquedaCliente
            // 
            this.BusquedaCliente.Controls.Add(this.lblTipoDni);
            this.BusquedaCliente.Controls.Add(this.gbDireccion);
            this.BusquedaCliente.Controls.Add(this.cboTpoDni);
            this.BusquedaCliente.Controls.Add(this.nudDni);
            this.BusquedaCliente.Controls.Add(this.txtTelefono);
            this.BusquedaCliente.Controls.Add(this.lblTelefono);
            this.BusquedaCliente.Controls.Add(this.lblMail);
            this.BusquedaCliente.Controls.Add(this.lblDni);
            this.BusquedaCliente.Controls.Add(this.lblApellido);
            this.BusquedaCliente.Controls.Add(this.lblNombre);
            this.BusquedaCliente.Controls.Add(this.txtMail);
            this.BusquedaCliente.Controls.Add(this.txtApellido);
            this.BusquedaCliente.Controls.Add(this.txtNombre);
            this.BusquedaCliente.Location = new System.Drawing.Point(12, 12);
            this.BusquedaCliente.Name = "BusquedaCliente";
            this.BusquedaCliente.Size = new System.Drawing.Size(649, 127);
            this.BusquedaCliente.TabIndex = 11;
            this.BusquedaCliente.TabStop = false;
            this.BusquedaCliente.Text = "Buscador de clientes";
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.Location = new System.Drawing.Point(9, 90);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(50, 13);
            this.lblTipoDni.TabIndex = 34;
            this.lblTipoDni.Text = "Tipo DNI";
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.nudNumero);
            this.gbDireccion.Controls.Add(this.nudPiso);
            this.gbDireccion.Controls.Add(this.txtCalle);
            this.gbDireccion.Controls.Add(this.label1);
            this.gbDireccion.Controls.Add(this.txtDepto);
            this.gbDireccion.Controls.Add(this.label4);
            this.gbDireccion.Controls.Add(this.label2);
            this.gbDireccion.Controls.Add(this.label3);
            this.gbDireccion.Location = new System.Drawing.Point(385, 0);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(264, 127);
            this.gbDireccion.TabIndex = 10;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Direccion";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(113, 46);
            this.nudNumero.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(74, 20);
            this.nudNumero.TabIndex = 31;
            this.nudNumero.ValueChanged += new System.EventHandler(this.nudNumero_ValueChanged);
            // 
            // nudPiso
            // 
            this.nudPiso.Location = new System.Drawing.Point(113, 72);
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(44, 20);
            this.nudPiso.TabIndex = 30;
            this.nudPiso.ValueChanged += new System.EventHandler(this.nudPiso_ValueChanged);
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalle.Location = new System.Drawing.Point(113, 20);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(130, 20);
            this.txtCalle.TabIndex = 26;
            this.txtCalle.TextChanged += new System.EventHandler(this.txtCalle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Número:";
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(113, 98);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(44, 20);
            this.txtDepto.TabIndex = 27;
            this.txtDepto.TextChanged += new System.EventHandler(this.txtDepto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Piso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Depto:";
            // 
            // cboTpoDni
            // 
            this.cboTpoDni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTpoDni.FormattingEnabled = true;
            this.cboTpoDni.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE",
            "Pasaporte"});
            this.cboTpoDni.Location = new System.Drawing.Point(65, 87);
            this.cboTpoDni.Name = "cboTpoDni";
            this.cboTpoDni.Size = new System.Drawing.Size(100, 21);
            this.cboTpoDni.TabIndex = 33;
            this.cboTpoDni.SelectedIndexChanged += new System.EventHandler(this.cboTpoDni_SelectedIndexChanged);
            // 
            // nudDni
            // 
            this.nudDni.Location = new System.Drawing.Point(78, 61);
            this.nudDni.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudDni.Name = "nudDni";
            this.nudDni.Size = new System.Drawing.Size(86, 20);
            this.nudDni.TabIndex = 32;
            this.nudDni.ValueChanged += new System.EventHandler(this.nudDni_ValueChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(267, 61);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(209, 63);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(211, 89);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 16;
            this.lblMail.Text = "Mail";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(9, 65);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 15;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(209, 35);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(267, 86);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 12;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(267, 35);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar});
            this.dgvClientes.Location = new System.Drawing.Point(12, 145);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(649, 310);
            this.dgvClientes.TabIndex = 12;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Text = "Seleccionar Cliente";
            this.btnSeleccionar.UseColumnTextForButtonValue = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 461);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BuscadorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 487);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.BusquedaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscadorCliente";
            this.Text = "BuscadorCliente";
            this.Load += new System.EventHandler(this.BuscadorCliente_Load);
            this.BusquedaCliente.ResumeLayout(false);
            this.BusquedaCliente.PerformLayout();
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BusquedaCliente;
        private System.Windows.Forms.Label lblTipoDni;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.NumericUpDown nudPiso;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTpoDni;
        private System.Windows.Forms.NumericUpDown nudDni;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;

    }
}