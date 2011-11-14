using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.AbmUsuario
{
    public partial class FormModificarUsuario : Form
    {

        public int idUsuario;
        public String password;
        public String user;
        public int intentos;
        public bool habilitado;

        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE mozilla.Usuarios SET "
                + "USUARIO_PASSWORD = '" + textBoxModNombre.Text + "', HABILITADO = " + Convert.ToInt32(checkBox1.Checked)
                + " WHERE USUARIO_NOMBRE = '" + user + "';";

            DalGral.ExcecuteNonQuery(consulta);
            try
            {
                MessageBox.Show("El Usuario " + user + " ha sido modificado", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "No se pudo realizar la modificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            this.checkBox1.Checked = habilitado;
        }
    }
}
