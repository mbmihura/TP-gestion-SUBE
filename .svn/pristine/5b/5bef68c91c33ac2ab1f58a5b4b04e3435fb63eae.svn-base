using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Model;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.AbmPost_Net
{
    public partial class FormSeleccionPostnet : Form
    {
        Postnet postnet;
        string origen;

        public FormSeleccionPostnet()
        {
            InitializeComponent();
            postnets_dgv.CellClick += new DataGridViewCellEventHandler(postnets_dgv_CellClick);

        }
        public new Postnet ShowDialog(IWin32Window owner)
        {
            origen = "SELECT POSTNET_NRO_SERIE AS 'Serie/Codigo', POSTNET_MARCA AS 'Marca', POSTNET_MODELO AS 'Modelo' FROM mozilla.Postnets WHERE HABILITADO = 1";
            postnets_dgv.DataSource = DalGral.getDataTable(origen);
            base.ShowDialog(owner);
            return postnet;
        }
        public Postnet ShowDialogParaBeneficiarioYLibres(IWin32Window owner, int idBeneficiario)
        {
            origen = "SELECT POSTNET_NRO_SERIE AS 'Serie/Codigo', POSTNET_MARCA AS 'Marca', POSTNET_MODELO AS 'Modelo' FROM mozilla.Postnets WHERE HABILITADO = 1 AND (BENEFICIARIO_ID IS NULL OR BENEFICIARIO_ID = " + idBeneficiario + ")";
            postnets_dgv.DataSource = DalGral.getDataTable(origen);
            base.ShowDialog(owner);
            return postnet;
        }
        public Postnet ShowDialogLibres(IWin32Window owner)
        {
            origen = "SELECT POSTNET_NRO_SERIE AS 'Serie/Codigo', POSTNET_MARCA AS 'Marca', POSTNET_MODELO AS 'Modelo' FROM mozilla.Postnets WHERE HABILITADO = 1 AND BENEFICIARIO_ID IS NULL ";
            postnets_dgv.DataSource = DalGral.getDataTable(origen);
            base.ShowDialog(owner);
            return postnet;
        }
        public Postnet ShowDialogParaBeneficiario(IWin32Window owner, int idBeneficiario)
        {
            origen = "SELECT POSTNET_NRO_SERIE AS 'Serie/Codigo', POSTNET_MARCA AS 'Marca', POSTNET_MODELO AS 'Modelo' FROM mozilla.Postnets WHERE HABILITADO = 1 AND BENEFICIARIO_ID = " + idBeneficiario;
            postnets_dgv.DataSource = DalGral.getDataTable(origen);
            ShowDialog(owner);
            return postnet;
        }

        private void postnets_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != postnets_dgv.Columns["accion_clm"].Index) return;
            postnet = new Postnet();
            postnet.Codigo = Convert.ToInt32(postnets_dgv["Serie/Codigo", e.RowIndex].Value);
            postnet.Marca = postnets_dgv["Marca", e.RowIndex].Value.ToString();
            postnet.Modelo = postnets_dgv["Modelo", e.RowIndex].Value.ToString();
            Close();
        }
        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            string serie = "";
            if (serie_chk.Checked) serie = " AND POSTNET_NRO_SERIE = " + codigo_nud.Value;
            postnets_dgv.DataSource = DalGral.getDataTable(origen + " AND POSTNET_MARCA LIKE '%" + marca_txt.Text + "%' AND POSTNET_MODELO LIKE '%" + modelo_txt.Text + "%'" + serie);
        }
        private void Limpiar_btn_Click(object sender, EventArgs e)
        {
            serie_chk.Checked = false;
            codigo_nud.Text = "";
            marca_txt.Text = "";
            modelo_txt.Text = "";
        }

        private void serie_chk_CheckedChanged(object sender, EventArgs e)
        {
            codigo_nud.Enabled = serie_chk.Checked;
        }
    }
}
