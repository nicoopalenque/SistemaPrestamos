    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class Frm_ListadoPagos : Form
    {
        public Frm_ListadoPagos()
        {
            InitializeComponent();
        }
                
        private void Frm_ListadoPagos_Load(object sender, EventArgs e)
        {
            dgvPagos.DataSource = TrabajarPagos.listarPagos();
            dgvPagos.Columns["DNI"].Visible = false;

            cmbClientes.SelectedIndexChanged -= new EventHandler(cmbClientes_SelectedIndexChanged);

            cmbClientes.DataSource = TrabajarClientes.traerClientesSP();
            cmbClientes.DisplayMember = "nombres";
            cmbClientes.ValueMember = "CLI_DNI";
            cmbClientes.SelectedIndex = -1;

            cmbClientes.SelectedIndexChanged += new EventHandler(cmbClientes_SelectedIndexChanged);
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex != -1)
            {
                string dni = Convert.ToString(cmbClientes.SelectedValue);
                int filas = TrabajarPagos.listarPagosCliente(dni).Rows.Count;
                if (filas > 0)
                {
                    dgvPagos.DataSource = TrabajarPagos.listarPagosCliente(dni);
                    txtPagos.Text = Convert.ToString(filas);
                    txtImporte.Text = "$ " + TrabajarPagos.listarPagosCliente(dni).Compute("sum(importe)", "").ToString();
                }
                else
                {
                    MessageBox.Show("El cliente no ha realizado pagos.", "¡Error de Búsqueda!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClaseUtil.limpiarFormulario(gbPago);
                }
            }            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClaseUtil.limpiarFormulario(gbPago);

            if (cmbClientes.SelectedIndex != -1)
            {
                DateTime fDesde = Convert.ToDateTime(dtpFechaDesde.Text);
                DateTime fHasta = Convert.ToDateTime(dtpFechaHasta.Text);
                string dni = Convert.ToString(cmbClientes.SelectedValue);

                int filas = TrabajarPagos.buscarPorFechas(fDesde, fHasta, dni).Rows.Count;

                if (filas > 0)
                {
                    dgvPagos.DataSource = TrabajarPagos.buscarPorFechas(fDesde, fHasta, dni);
                    txtPagos.Text = Convert.ToString(filas);
                    txtImporte.Text = "$ " + TrabajarPagos.buscarPorFechas(fDesde, fHasta, dni).Compute("sum(importe)", "").ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.", "¡Error de Búsqueda!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Seleccione Cliente y/o rango de fechas.", "¡AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oFrmPrincipal = new Frm_Principal();
            oFrmPrincipal.Show();
        }
    }
}
