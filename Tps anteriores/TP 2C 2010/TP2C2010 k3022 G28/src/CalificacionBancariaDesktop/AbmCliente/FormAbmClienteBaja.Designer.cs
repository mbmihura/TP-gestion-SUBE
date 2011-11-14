namespace CalificacionBancariaDesktop.AbmCliente
{
	partial class FormAbmClienteBaja
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.txtBanco = new System.Windows.Forms.TextBox();
			this.txtBancDir = new System.Windows.Forms.TextBox();
			this.txtBancDirNro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(11, 190);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(753, 254);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(80, 7);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(195, 20);
			this.txtNombre.TabIndex = 0;
			
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(80, 33);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(195, 20);
			this.txtApellido.TabIndex = 1;
			
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(80, 59);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(195, 20);
			this.txtDni.TabIndex = 2;
			
			// 
			// txtBanco
			// 
			this.txtBanco.Location = new System.Drawing.Point(80, 85);
			this.txtBanco.Name = "txtBanco";
			this.txtBanco.Size = new System.Drawing.Size(195, 20);
			this.txtBanco.TabIndex = 3;
			
			// 
			// txtBancDir
			// 
			this.txtBancDir.Location = new System.Drawing.Point(80, 111);
			this.txtBancDir.Name = "txtBancDir";
			this.txtBancDir.Size = new System.Drawing.Size(195, 20);
			this.txtBancDir.TabIndex = 4;
			
			// 
			// txtBancDirNro
			// 
			this.txtBancDirNro.Location = new System.Drawing.Point(80, 137);
			this.txtBancDirNro.Name = "txtBancDirNro";
			this.txtBancDirNro.Size = new System.Drawing.Size(195, 20);
			this.txtBancDirNro.TabIndex = 5;
			
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre";
			
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido";
			
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "DNI";
			
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Banco";
			
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Banc Dir";
			
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Banc Dir Nro";
			
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(319, 47);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 54);
			this.button1.TabIndex = 12;
			this.button1.Text = "Filtrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(11, 450);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.ReadOnly = true;
			this.txtCliente.Size = new System.Drawing.Size(751, 20);
			this.txtCliente.TabIndex = 14;
			
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(307, 485);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 46);
			this.button2.TabIndex = 15;
			this.button2.Text = "Baja";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(238, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Seleccionar Cliente para dar de baja (doble click)";
			
			// 
			// FormAbmClienteBaja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 553);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBancDirNro);
			this.Controls.Add(this.txtBancDir);
			this.Controls.Add(this.txtBanco);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormAbmClienteBaja";
			this.Text = "FormAbmClienteBaja";
			this.Load += new System.EventHandler(this.FormAbmClienteBaja_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.TextBox txtBanco;
		private System.Windows.Forms.TextBox txtBancDir;
		private System.Windows.Forms.TextBox txtBancDirNro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
	}
}