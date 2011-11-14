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
    public partial class FiltroBusquedaTarjeta : Form
    {
        public const int Eliminacion = 2;

        private int tipoUso;
        public int TipoUso
        {
            get { return tipoUso; }
            set { tipoUso = value; }
        }

        private Cliente unCliente;

        public FiltroBusquedaTarjeta()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            unCliente = null;
            btnSeleccionarCliente.Text = "Selección de cliente";
            chCliente.Checked = false;
            chFechaAlta.Checked = false;
            chNroTarjeta.Checked = false;
            nudNroTarjeta.Value = 0;

            FiltroBusquedaTarjeta_Load(sender, e);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns["btnSeleccionar"].Index)
            {
                DataGridViewRow objRow = dgvClientes.Rows[e.RowIndex];
                Tarjeta unaTarjeta = new Tarjeta();
                unaTarjeta.NroTarjeta = Convert.ToInt32(objRow.Cells[1].Value);
                String fecha = objRow.Cells[2].Value.ToString();
                String dia = fecha.Split('/')[0];
                String mes = fecha.Split('/')[1];
                String anio = fecha.Split('/')[2];
                anio = anio.Split(' ')[0];

                unaTarjeta.Fecha = new DateTime(Convert.ToInt32(anio), Convert.ToInt32(mes), Convert.ToInt32(dia));
                unaTarjeta.ClienteResponsable = Cliente.getCliente(Convert.ToInt32(objRow.Cells[3].Value));
                unaTarjeta.Estado = (Boolean)objRow.Cells[4].Value;
                unaTarjeta.IdTarjeta = Convert.ToInt32(objRow.Cells[5].Value);

                if (tipoUso != Eliminacion)
                {
                    AbmTarjetas.ModificacionTarjeta objModificacion = new AbmTarjetas.ModificacionTarjeta();
                    objModificacion.UnaTarjeta = unaTarjeta;
                    objModificacion.ShowDialog(this);
                }
                else
                {
                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea eliminar la tarjeta nro: " + unaTarjeta.NroTarjeta + " ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            unaTarjeta.eliminarTarjeta();
                            MessageBox.Show("Eliminación exitosa!", "Baja de Tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja de Tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                btnLimpiar_Click(sender, e);
            }
        }

        private void FiltroBusquedaTarjeta_Load(object sender, EventArgs e)
        {
            if (tipoUso == Eliminacion)
            {
               ((DataGridViewButtonColumn)dgvClientes.Columns["btnSeleccionar"]).Text = "Eliminar";
            }
            busquedaCliente();
        }

        private void busquedaCliente()
        {
            Tarjeta unaTarjeta = new Tarjeta();
            unaTarjeta.ClienteResponsable = unCliente;
            unaTarjeta.NroTarjeta = chNroTarjeta.Checked ?
                Convert.ToInt32(nudNroTarjeta.Value) : 0;
            if(chFechaAlta.Checked)
            {
                unaTarjeta.Fecha = dtpFechaAlta.Value;
            }

            dgvClientes.DataSource = unaTarjeta.getTarjetas();
            dgvClientes.Columns[5].Visible = false;
        }

        private void nudNroTarjeta_ValueChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void dtpFechaAlta_ValueChanged(object sender, EventArgs e)
        {
            busquedaCliente();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            
            AbmTarjetas.BuscadorCliente objBuscador = new AbmTarjetas.BuscadorCliente();
            objBuscador.ShowDialog(this);
            unCliente = objBuscador.UnCliente;
            if (unCliente != null && unCliente.Apellido != null && unCliente.Nombre != null)
            {
                btnSeleccionarCliente.Text = unCliente.Apellido.Trim(' ') + ", " + unCliente.Nombre.Trim(' '); ;
                busquedaCliente();
            }
        }

        private void chFechaAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (chFechaAlta.Checked)
            {
                dtpFechaAlta.Enabled = true;
            }
            else
            {
                dtpFechaAlta.Enabled = false;
            }
        }

        private void chNroTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (chNroTarjeta.Checked)
            {
                nudNroTarjeta.Enabled = true;
            }
            else
            {
                nudNroTarjeta.Enabled = false;
            }
        }

        private void chCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chCliente.Checked)
            {
                btnSeleccionarCliente.Enabled = true;
            }
            else
            {
                btnSeleccionarCliente.Enabled = false;
            }
        }
    }
}
