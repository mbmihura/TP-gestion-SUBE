namespace CalificacionBancariaDesktop.ConsultaPlazoFijo
{
    partial class FormConsultaPlazoFijo
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
            this.tbNOM = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbBANCO = new System.Windows.Forms.TextBox();
            this.tbSUCUDIR = new System.Windows.Forms.TextBox();
            this.tbFECCREA = new System.Windows.Forms.TextBox();
            this.tbFECFIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSUCUNUM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAPE = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNOM
            // 
            this.tbNOM.Location = new System.Drawing.Point(12, 22);
            this.tbNOM.Name = "tbNOM";
            this.tbNOM.Size = new System.Drawing.Size(112, 20);
            this.tbNOM.TabIndex = 0;
            this.tbNOM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(278, 22);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(134, 20);
            this.tbDNI.TabIndex = 1;
            this.tbDNI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbBANCO
            // 
            this.tbBANCO.Location = new System.Drawing.Point(12, 69);
            this.tbBANCO.Name = "tbBANCO";
            this.tbBANCO.Size = new System.Drawing.Size(112, 20);
            this.tbBANCO.TabIndex = 2;
            // 
            // tbSUCUDIR
            // 
            this.tbSUCUDIR.Location = new System.Drawing.Point(42, 19);
            this.tbSUCUDIR.Name = "tbSUCUDIR";
            this.tbSUCUDIR.Size = new System.Drawing.Size(114, 20);
            this.tbSUCUDIR.TabIndex = 3;
            // 
            // tbFECCREA
            // 
            this.tbFECCREA.Location = new System.Drawing.Point(12, 120);
            this.tbFECCREA.Name = "tbFECCREA";
            this.tbFECCREA.Size = new System.Drawing.Size(112, 20);
            this.tbFECCREA.TabIndex = 4;
            // 
            // tbFECFIN
            // 
            this.tbFECFIN.Location = new System.Drawing.Point(142, 120);
            this.tbFECFIN.Name = "tbFECFIN";
            this.tbFECFIN.Size = new System.Drawing.Size(114, 20);
            this.tbFECFIN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Creación";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Finalización";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSUCUNUM
            // 
            this.tbSUCUNUM.Location = new System.Drawing.Point(195, 19);
            this.tbSUCUNUM.Name = "tbSUCUNUM";
            this.tbSUCUNUM.Size = new System.Drawing.Size(73, 20);
            this.tbSUCUNUM.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nro.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Calle";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbSUCUNUM);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSUCUDIR);
            this.groupBox1.Location = new System.Drawing.Point(142, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 51);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sucursal";
            // 
            // tbAPE
            // 
            this.tbAPE.Location = new System.Drawing.Point(142, 22);
            this.tbAPE.Name = "tbAPE";
            this.tbAPE.Size = new System.Drawing.Size(112, 20);
            this.tbAPE.TabIndex = 18;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(150, 6);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 19;
            this.Apellido.Text = "Apellido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::CalificacionBancariaDesktop.Properties.Settings.Default, "f", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = global::CalificacionBancariaDesktop.Properties.Settings.Default.f;
            this.dataGridView1.Size = new System.Drawing.Size(669, 229);
            this.dataGridView1.TabIndex = 13;
            // 
            // FormConsultaPlazoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 401);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.tbAPE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFECFIN);
            this.Controls.Add(this.tbFECCREA);
            this.Controls.Add(this.tbBANCO);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbNOM);
            this.Name = "FormConsultaPlazoFijo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Plazos Fijos";
            this.Load += new System.EventHandler(this.FormConsultaPlazoFijo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNOM;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbBANCO;
        private System.Windows.Forms.TextBox tbSUCUDIR;
        private System.Windows.Forms.TextBox tbFECCREA;
        private System.Windows.Forms.TextBox tbFECFIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSUCUNUM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAPE;
        private System.Windows.Forms.Label Apellido;
    }
}