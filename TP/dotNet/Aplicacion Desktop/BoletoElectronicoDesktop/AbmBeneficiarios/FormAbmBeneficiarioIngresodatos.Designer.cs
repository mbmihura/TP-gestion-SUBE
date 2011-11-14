namespace BoletoElectronicoDesktop.AbmBeneficiarios
{
    partial class FormAbmBeneficiarioIngresodatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbmBeneficiarioIngresodatos));
            this.main_pnl = new System.Windows.Forms.Panel();
            this.Habilitado_chk = new System.Windows.Forms.CheckBox();
            this.Descripcion_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rubro_cmb = new System.Windows.Forms.ComboBox();
            this.Postnet_dgv = new System.Windows.Forms.DataGridView();
            this.desasignar_clm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Di = new System.Windows.Forms.GroupBox();
            this.Numero_nud = new System.Windows.Forms.NumericUpDown();
            this.Piso_nud = new System.Windows.Forms.NumericUpDown();
            this.Calle_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Depto_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PostnetModificar_btn = new System.Windows.Forms.Button();
            this.Razon_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Limpiar_cmd = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.main_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Postnet_dgv)).BeginInit();
            this.Di.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piso_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // main_pnl
            // 
            this.main_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.main_pnl.BackColor = System.Drawing.SystemColors.Window;
            this.main_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_pnl.Controls.Add(this.Habilitado_chk);
            this.main_pnl.Controls.Add(this.Descripcion_lbl);
            this.main_pnl.Controls.Add(this.panel2);
            this.main_pnl.Controls.Add(this.Postnet_dgv);
            this.main_pnl.Controls.Add(this.Di);
            this.main_pnl.Controls.Add(this.PostnetModificar_btn);
            this.main_pnl.Controls.Add(this.Razon_txt);
            this.main_pnl.Controls.Add(this.label9);
            this.main_pnl.Controls.Add(this.label8);
            this.main_pnl.Controls.Add(this.label12);
            this.main_pnl.Location = new System.Drawing.Point(12, 12);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(471, 348);
            this.main_pnl.TabIndex = 1;
            // 
            // Habilitado_chk
            // 
            this.Habilitado_chk.AutoSize = true;
            this.Habilitado_chk.Location = new System.Drawing.Point(298, 25);
            this.Habilitado_chk.Name = "Habilitado_chk";
            this.Habilitado_chk.Size = new System.Drawing.Size(73, 17);
            this.Habilitado_chk.TabIndex = 36;
            this.Habilitado_chk.Text = "Habilitado";
            this.Habilitado_chk.UseVisualStyleBackColor = true;
            // 
            // Descripcion_lbl
            // 
            this.Descripcion_lbl.AutoSize = true;
            this.Descripcion_lbl.Location = new System.Drawing.Point(1, 4);
            this.Descripcion_lbl.Name = "Descripcion_lbl";
            this.Descripcion_lbl.Size = new System.Drawing.Size(164, 13);
            this.Descripcion_lbl.TabIndex = 35;
            this.Descripcion_lbl.Text = "Ingrese los datos del beneficiario:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.Rubro_cmb);
            this.panel2.Location = new System.Drawing.Point(109, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 27);
            this.panel2.TabIndex = 34;
            // 
            // Rubro_cmb
            // 
            this.Rubro_cmb.AllowDrop = true;
            this.Rubro_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rubro_cmb.DisplayMember = "PROV_NOMBRE";
            this.Rubro_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rubro_cmb.FormattingEnabled = true;
            this.Rubro_cmb.Location = new System.Drawing.Point(3, 3);
            this.Rubro_cmb.Name = "Rubro_cmb";
            this.Rubro_cmb.Size = new System.Drawing.Size(168, 21);
            this.Rubro_cmb.TabIndex = 9;
            this.Rubro_cmb.ValueMember = "PROV_ID";
            // 
            // Postnet_dgv
            // 
            this.Postnet_dgv.AllowUserToAddRows = false;
            this.Postnet_dgv.AllowUserToDeleteRows = false;
            this.Postnet_dgv.AllowUserToOrderColumns = true;
            this.Postnet_dgv.AllowUserToResizeRows = false;
            this.Postnet_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Postnet_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Postnet_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desasignar_clm});
            this.Postnet_dgv.Location = new System.Drawing.Point(112, 183);
            this.Postnet_dgv.Name = "Postnet_dgv";
            this.Postnet_dgv.RowHeadersVisible = false;
            this.Postnet_dgv.RowTemplate.Height = 24;
            this.Postnet_dgv.Size = new System.Drawing.Size(252, 121);
            this.Postnet_dgv.TabIndex = 33;
            // 
            // desasignar_clm
            // 
            this.desasignar_clm.HeaderText = "Desasignar";
            this.desasignar_clm.Name = "desasignar_clm";
            this.desasignar_clm.ReadOnly = true;
            this.desasignar_clm.Text = "Desasignar";
            this.desasignar_clm.UseColumnTextForButtonValue = true;
            // 
            // Di
            // 
            this.Di.Controls.Add(this.Numero_nud);
            this.Di.Controls.Add(this.Piso_nud);
            this.Di.Controls.Add(this.Calle_txt);
            this.Di.Controls.Add(this.label1);
            this.Di.Controls.Add(this.Depto_txt);
            this.Di.Controls.Add(this.label4);
            this.Di.Controls.Add(this.label2);
            this.Di.Controls.Add(this.label3);
            this.Di.Location = new System.Drawing.Point(6, 49);
            this.Di.Name = "Di";
            this.Di.Size = new System.Drawing.Size(397, 128);
            this.Di.TabIndex = 32;
            this.Di.TabStop = false;
            this.Di.Text = "Dirección";
            // 
            // Numero_nud
            // 
            this.Numero_nud.Location = new System.Drawing.Point(107, 45);
            this.Numero_nud.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.Numero_nud.Name = "Numero_nud";
            this.Numero_nud.Size = new System.Drawing.Size(74, 20);
            this.Numero_nud.TabIndex = 23;
            // 
            // Piso_nud
            // 
            this.Piso_nud.Location = new System.Drawing.Point(107, 71);
            this.Piso_nud.Name = "Piso_nud";
            this.Piso_nud.Size = new System.Drawing.Size(44, 20);
            this.Piso_nud.TabIndex = 22;
            // 
            // Calle_txt
            // 
            this.Calle_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Calle_txt.Location = new System.Drawing.Point(107, 19);
            this.Calle_txt.Name = "Calle_txt";
            this.Calle_txt.Size = new System.Drawing.Size(130, 20);
            this.Calle_txt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número:";
            // 
            // Depto_txt
            // 
            this.Depto_txt.Location = new System.Drawing.Point(107, 97);
            this.Depto_txt.Name = "Depto_txt";
            this.Depto_txt.Size = new System.Drawing.Size(44, 20);
            this.Depto_txt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Piso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Depto:";
            // 
            // PostnetModificar_btn
            // 
            this.PostnetModificar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostnetModificar_btn.Location = new System.Drawing.Point(370, 183);
            this.PostnetModificar_btn.Name = "PostnetModificar_btn";
            this.PostnetModificar_btn.Size = new System.Drawing.Size(75, 23);
            this.PostnetModificar_btn.TabIndex = 31;
            this.PostnetModificar_btn.Text = "Asignar...";
            this.PostnetModificar_btn.UseVisualStyleBackColor = true;
            this.PostnetModificar_btn.Click += new System.EventHandler(this.PostnetModificar_btn_Click);
            // 
            // Razon_txt
            // 
            this.Razon_txt.Location = new System.Drawing.Point(80, 23);
            this.Razon_txt.Name = "Razon_txt";
            this.Razon_txt.Size = new System.Drawing.Size(201, 20);
            this.Razon_txt.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Rubro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Post-net registrados:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Razon social:";
            // 
            // Limpiar_cmd
            // 
            this.Limpiar_cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Limpiar_cmd.Location = new System.Drawing.Point(12, 366);
            this.Limpiar_cmd.Name = "Limpiar_cmd";
            this.Limpiar_cmd.Size = new System.Drawing.Size(100, 23);
            this.Limpiar_cmd.TabIndex = 5;
            this.Limpiar_cmd.Text = "Limpiar";
            this.Limpiar_cmd.UseVisualStyleBackColor = true;
            this.Limpiar_cmd.Click += new System.EventHandler(this.Limpiar_cmd_Click);
            // 
            // OK_btn
            // 
            this.OK_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK_btn.Location = new System.Drawing.Point(383, 366);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(100, 23);
            this.OK_btn.TabIndex = 4;
            this.OK_btn.Text = "Guardar";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // FormAbmBeneficiarioIngresodatos
            // 
            this.AcceptButton = this.OK_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 401);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.Limpiar_cmd);
            this.Controls.Add(this.OK_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbmBeneficiarioIngresodatos";
            this.Text = "Beneficiario";
            this.Load += new System.EventHandler(this.FormAbmBeneficiarioIngresodatos_Load);
            this.main_pnl.ResumeLayout(false);
            this.main_pnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Postnet_dgv)).EndInit();
            this.Di.ResumeLayout(false);
            this.Di.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piso_nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.Button Limpiar_cmd;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Rubro_cmb;
        private System.Windows.Forms.DataGridView Postnet_dgv;
        private System.Windows.Forms.GroupBox Di;
        private System.Windows.Forms.NumericUpDown Numero_nud;
        private System.Windows.Forms.NumericUpDown Piso_nud;
        private System.Windows.Forms.TextBox Calle_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Depto_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PostnetModificar_btn;
        private System.Windows.Forms.TextBox Razon_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Descripcion_lbl;
        private System.Windows.Forms.CheckBox Habilitado_chk;
        private System.Windows.Forms.DataGridViewButtonColumn desasignar_clm;
    }
}