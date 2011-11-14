namespace BoletoElectronicoDesktop.AbmTarjetas
{
    partial class FiltroBusquedaTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroBusquedaTarjeta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chCliente = new System.Windows.Forms.CheckBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.chNroTarjeta = new System.Windows.Forms.CheckBox();
            this.chFechaAlta = new System.Windows.Forms.CheckBox();
            this.nudNroTarjeta = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chNroTarjeta);
            this.groupBox1.Controls.Add(this.chFechaAlta);
            this.groupBox1.Controls.Add(this.nudNroTarjeta);
            this.groupBox1.Controls.Add(this.dtpFechaAlta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de busqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chCliente);
            this.groupBox2.Controls.Add(this.btnSeleccionarCliente);
            this.groupBox2.Location = new System.Drawing.Point(287, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 54);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // chCliente
            // 
            this.chCliente.AutoSize = true;
            this.chCliente.Location = new System.Drawing.Point(54, 23);
            this.chCliente.Name = "chCliente";
            this.chCliente.Size = new System.Drawing.Size(58, 17);
            this.chCliente.TabIndex = 28;
            this.chCliente.Text = "Cliente";
            this.chCliente.UseVisualStyleBackColor = true;
            this.chCliente.CheckedChanged += new System.EventHandler(this.chCliente_CheckedChanged);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Enabled = false;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(118, 19);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(223, 23);
            this.btnSeleccionarCliente.TabIndex = 25;
            this.btnSeleccionarCliente.Text = "Selección de cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // chNroTarjeta
            // 
            this.chNroTarjeta.AutoSize = true;
            this.chNroTarjeta.Location = new System.Drawing.Point(22, 56);
            this.chNroTarjeta.Name = "chNroTarjeta";
            this.chNroTarjeta.Size = new System.Drawing.Size(90, 17);
            this.chNroTarjeta.TabIndex = 27;
            this.chNroTarjeta.Text = "Nro de tarjeta";
            this.chNroTarjeta.UseVisualStyleBackColor = true;
            this.chNroTarjeta.CheckedChanged += new System.EventHandler(this.chNroTarjeta_CheckedChanged);
            // 
            // chFechaAlta
            // 
            this.chFechaAlta.AutoSize = true;
            this.chFechaAlta.Location = new System.Drawing.Point(22, 30);
            this.chFechaAlta.Name = "chFechaAlta";
            this.chFechaAlta.Size = new System.Drawing.Size(91, 17);
            this.chFechaAlta.TabIndex = 26;
            this.chFechaAlta.Text = "Fecha de alta";
            this.chFechaAlta.UseVisualStyleBackColor = true;
            this.chFechaAlta.CheckedChanged += new System.EventHandler(this.chFechaAlta_CheckedChanged);
            // 
            // nudNroTarjeta
            // 
            this.nudNroTarjeta.Enabled = false;
            this.nudNroTarjeta.Location = new System.Drawing.Point(119, 53);
            this.nudNroTarjeta.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudNroTarjeta.Name = "nudNroTarjeta";
            this.nudNroTarjeta.Size = new System.Drawing.Size(74, 20);
            this.nudNroTarjeta.TabIndex = 24;
            this.nudNroTarjeta.ValueChanged += new System.EventHandler(this.nudNroTarjeta_ValueChanged);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(119, 27);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(127, 20);
            this.dtpFechaAlta.TabIndex = 8;
            this.dtpFechaAlta.ValueChanged += new System.EventHandler(this.dtpFechaAlta_ValueChanged);
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
            this.dgvClientes.Location = new System.Drawing.Point(12, 110);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(674, 382);
            this.dgvClientes.TabIndex = 7;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Text = "Modificar";
            this.btnSeleccionar.UseColumnTextForButtonValue = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 498);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FiltroBusquedaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 533);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FiltroBusquedaTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de tarjetas";
            this.Load += new System.EventHandler(this.FiltroBusquedaTarjeta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudNroTarjeta;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.CheckBox chNroTarjeta;
        private System.Windows.Forms.CheckBox chFechaAlta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chCliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
    }
}