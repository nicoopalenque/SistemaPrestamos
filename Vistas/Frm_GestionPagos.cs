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
    public partial class Frm_GestionPagos : Form
    {
        public Frm_GestionPagos()
        {
            InitializeComponent();
        }

        private void Frm_GestionPagos_Load(object sender, EventArgs e)
        {            
            cmbCliente.SelectedIndexChanged -= new EventHandler(cmbCliente_SelectedIndexChanged);
            
            cmbCliente.DisplayMember = "nombres";
            cmbCliente.ValueMember = "CLI_DNI";
            cmbCliente.DataSource = TrabajarClientes.traerClientesSP();
            cmbCliente.SelectedIndex = -1;
            
            cmbCliente.SelectedIndexChanged += new EventHandler(cmbCliente_SelectedIndexChanged);           
        }

        private void loadCmbPrestamo(string dni) 
        {            
            if (TrabajarPrestamos.traerPrestamosCliente(dni).Rows.Count >0) 
            {
                cmbPrestamo.SelectedIndexChanged -= new EventHandler(cmbPrestamo_SelectedIndexChanged);

                cmbPrestamo.DataSource = TrabajarPrestamos.traerPrestamosCliente(dni);
                cmbPrestamo.DisplayMember = "pre_numero";
                cmbPrestamo.ValueMember = "pre_numero";
                cmbPrestamo.SelectedIndex = -1;

                cmbPrestamo.SelectedIndexChanged += new EventHandler(cmbPrestamo_SelectedIndexChanged);
            }
            else
            {
                MessageBox.Show("El cliente no tiene préstamos asociados.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClaseUtil.limpiarFormulario(this);
            }
        }

        private void loadCmbCuota(int nro)
        {
            if (TrabajarCuotas.traerCuotaPrestamo(nro).Rows.Count > 0)
            {
                cmbCuota.DataSource = TrabajarCuotas.traerCuotaPrestamo(nro);
                cmbCuota.DisplayMember = "cuo_numero";
                cmbCuota.ValueMember = "cuo_codigo";
            }
            else
            {
                MessageBox.Show("El cliente no tiene cuotas pendientes.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClaseUtil.limpiarFormulario(this);
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex != -1)
            {
                string dni = Convert.ToString(cmbCliente.SelectedValue);
                loadCmbPrestamo(dni);
            }
        }

        private void cmbPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrestamo.SelectedIndex != -1)
            {
                int nro = Convert.ToInt32(cmbPrestamo.SelectedValue);
                loadCmbCuota(nro);
            }
        }

        private void cmbCuota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCuota.SelectedIndex != -1)
            {
                DataRowView drv = (DataRowView)cmbCuota.SelectedItem;

                txtImporte.Text = drv[4].ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Registar pago?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Pago oPago = new Pago();
                oPago.CUO_Codigo = Convert.ToInt32(cmbCuota.SelectedValue);
                oPago.PAG_Fecha = Convert.ToDateTime(dtpFecha.Text);
                oPago.PAG_Importe = Convert.ToDecimal(txtImporte.Text);

                TrabajarPagos.agregarPago(oPago);

                MessageBox.Show("El pago se ha efectuado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TrabajarCuotas.cambiarEstadoCuota(oPago.CUO_Codigo);

                int nro = Convert.ToInt32(cmbPrestamo.SelectedValue);

                if (TrabajarCuotas.traerCuotaPrestamo(nro).Rows.Count <= 0)
                {
                    TrabajarPrestamos.cambiarEstadoPrestamo(nro);
                }
            }
            ClaseUtil.limpiarFormulario(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oFrmPrincipal = new Frm_Principal();
            oFrmPrincipal.Show();
        }






    }
}
