namespace BoletoElectronicoDesktop.TarjetasPremium
{
    partial class FormTarjetasPremium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarjetasPremium));
            this.mostrar_cmd = new System.Windows.Forms.Button();
            this.anio_nud = new System.Windows.Forms.NumericUpDown();
            this.anio_lbl = new System.Windows.Forms.Label();
            this.explicacion_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.explicacion2_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anio_nud)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrar_cmd
            // 
            this.mostrar_cmd.Location = new System.Drawing.Point(170, 12);
            this.mostrar_cmd.Name = "mostrar_cmd";
            this.mostrar_cmd.Size = new System.Drawing.Size(75, 23);
            this.mostrar_cmd.TabIndex = 7;
            this.mostrar_cmd.Text = "Mostrar";
            this.mostrar_cmd.UseVisualStyleBackColor = true;
            this.mostrar_cmd.Click += new System.EventHandler(this.mostrar_cmd_Click);
            // 
            // anio_nud
            // 
            this.anio_nud.Location = new System.Drawing.Point(87, 14);
            this.anio_nud.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.anio_nud.Minimum = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            this.anio_nud.Name = "anio_nud";
            this.anio_nud.Size = new System.Drawing.Size(73, 20);
            this.anio_nud.TabIndex = 6;
            this.anio_nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.anio_nud.Value = new decimal(new int[] {
            1995,
            0,
            0,
            0});
            // 
            // anio_lbl
            // 
            this.anio_lbl.AutoSize = true;
            this.anio_lbl.Location = new System.Drawing.Point(6, 16);
            this.anio_lbl.Name = "anio_lbl";
            this.anio_lbl.Size = new System.Drawing.Size(75, 13);
            this.anio_lbl.TabIndex = 5;
            this.anio_lbl.Text = "Año a mostrar:";
            // 
            // explicacion_lbl
            // 
            this.explicacion_lbl.AutoSize = true;
            this.explicacion_lbl.Location = new System.Drawing.Point(9, 9);
            this.explicacion_lbl.Name = "explicacion_lbl";
            this.explicacion_lbl.Size = new System.Drawing.Size(237, 13);
            this.explicacion_lbl.TabIndex = 4;
            this.explicacion_lbl.Text = "Permite visualizar los clientes que mas facturaron";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anio_nud);
            this.groupBox1.Controls.Add(this.mostrar_cmd);
            this.groupBox1.Controls.Add(this.anio_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 41);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 295);
            this.dataGridView1.TabIndex = 9;
            // 
            // explicacion2_lbl
            // 
            this.explicacion2_lbl.AutoSize = true;
            this.explicacion2_lbl.Location = new System.Drawing.Point(9, 69);
            this.explicacion2_lbl.Name = "explicacion2_lbl";
            this.explicacion2_lbl.Size = new System.Drawing.Size(157, 13);
            this.explicacion2_lbl.TabIndex = 10;
            this.explicacion2_lbl.Text = "30 clientes que mas compraron:";
            // 
            // FormTarjetasPremium
            // 
            this.AcceptButton = this.mostrar_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 392);
            this.Controls.Add(this.explicacion2_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.explicacion_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTarjetasPremium";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Premium";
            this.Load += new System.EventHandler(this.FormTarjetasPremium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anio_nud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrar_cmd;
        private System.Windows.Forms.NumericUpDown anio_nud;
        private System.Windows.Forms.Label anio_lbl;
        private System.Windows.Forms.Label explicacion_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label explicacion2_lbl;
    }
}