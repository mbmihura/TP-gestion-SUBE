namespace CalificacionBancariaDesktop.AbmCuenta
{
    partial class FormAbmCuenta
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
            this.abm_cuenta = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dsds = new System.Windows.Forms.Label();
            this.accion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.banco = new System.Windows.Forms.TextBox();
            this.dir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_dir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transfer = new System.Windows.Forms.GroupBox();
            this.moneda_ori = new System.Windows.Forms.TextBox();
            this.moneda_dest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.transferir = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abm_cuenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.transfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // abm_cuenta
            // 
            this.abm_cuenta.AllowUserToAddRows = false;
            this.abm_cuenta.AllowUserToDeleteRows = false;
            this.abm_cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abm_cuenta.Location = new System.Drawing.Point(353, 11);
            this.abm_cuenta.MultiSelect = false;
            this.abm_cuenta.Name = "abm_cuenta";
            this.abm_cuenta.ReadOnly = true;
            this.abm_cuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abm_cuenta.Size = new System.Drawing.Size(429, 261);
            this.abm_cuenta.TabIndex = 22;
            this.abm_cuenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.abm_cuenta_CellClick);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(632, 278);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 21;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(713, 278);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 20;
            this.submit.Text = "Aceptar";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "DNI";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(66, 90);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(267, 20);
            this.dni.TabIndex = 18;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(66, 64);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(267, 20);
            this.apellido.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(66, 38);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(267, 20);
            this.nombre.TabIndex = 15;
            // 
            // dsds
            // 
            this.dsds.AutoSize = true;
            this.dsds.Location = new System.Drawing.Point(12, 41);
            this.dsds.Name = "dsds";
            this.dsds.Size = new System.Drawing.Size(44, 13);
            this.dsds.TabIndex = 14;
            this.dsds.Text = "Nombre";
            // 
            // accion
            // 
            this.accion.FormattingEnabled = true;
            this.accion.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.accion.Location = new System.Drawing.Point(66, 11);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(267, 21);
            this.accion.TabIndex = 13;
            this.accion.SelectedIndexChanged += new System.EventHandler(this.accion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Acción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Banco";
            // 
            // banco
            // 
            this.banco.Location = new System.Drawing.Point(66, 115);
            this.banco.Name = "banco";
            this.banco.Size = new System.Drawing.Size(267, 20);
            this.banco.TabIndex = 24;
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(51, 19);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(165, 20);
            this.dir.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nro.";
            // 
            // num_dir
            // 
            this.num_dir.Location = new System.Drawing.Point(260, 19);
            this.num_dir.Name = "num_dir";
            this.num_dir.Size = new System.Drawing.Size(52, 20);
            this.num_dir.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Calle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_dir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 51);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sucursal";
            // 
            // transfer
            // 
            this.transfer.Controls.Add(this.moneda_ori);
            this.transfer.Controls.Add(this.moneda_dest);
            this.transfer.Controls.Add(this.label9);
            this.transfer.Controls.Add(this.transferir);
            this.transfer.Controls.Add(this.monto);
            this.transfer.Controls.Add(this.label8);
            this.transfer.Controls.Add(this.desde);
            this.transfer.Controls.Add(this.label5);
            this.transfer.Enabled = false;
            this.transfer.Location = new System.Drawing.Point(13, 199);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(320, 100);
            this.transfer.TabIndex = 31;
            this.transfer.TabStop = false;
            this.transfer.Text = "Transferir Fondos";
            // 
            // moneda_ori
            // 
            this.moneda_ori.Location = new System.Drawing.Point(224, 43);
            this.moneda_ori.Name = "moneda_ori";
            this.moneda_ori.ReadOnly = true;
            this.moneda_ori.Size = new System.Drawing.Size(93, 20);
            this.moneda_ori.TabIndex = 16;
            // 
            // moneda_dest
            // 
            this.moneda_dest.Location = new System.Drawing.Point(224, 69);
            this.moneda_dest.Name = "moneda_dest";
            this.moneda_dest.Size = new System.Drawing.Size(93, 20);
            this.moneda_dest.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Transferir";
            // 
            // transferir
            // 
            this.transferir.Location = new System.Drawing.Point(61, 70);
            this.transferir.Name = "transferir";
            this.transferir.Size = new System.Drawing.Size(157, 20);
            this.transferir.TabIndex = 13;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(61, 43);
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Size = new System.Drawing.Size(157, 20);
            this.monto.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Monto";
            // 
            // desde
            // 
            this.desde.Location = new System.Drawing.Point(61, 16);
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            this.desde.Size = new System.Drawing.Size(256, 20);
            this.desde.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Desde";
            // 
            // FormAbmCuenta
            // 
            this.ClientSize = new System.Drawing.Size(794, 312);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.banco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abm_cuenta);
            this.Controls.Add(this.search);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.dsds);
            this.Controls.Add(this.accion);
            this.Controls.Add(this.label1);
            this.Name = "FormAbmCuenta";
            this.Load += new System.EventHandler(this.FormAbmCuenta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.abm_cuenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.transfer.ResumeLayout(false);
            this.transfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView abm_cuenta;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label dsds;
        private System.Windows.Forms.ComboBox accion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox banco;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox num_dir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox transfer;
        private System.Windows.Forms.TextBox moneda_ori;
        private System.Windows.Forms.TextBox moneda_dest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox transferir;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox desde;
        private System.Windows.Forms.Label label5;

    }
}