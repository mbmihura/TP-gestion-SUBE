namespace BoletoElectronicoDesktop.AbmPost_Net
{
    partial class FormSeleccionPostnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionPostnet));
            this.postnets_dgv = new System.Windows.Forms.DataGridView();
            this.accion_clm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serie_chk = new System.Windows.Forms.CheckBox();
            this.codigo_nud = new System.Windows.Forms.NumericUpDown();
            this.Limpiar_btn = new System.Windows.Forms.Button();
            this.Buscar_btn = new System.Windows.Forms.Button();
            this.marca_txt = new System.Windows.Forms.TextBox();
            this.modelo_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postnets_dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigo_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // postnets_dgv
            // 
            this.postnets_dgv.AllowUserToAddRows = false;
            this.postnets_dgv.AllowUserToDeleteRows = false;
            this.postnets_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.postnets_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postnets_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accion_clm});
            this.postnets_dgv.Location = new System.Drawing.Point(12, 93);
            this.postnets_dgv.Name = "postnets_dgv";
            this.postnets_dgv.ReadOnly = true;
            this.postnets_dgv.RowTemplate.Height = 24;
            this.postnets_dgv.Size = new System.Drawing.Size(571, 302);
            this.postnets_dgv.TabIndex = 6;
            // 
            // accion_clm
            // 
            this.accion_clm.HeaderText = "Seleccionar";
            this.accion_clm.Name = "accion_clm";
            this.accion_clm.ReadOnly = true;
            this.accion_clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.accion_clm.Text = "Seleccionar...";
            this.accion_clm.UseColumnTextForButtonValue = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.serie_chk);
            this.groupBox3.Controls.Add(this.codigo_nud);
            this.groupBox3.Controls.Add(this.Limpiar_btn);
            this.groupBox3.Controls.Add(this.Buscar_btn);
            this.groupBox3.Controls.Add(this.marca_txt);
            this.groupBox3.Controls.Add(this.modelo_txt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 75);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro de busqueda";
            // 
            // serie_chk
            // 
            this.serie_chk.AutoSize = true;
            this.serie_chk.Location = new System.Drawing.Point(6, 21);
            this.serie_chk.Name = "serie_chk";
            this.serie_chk.Size = new System.Drawing.Size(62, 17);
            this.serie_chk.TabIndex = 35;
            this.serie_chk.Text = "Codigo:";
            this.serie_chk.UseVisualStyleBackColor = true;
            this.serie_chk.CheckedChanged += new System.EventHandler(this.serie_chk_CheckedChanged);
            // 
            // codigo_nud
            // 
            this.codigo_nud.Enabled = false;
            this.codigo_nud.Location = new System.Drawing.Point(74, 20);
            this.codigo_nud.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.codigo_nud.Name = "codigo_nud";
            this.codigo_nud.Size = new System.Drawing.Size(109, 20);
            this.codigo_nud.TabIndex = 34;
            // 
            // Limpiar_btn
            // 
            this.Limpiar_btn.Location = new System.Drawing.Point(6, 46);
            this.Limpiar_btn.Name = "Limpiar_btn";
            this.Limpiar_btn.Size = new System.Drawing.Size(68, 23);
            this.Limpiar_btn.TabIndex = 32;
            this.Limpiar_btn.Text = "Limpiar";
            this.Limpiar_btn.UseVisualStyleBackColor = true;
            this.Limpiar_btn.Click += new System.EventHandler(this.Limpiar_btn_Click);
            // 
            // Buscar_btn
            // 
            this.Buscar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscar_btn.Location = new System.Drawing.Point(465, 46);
            this.Buscar_btn.Name = "Buscar_btn";
            this.Buscar_btn.Size = new System.Drawing.Size(100, 23);
            this.Buscar_btn.TabIndex = 2;
            this.Buscar_btn.Text = "Buscar";
            this.Buscar_btn.UseVisualStyleBackColor = true;
            this.Buscar_btn.Click += new System.EventHandler(this.Buscar_btn_Click);
            // 
            // marca_txt
            // 
            this.marca_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marca_txt.Location = new System.Drawing.Point(258, 19);
            this.marca_txt.Name = "marca_txt";
            this.marca_txt.Size = new System.Drawing.Size(121, 20);
            this.marca_txt.TabIndex = 30;
            // 
            // modelo_txt
            // 
            this.modelo_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modelo_txt.Location = new System.Drawing.Point(446, 19);
            this.modelo_txt.Name = "modelo_txt";
            this.modelo_txt.Size = new System.Drawing.Size(119, 20);
            this.modelo_txt.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Modelo:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Marca:";
            // 
            // FormSeleccionPostnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 407);
            this.Controls.Add(this.postnets_dgv);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeleccionPostnet";
            this.Text = "Seleccion de Postnet";
            ((System.ComponentModel.ISupportInitialize)(this.postnets_dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigo_nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView postnets_dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown codigo_nud;
        private System.Windows.Forms.Button Limpiar_btn;
        private System.Windows.Forms.Button Buscar_btn;
        private System.Windows.Forms.TextBox marca_txt;
        private System.Windows.Forms.TextBox modelo_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox serie_chk;
        private System.Windows.Forms.DataGridViewButtonColumn accion_clm;

    }
}