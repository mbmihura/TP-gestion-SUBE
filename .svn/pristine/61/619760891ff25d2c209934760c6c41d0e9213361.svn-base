using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.AbmUsuario
{
    public partial class FrmBuscadorUsuario : Form
    {
        public const int Eliminacion = 2;
        private int tipoUso;
        public int TipoUso
        {
            get { return tipoUso; }
            set { tipoUso = value; }
        }

        public FrmBuscadorUsuario()
        {
            InitializeComponent();
        }


        private void FrmBuscadorUsuario_Load(object sender, EventArgs e)
        {
            if (tipoUso == Eliminacion)
            {
                ((DataGridViewButtonColumn)dgwUsuarios.Columns["btnSeleccionar"]).Text = "Eliminar";
            }
            busquedaUsuarios();
        }

        private void busquedaUsuarios()
        {
            dgwUsuarios.DataSource = Usuario.getUsuarios();
            dgwUsuarios.Columns[3].Visible = false;
        }

        private void dgwUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwUsuarios.Columns["btnSeleccionar"].Index)
            {
                DataGridViewRow objRow = dgwUsuarios.Rows[e.RowIndex];
                Usuario unUsuario = new Usuario();

                unUsuario.User = objRow.Cells[1].Value.ToString();
                unUsuario.Estado = (Boolean)objRow.Cells[2].Value;
                unUsuario.IdUsuario = Convert.ToInt32(objRow.Cells[3].Value);
                unUsuario.getRoles();

                if (tipoUso != Eliminacion)
                {

                    frmModificacion frmModif = new frmModificacion();
                    frmModif.UnUsuario = unUsuario;
                    frmModif.ShowDialog(this);
                    FrmBuscadorUsuario_Load(sender, e);

                }
                else
                {
                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea eliminar el usuario: " + unUsuario.User, "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            unUsuario.eliminarUsuario();
                            MessageBox.Show("Eliminación exitosa!", "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmBuscadorUsuario_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
