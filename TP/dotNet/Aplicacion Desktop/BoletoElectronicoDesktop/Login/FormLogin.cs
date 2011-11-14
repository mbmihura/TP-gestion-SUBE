using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Datos;
using System.Security.Cryptography;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void signIn_cmd_Click(object sender, EventArgs e)
        {
            Close();//TODO despues sacarlo
            Usuario unUsuario = new Usuario();
            unUsuario.User = txtUser.Text;
            unUsuario.Pass = Encriptar.sha256(txtPass.Text);
            try
            {
                if (unUsuario.loguear())
                {
                    unUsuario.intentoFallido(0);
                    Close();
                }
                else
                {
                    if (!unUsuario.intentoFallido() && unUsuario.IdUsuario > 0)
                    {
                        MessageBox.Show("Usuario bloqueado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                       MessageBox.Show("Usuario y/o contraseña invalido/s.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Intente conectarse más tarde", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
