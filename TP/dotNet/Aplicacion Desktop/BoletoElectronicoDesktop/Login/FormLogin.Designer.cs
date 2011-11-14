namespace BoletoElectronicoDesktop.Login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.descripcion_lbl = new System.Windows.Forms.Label();
            this.signIn_cmd = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion_lbl
            // 
            this.descripcion_lbl.AutoSize = true;
            this.descripcion_lbl.Location = new System.Drawing.Point(158, 6);
            this.descripcion_lbl.Name = "descripcion_lbl";
            this.descripcion_lbl.Size = new System.Drawing.Size(195, 13);
            this.descripcion_lbl.TabIndex = 25;
            this.descripcion_lbl.Text = "Introduzca sus datos para iniciar sesión:";
            // 
            // signIn_cmd
            // 
            this.signIn_cmd.Location = new System.Drawing.Point(307, 89);
            this.signIn_cmd.Name = "signIn_cmd";
            this.signIn_cmd.Size = new System.Drawing.Size(75, 23);
            this.signIn_cmd.TabIndex = 24;
            this.signIn_cmd.Text = "Log In";
            this.signIn_cmd.UseVisualStyleBackColor = true;
            this.signIn_cmd.Click += new System.EventHandler(this.signIn_cmd_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(249, 63);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(133, 20);
            this.txtPass.TabIndex = 23;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(188, 66);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_lbl.TabIndex = 22;
            this.password_lbl.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(249, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(133, 20);
            this.txtUser.TabIndex = 21;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(188, 40);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(55, 13);
            this.username_lbl.TabIndex = 20;
            this.username_lbl.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::BoletoElectronicoDesktop.Properties.Resources.sube_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.signIn_cmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 133);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descripcion_lbl);
            this.Controls.Add(this.signIn_cmd);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.username_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inicio de Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descripcion_lbl;
        private System.Windows.Forms.Button signIn_cmd;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label username_lbl;
    }
}