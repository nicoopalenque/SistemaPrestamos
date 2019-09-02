using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Globalization;
using System.Threading;
namespace Vistas
{
    public partial class Frm_GestionPrestamos : Form
    {
        public Frm_GestionPrestamos()
        {
            InitializeComponent();
        }

        private void Frm_GestionPrestamo_Load(object sender, EventArgs e)
        {
            cmbDestino.DataSource = TrabajarDestinos.traerDestino();
            cmbDestino.DisplayMember = "Descripción";            
            cmbDestino.ValueMember = "Código";
            cmbDestino.SelectedIndex = -1;
            
            cmbCliente.DataSource = TrabajarClientes.traerClientesSP();
            cmbCliente.DisplayMember = "nombres";         
            cmbCliente.ValueMember = "CLI_DNI";
            cmbCliente.SelectedIndex = -1;
            
            cmbPeriodo.DataSource = TrabajarPeriodos.traerPeriodo();
            cmbPeriodo.DisplayMember = "PER_Descripcion";
            cmbPeriodo.ValueMember = "PER_Codigo";
            cmbPeriodo.SelectedIndex = -1;
        }       
                
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea generar el préstamo?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(respuesta == DialogResult.Yes){

                Prestamo oPrestamo = new Prestamo();
                Cuota oCuota = new Cuota();

                decimal importe=Convert.ToDecimal(txtImporte.Text);
                decimal tasa =  Convert.ToDecimal(txtTasaInteres.Text);
                int cuota= Convert.ToInt32(txtCuotas.Text);

                decimal totalImporte = (importe + ((importe*tasa)/100))/cuota ;

                DateTime fecha = Convert.ToDateTime(dtpFecha.Text, new CultureInfo("es-ES"));
                
                oPrestamo.CLI_DNI = (string)cmbCliente.SelectedValue;
                oPrestamo.DES_Codigo = (Int32)cmbDestino.SelectedValue;
                oPrestamo.PER_Codigo = (Int32)cmbPeriodo.SelectedValue;
                oPrestamo.PRE_Fecha =  Convert.ToDateTime(dtpFecha.Text);
                oPrestamo.PRE_Importe = importe;
                oPrestamo.PRE_TasaInteres = Convert.ToDecimal(txtTasaInteres.Text);
                oPrestamo.PRE_CantidadCuotas = Convert.ToInt32(txtCuotas.Text);
                oPrestamo.PRE_Estado = "Pendiente";

                int ultimoID = TrabajarPrestamos.agregarPrestamo(oPrestamo);

                try
                {
                    Thread.Sleep(300);
                    oCuota.PRE_Numero = ultimoID;
                    oCuota.CUO_Importe = totalImporte;
                    oCuota.CUO_Estado = "Pendiente";
                    for (int i = 1; i <= cuota; i++)
                    {
                        //verifica el periodo seleccionado y en base a eso suma dias, meses o años
                        if ((Int32)cmbPeriodo.SelectedValue == 1)
                        {
                            fecha = fecha.AddDays(7);
                            oCuota.CUO_Vencimiento = fecha;
                        }
                        else if ((Int32)cmbPeriodo.SelectedValue == 2)
                        {
                            fecha = fecha.AddDays(30);
                            oCuota.CUO_Vencimiento = fecha;
                        }
                        else if ((Int32)cmbPeriodo.SelectedValue == 3)
                        {
                            fecha = fecha.AddYears(1);
                            oCuota.CUO_Vencimiento = fecha;
                        }

                        oCuota.CUO_Numero = i;

                        TrabajarCuotas.agregarCuota(oCuota);
                    }
                    MessageBox.Show("El préstamo ha sido registrado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClaseUtil.limpiarFormulario(this);
                    this.Show();
                }catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oPrincipal = new Frm_Principal();
            oPrincipal.Show();
        }
    }
}
