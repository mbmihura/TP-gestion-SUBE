using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.AbmTarjetas
{
    public partial class ModificacionTarjeta : Form
    {
        private Tarjeta unaTarjeta;
        internal Tarjeta UnaTarjeta
        {
            get { return unaTarjeta; }
            set { unaTarjeta = value; }
        }

        public ModificacionTarjeta()
        {
            InitializeComponent();
        }

        private void ModificacionTarjeta_Load(object sender, EventArgs e)
        {
            txtDni.Text = unaTarjeta.ClienteResponsable.Apellido.Trim(' ') + ", " + unaTarjeta.ClienteResponsable.Nombre.Trim(' ');
            nudNroTarjeta.Value = unaTarjeta.NroTarjeta;
            chEstado.Checked = unaTarjeta.Estado;
            if (unaTarjeta.Estado)
            {
                chEstado.Visible = false;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbmTarjetas.BuscadorCliente objBuscador = new AbmTarjetas.BuscadorCliente();
            objBuscador.ShowDialog(this);
            unaTarjeta.ClienteResponsable = objBuscador.UnCliente;
            if (unaTarjeta.ClienteResponsable != null && unaTarjeta.ClienteResponsable.Apellido != null && unaTarjeta.ClienteResponsable.Nombre != null)
            {
                txtDni.Text = unaTarjeta.ClienteResponsable.Apellido.Trim(' ') + ", " + unaTarjeta.ClienteResponsable.Nombre.Trim(' ');
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                unaTarjeta.NroTarjeta = Convert.ToInt32(nudNroTarjeta.Value);
                unaTarjeta.Estado = chEstado.Visible ? chEstado.Checked : unaTarjeta.Estado;

                if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea modificar la tarjeta nro: " + unaTarjeta.NroTarjeta + " ?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    unaTarjeta.actualizarTarjeta();
                    MessageBox.Show("Edición exitosa!", "Modificación de tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modificación de tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
