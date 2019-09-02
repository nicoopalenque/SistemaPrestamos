using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClasesBase;

namespace Vistas
{
    public partial class Frm_ListadoPrestamos : Form
    {
        public static int nroPrestamo;
        public static string dniCP;

        public Frm_ListadoPrestamos()
        {
            InitializeComponent();
        }

        private void Frm_ListaPrestamos_Load(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = TrabajarPrestamos.traerPrestamos();

            cmbDestino.SelectedIndexChanged -= new EventHandler(cmbDestino_SelectedIndexChanged);
            
            cmbDestino.DataSource = TrabajarDestinos.traerDestino();
            cmbDestino.DisplayMember = "descripción";
            cmbDestino.ValueMember = "código";
            cmbDestino.SelectedIndex = -1;

            cmbDestino.SelectedIndexChanged += new EventHandler(cmbDestino_SelectedIndexChanged);

            
       

        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestino.SelectedIndex != -1)
            {
                string desc = cmbDestino.Text;
                int filas = TrabajarPrestamos.buscarPrestamoDestino(desc).Rows.Count;

                if (filas > 0)
                {
                    dgvPrestamos.DataSource = TrabajarPrestamos.buscarPrestamoDestino(desc);
                    DataTable tabla = TrabajarPrestamos.buscarPrestamoDestino(desc);
                    txtOtorgados.Text = Convert.ToString(filas);
                    txtPendientes.Text = tabla.Compute("Count(Estado)", "Estado = 'Pendiente'").ToString();
                    txtCancelados.Text = tabla.Compute("Count(Estado)", "Estado = 'Cancelado'").ToString();
                    txtAnulados.Text = tabla.Compute("Count(Estado)", "Estado = 'Anulado'").ToString();
                }
                else
                {
                    MessageBox.Show("No hay préstamos con destino «" + desc + "».", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvPrestamos.DataSource = TrabajarPrestamos.traerPrestamos();
                    ClaseUtil.limpiarFormulario(gbPrestamos);
                }

                ClaseUtil.limpiarFormulario(this);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fDesde = Convert.ToDateTime(dtpFechaDesde.Text);
            DateTime fHasta = Convert.ToDateTime(dtpFechaHasta.Text);
            int filas = TrabajarPrestamos.buscarPorFechas(fDesde, fHasta).Rows.Count;

            if (filas > 0)
            {
                dgvPrestamos.DataSource = TrabajarPrestamos.buscarPorFechas(fDesde, fHasta);
                DataTable tabla = TrabajarPrestamos.buscarPorFechas(fDesde, fHasta);
                txtOtorgados.Text = Convert.ToString(filas);
                txtPendientes.Text = tabla.Compute("Count(Estado)", "Estado = 'Pendiente'").ToString();
                txtCancelados.Text = tabla.Compute("Count(Estado)", "Estado = 'Cancelado'").ToString();
                txtAnulados.Text = tabla.Compute("Count(Estado)", "Estado = 'Anulado'").ToString();
            }
            else
            {
                MessageBox.Show("No hay préstamos registrados en ese periodo.", "¡Búqueda sin Resultados!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvPrestamos.DataSource = TrabajarPrestamos.traerPrestamos();
                ClaseUtil.limpiarFormulario(gbPrestamos);
            }
            ClaseUtil.limpiarFormulario(this);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
           
            if (txtNroPrestamo.Text != String.Empty)
            {
                int nro = Convert.ToInt32(txtNroPrestamo.Text);

                if (TrabajarPrestamos.buscarCuotaxPrestamo(nro).Rows.Count > 0)
                {
                    MessageBox.Show("No es posible cancelar el préstamos.\nEl préstamo posee cuotas pagadas.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TrabajarPrestamos.AnularPrestamo(nro);
                    MessageBox.Show("El préstamo se anuló correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPrestamos.DataSource = TrabajarPrestamos.traerPrestamos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese Nro. de Préstamos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DetallePrestamo oFrmDetalle = new Frm_DetallePrestamo();
            oFrmDetalle.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oFrmPrincipal = new Frm_Principal();
            oFrmPrincipal.Show();
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        
    }
}
