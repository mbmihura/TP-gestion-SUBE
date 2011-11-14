namespace BoletoElectronicoDesktop.AbmBeneficiarios
{
    partial class FormAbmBeneficiariosSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbmBeneficiariosSeleccion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.beneficiarios_dgv = new System.Windows.Forms.DataGridView();
            this.boton_clm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rubro_chk = new System.Windows.Forms.CheckBox();
            this.Limpiar_btn = new System.Windows.Forms.Button();
            this.ModFSeleccionar_btn = new System.Windows.Forms.Button();
            this.ModFBuscar_btn = new System.Windows.Forms.Button();
            this.Postnet_txt = new System.Windows.Forms.TextBox();
            this.Direccion_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Razon_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Rubro_cmb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarios_dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.beneficiarios_dgv);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 390);
            this.panel1.TabIndex = 0;
            // 
            // beneficiarios_dgv
            // 
            this.beneficiarios_dgv.AllowUserToAddRows = false;
            this.beneficiarios_dgv.AllowUserToDeleteRows = false;
            this.beneficiarios_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.beneficiarios_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.beneficiarios_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boton_clm});
            this.beneficiarios_dgv.Location = new System.Drawing.Point(3, 110);
            this.beneficiarios_dgv.Name = "beneficiarios_dgv";
            this.beneficiarios_dgv.ReadOnly = true;
            this.beneficiarios_dgv.RowTemplate.Height = 24;
            this.beneficiarios_dgv.Size = new System.Drawing.Size(546, 275);
            this.beneficiarios_dgv.TabIndex = 4;
            // 
            // boton_clm
            // 
            this.boton_clm.HeaderText = "Modificar";
            this.boton_clm.Name = "boton_clm";
            this.boton_clm.ReadOnly = true;
            this.boton_clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boton_clm.Text = "Modificar...";
            this.boton_clm.UseColumnTextForButtonValue = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rubro_chk);
            this.groupBox3.Controls.Add(this.Limpiar_btn);
            this.groupBox3.Controls.Add(this.ModFSeleccionar_btn);
            this.groupBox3.Controls.Add(this.ModFBuscar_btn);
            this.groupBox3.Controls.Add(this.Postnet_txt);
            this.groupBox3.Controls.Add(this.Direccion_txt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Razon_txt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Rubro_cmb);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 101);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro de busqueda";
            // 
            // Rubro_chk
            // 
            this.Rubro_chk.AutoSize = true;
            this.Rubro_chk.Checked = true;
            this.Rubro_chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Rubro_chk.Location = new System.Drawing.Point(222, 47);
            this.Rubro_chk.Name = "Rubro_chk";
            this.Rubro_chk.Size = new System.Drawing.Size(58, 17);
            this.Rubro_chk.TabIndex = 33;
            this.Rubro_chk.Text = "Rubro:";
            this.Rubro_chk.UseVisualStyleBackColor = true;
            this.Rubro_chk.CheckedChanged += new System.EventHandler(this.Rubro_chk_CheckedChanged);
            // 
            // Limpiar_btn
            // 
            this.Limpiar_btn.Location = new System.Drawing.Point(6, 72);
            this.Limpiar_btn.Name = "Limpiar_btn";
            this.Limpiar_btn.Size = new System.Drawing.Size(68, 23);
            this.Limpiar_btn.TabIndex = 32;
            this.Limpiar_btn.Text = "Limpiar";
            this.Limpiar_btn.UseVisualStyleBackColor = true;
            this.Limpiar_btn.Click += new System.EventHandler(this.Limpiar_btn_Click);
            // 
            // ModFSeleccionar_btn
            // 
            this.ModFSeleccionar_btn.Location = new System.Drawing.Point(462, 17);
            this.ModFSeleccionar_btn.Name = "ModFSeleccionar_btn";
            this.ModFSeleccionar_btn.Size = new System.Drawing.Size(75, 23);
            this.ModFSeleccionar_btn.TabIndex = 24;
            this.ModFSeleccionar_btn.Text = "Seccionar...";
            this.ModFSeleccionar_btn.UseVisualStyleBackColor = true;
            this.ModFSeleccionar_btn.Click += new System.EventHandler(this.ModFSeleccionar_btn_Click);
            // 
            // ModFBuscar_btn
            // 
            this.ModFBuscar_btn.Location = new System.Drawing.Point(437, 72);
            this.ModFBuscar_btn.Name = "ModFBuscar_btn";
            this.ModFBuscar_btn.Size = new System.Drawing.Size(100, 23);
            this.ModFBuscar_btn.TabIndex = 2;
            this.ModFBuscar_btn.Text = "Buscar";
            this.ModFBuscar_btn.UseVisualStyleBackColor = true;
            this.ModFBuscar_btn.Click += new System.EventHandler(this.Buscar_btn_Click);
            // 
            // Postnet_txt
            // 
            this.Postnet_txt.Enabled = false;
            this.Postnet_txt.Location = new System.Drawing.Point(328, 19);
            this.Postnet_txt.Name = "Postnet_txt";
            this.Postnet_txt.Size = new System.Drawing.Size(128, 20);
            this.Postnet_txt.TabIndex = 30;
            // 
            // Direccion_txt
            // 
            this.Direccion_txt.Location = new System.Drawing.Point(83, 45);
            this.Direccion_txt.Name = "Direccion_txt";
            this.Direccion_txt.Size = new System.Drawing.Size(130, 20);
            this.Direccion_txt.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Post-net registrados:";
            // 
            // Razon_txt
            // 
            this.Razon_txt.Location = new System.Drawing.Point(83, 19);
            this.Razon_txt.Name = "Razon_txt";
            this.Razon_txt.Size = new System.Drawing.Size(130, 20);
            this.Razon_txt.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Razon social:";
            // 
            // Rubro_cmb
            // 
            this.Rubro_cmb.AllowDrop = true;
            this.Rubro_cmb.DisplayMember = "PROV_NOMBRE";
            this.Rubro_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rubro_cmb.FormattingEnabled = true;
            this.Rubro_cmb.Location = new System.Drawing.Point(328, 45);
            this.Rubro_cmb.Name = "Rubro_cmb";
            this.Rubro_cmb.Size = new System.Drawing.Size(128, 21);
            this.Rubro_cmb.TabIndex = 27;
            // 
            // FormAbmBeneficiariosSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 414);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbmBeneficiariosSeleccion";
            this.Text = "Beneficiario";
            this.Load += new System.EventHandler(this.FormAbmBeneficiariosSeleccion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarios_dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView beneficiarios_dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Rubro_chk;
        private System.Windows.Forms.Button Limpiar_btn;
        private System.Windows.Forms.Button ModFSeleccionar_btn;
        private System.Windows.Forms.Button ModFBuscar_btn;
        private System.Windows.Forms.TextBox Postnet_txt;
        private System.Windows.Forms.TextBox Direccion_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Razon_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Rubro_cmb;
        private System.Windows.Forms.DataGridViewButtonColumn boton_clm;
    }
}