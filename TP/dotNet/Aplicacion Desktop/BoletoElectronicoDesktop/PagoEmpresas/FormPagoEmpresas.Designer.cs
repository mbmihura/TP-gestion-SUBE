namespace BoletoElectronicoDesktop.PagoEmpresas
{
    partial class FormPagoEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoEmpresas));
            this.generar_cmd = new System.Windows.Forms.Button();
            this.explicacion_lbl = new System.Windows.Forms.Label();
            this.seleccionar_cmd = new System.Windows.Forms.Button();
            this.beneficiario_txt = new System.Windows.Forms.TextBox();
            this.beneficiario_lbl = new System.Windows.Forms.Label();
            this.fechaFin_lbl = new System.Windows.Forms.Label();
            this.fechaInicio_lbl = new System.Windows.Forms.Label();
            this.fechaFin_dtp = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio_dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registrarPago_Cmd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // generar_cmd
            // 
            this.generar_cmd.Location = new System.Drawing.Point(394, 49);
            this.generar_cmd.Name = "generar_cmd";
            this.generar_cmd.Size = new System.Drawing.Size(98, 23);
            this.generar_cmd.TabIndex = 19;
            this.generar_cmd.Text = "Generar Listado";
            this.generar_cmd.UseVisualStyleBackColor = true;
            this.generar_cmd.Click += new System.EventHandler(this.generar_cmd_Click);
            // 
            // explicacion_lbl
            // 
            this.explicacion_lbl.AutoSize = true;
            this.explicacion_lbl.Location = new System.Drawing.Point(12, 9);
            this.explicacion_lbl.Name = "explicacion_lbl";
            this.explicacion_lbl.Size = new System.Drawing.Size(416, 13);
            this.explicacion_lbl.TabIndex = 18;
            this.explicacion_lbl.Text = "Permite realizar el pago de las ventas a sus correspondientes empresas o benefici" +
                "arios:";
            // 
            // seleccionar_cmd
            // 
            this.seleccionar_cmd.Location = new System.Drawing.Point(271, 43);
            this.seleccionar_cmd.Name = "seleccionar_cmd";
            this.seleccionar_cmd.Size = new System.Drawing.Size(86, 23);
            this.seleccionar_cmd.TabIndex = 17;
            this.seleccionar_cmd.Text = "Seleccionar...";
            this.seleccionar_cmd.UseVisualStyleBackColor = true;
            this.seleccionar_cmd.Click += new System.EventHandler(this.seleccionar_cmd_Click);
            // 
            // beneficiario_txt
            // 
            this.beneficiario_txt.Location = new System.Drawing.Point(126, 45);
            this.beneficiario_txt.Name = "beneficiario_txt";
            this.beneficiario_txt.Size = new System.Drawing.Size(139, 20);
            this.beneficiario_txt.TabIndex = 16;
            // 
            // beneficiario_lbl
            // 
            this.beneficiario_lbl.AutoSize = true;
            this.beneficiario_lbl.Location = new System.Drawing.Point(7, 48);
            this.beneficiario_lbl.Name = "beneficiario_lbl";
            this.beneficiario_lbl.Size = new System.Drawing.Size(113, 13);
            this.beneficiario_lbl.TabIndex = 15;
            this.beneficiario_lbl.Text = "Empresa o benificiario:";
            // 
            // fechaFin_lbl
            // 
            this.fechaFin_lbl.AutoSize = true;
            this.fechaFin_lbl.Location = new System.Drawing.Point(214, 22);
            this.fechaFin_lbl.Name = "fechaFin_lbl";
            this.fechaFin_lbl.Size = new System.Drawing.Size(69, 13);
            this.fechaFin_lbl.TabIndex = 14;
            this.fechaFin_lbl.Text = "Fecha de fin:";
            // 
            // fechaInicio_lbl
            // 
            this.fechaInicio_lbl.AutoSize = true;
            this.fechaInicio_lbl.Location = new System.Drawing.Point(7, 22);
            this.fechaInicio_lbl.Name = "fechaInicio_lbl";
            this.fechaInicio_lbl.Size = new System.Drawing.Size(82, 13);
            this.fechaInicio_lbl.TabIndex = 13;
            this.fechaInicio_lbl.Text = "Fecha de inicio:";
            // 
            // fechaFin_dtp
            // 
            this.fechaFin_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin_dtp.Location = new System.Drawing.Point(289, 19);
            this.fechaFin_dtp.Name = "fechaFin_dtp";
            this.fechaFin_dtp.Size = new System.Drawing.Size(113, 20);
            this.fechaFin_dtp.TabIndex = 12;
            this.fechaFin_dtp.ValueChanged += new System.EventHandler(this.fechaFin_dtp_ValueChanged);
            // 
            // fechaInicio_dtp
            // 
            this.fechaInicio_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio_dtp.Location = new System.Drawing.Point(95, 19);
            this.fechaInicio_dtp.Name = "fechaInicio_dtp";
            this.fechaInicio_dtp.Size = new System.Drawing.Size(113, 20);
            this.fechaInicio_dtp.TabIndex = 11;
            this.fechaInicio_dtp.ValueChanged += new System.EventHandler(this.fechaInicio_dtp_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaInicio_dtp);
            this.groupBox1.Controls.Add(this.generar_cmd);
            this.groupBox1.Controls.Add(this.fechaInicio_lbl);
            this.groupBox1.Controls.Add(this.fechaFin_dtp);
            this.groupBox1.Controls.Add(this.seleccionar_cmd);
            this.groupBox1.Controls.Add(this.fechaFin_lbl);
            this.groupBox1.Controls.Add(this.beneficiario_txt);
            this.groupBox1.Controls.Add(this.beneficiario_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 78);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 241);
            this.dataGridView1.TabIndex = 21;
            // 
            // registrarPago_Cmd
            // 
            this.registrarPago_Cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registrarPago_Cmd.Location = new System.Drawing.Point(400, 356);
            this.registrarPago_Cmd.Name = "registrarPago_Cmd";
            this.registrarPago_Cmd.Size = new System.Drawing.Size(113, 23);
            this.registrarPago_Cmd.TabIndex = 22;
            this.registrarPago_Cmd.Text = "Registrar Pago";
            this.registrarPago_Cmd.UseVisualStyleBackColor = true;
            this.registrarPago_Cmd.Click += new System.EventHandler(this.registrarPago_Cmd_Click);
            // 
            // FormPagoEmpresas
            // 
            this.AcceptButton = this.generar_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 386);
            this.Controls.Add(this.registrarPago_Cmd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.explicacion_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPagoEmpresas";
            this.ShowInTaskbar = false;
            this.Text = "Pago a Empresas";
            this.Load += new System.EventHandler(this.FormPagoEmpresas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generar_cmd;
        private System.Windows.Forms.Label explicacion_lbl;
        private System.Windows.Forms.Button seleccionar_cmd;
        private System.Windows.Forms.TextBox beneficiario_txt;
        private System.Windows.Forms.Label beneficiario_lbl;
        private System.Windows.Forms.Label fechaFin_lbl;
        private System.Windows.Forms.Label fechaInicio_lbl;
        private System.Windows.Forms.DateTimePicker fechaFin_dtp;
        private System.Windows.Forms.DateTimePicker fechaInicio_dtp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button registrarPago_Cmd;
    }
}