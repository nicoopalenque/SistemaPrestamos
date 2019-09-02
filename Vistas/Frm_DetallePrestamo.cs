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
    public partial class Frm_DetallePrestamo : Form
    {

        public Frm_DetallePrestamo()
        {
            InitializeComponent();
        }

        private void Frm_DetallePrestamo_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = TrabajarClientes.traerClientesSP();
            cmbCliente.DisplayMember = "nombres";
            cmbCliente.ValueMember = "CLI_DNI";
            cmbCliente.SelectedIndex = -1;
            
            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString(cmbCliente.SelectedValue);
            int nro = Convert.ToInt32(txtPrestamo.Text);
            if (TrabajarPrestamos.buscarPrestamoCliente(dni, nro).Rows.Count <= 0)
            {
                MessageBox.Show("Verifique Cliente y Nro. de Préstamo.", "¡Búsqueda sin resultados!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClaseUtil.limpiarFormulario(gbCuotas);
                ClaseUtil.limpiarFormulario(gbImportes);
            }
            else
            {
                txtDNI.Text = (string)cmbCliente.SelectedValue;
                txtCliente.Text = cmbCliente.Text;
                txtNPrestamo.Text = Convert.ToString(nro);
               
                dgvDetallesPrestamo.DataSource = TrabajarPrestamos.buscarCuotas(nro);

                dgvDetallesPrestamo.Columns[0].Visible = false;

                DataTable tabla = TrabajarPrestamos.buscarCuotas(nro);

                txtPagadas.Text = tabla.Compute("Count(Estado)", "Estado = 'Pagada'").ToString();
                txtPendientes.Text = tabla.Compute("Count(Estado)", "Estado = 'Pendiente'").ToString();
                txtImportePendiente.Text = "$" + tabla.Compute("Sum(Importe)", "Estado = 'Pendiente'").ToString();
                txtImportePago.Text = "$" + tabla.Compute("Sum(Importe)", "Estado = 'Pagada'").ToString();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Frm_ListadoPrestamos oListado = new Frm_ListadoPrestamos();
            this.Close();
            oListado.Show();
        }
    }
}
