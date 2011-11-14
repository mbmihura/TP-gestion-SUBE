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
    public partial class AltaTarjeta : Form
    {
        private Tarjeta unaTarjeta = new Tarjeta();

        public AltaTarjeta()
        {
            InitializeComponent();
        }

        private void AltaTarjeta_Load(object sender, EventArgs e)
        {
            nudNroTarjeta.Minimum = Tarjeta.nuevoId();
            nudNroTarjeta.Value = nudNroTarjeta.Minimum;
            busquedaCliente();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton.
            if (e.ColumnIndex == dgvClientes.Columns["btnSeleccionar"].Index)
            {
                DataGridViewRow objRow = dgvClientes.Rows[e.RowIndex];

                Cliente unCliente = new Cliente();

                unCliente.Nombre = objRow.Cells[1].Value.ToString();
                unCliente.Apellido = objRow.Cells[2].Value.ToString();
                unCliente.TipoDni = objRow.Cells[3].Value.ToString();
                unCliente.Dni = Convert.ToInt32(objRow.Cells[4].Value);
                unCliente.Mail = objRow.Cells[5].Value.ToString();
                unCliente.Telefono = objRow.Cells[6].Value.ToString();
                unCliente.Dir = new Direccion(objRow.Cells[7].Value.ToString(), Convert.ToInt32(objRow.Cells[8].Value), Convert.ToInt32(objRow.Cells[9].Value), objRow.Cells[10].Value.ToString());
                unCliente.Id = Convert.ToInt32(objRow.Cells[11].Value);

                unaTarjeta.ClienteResponsable = unCliente;

                try
                {
                    unaTarjeta.NroTarjeta = Convert.ToInt32(nudNroTarjeta.Value);
                    unaTarjeta.Fecha = dtpFechaAlta.Value;
                    unaTarjeta.AltaTarjeta();

                    MessageBox.Show("Alta exitosa!","Alta de tarjeta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Alta de tarjeta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void busquedaCliente()
        {
            Cliente unCliente = new Cliente();
            unCliente.Nombre = txtNombre.Text;
            unCliente.Apellido = txtApellido.Text;
            unCliente.TipoDni = cboTpoDni.SelectedItem != null ? cboTpoDni.SelectedItem.ToString() : "";
            unCliente.Dni = Convert.ToInt32(nudDni.Value);
            unCliente.Telefono = txtTelefono.Text;
            unCliente.Mail = txtMail.Text;
            unCliente.Dir = new Direccion(txtCalle.Text, Convert.ToInt32(nudNumero.Value), Convert.ToInt32(nudPiso.Value), txtDepto.Text);

            dgvClientes.DataSource = unCliente.getClientes();
            dgvClientes.Columns[11].Visible = false;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void nudDni_ValueChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void cboTpoDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void nudPiso_ValueChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void txtDepto_TextChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            nudDni.Value = 0;
            txtMail.Text = "";
            txtTelefono.Text = "";
            txtCalle.Text = "";
            txtDepto.Text = "";
            nudNumero.Value = 0;
            nudPiso.Value = 0;
            cboTpoDni.SelectedIndex = 0;

            AltaTarjeta_Load(sender, e);
        }
    }
}
