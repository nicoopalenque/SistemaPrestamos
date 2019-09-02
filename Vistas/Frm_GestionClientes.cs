using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using Vistas;

namespace ClasesBase
{
    public partial class Frm_GestionClientes : Form
    {

        public Frm_GestionClientes()
        {
            InitializeComponent();
        }
        
        private void Frm_GestionClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = TrabajarClientes.traerClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rbtPorApellido.Checked = false;
            string dni = txtBuscarDNI.Text;
            string ape = txtBuscarApellido.Text;
            if (txtBuscarDNI.Text == string.Empty && txtBuscarApellido.Text == string.Empty)
            {                
                MessageBox.Show("Debe ingresar DNI y/o Apellido a buscar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dgvClientes.DataSource = TrabajarClientes.traerClientes();
            }
            else
            {
                if (txtBuscarDNI.Text != string.Empty && txtBuscarApellido.Text != string.Empty)
                {
                    dgvClientes.DataSource = TrabajarClientes.buscarClientes(dni, ape);
                }
                else if (txtBuscarDNI.Text != string.Empty)
                {
                    dgvClientes.DataSource = TrabajarClientes.buscarClientesPorDNI(dni);
                }
                else
                {
                    dgvClientes.DataSource = TrabajarClientes.buscarClientesPorApellido(ape);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();

            oCliente.CLI_Apellido = txtApellido.Text;
            oCliente.CLI_Nombre = txtNombre.Text;
            oCliente.CLI_DNI = txtDNI.Text;
            oCliente.CLI_Sexo = txtSexo.Text;
            oCliente.CLI_FechaNacimiento = dtFechaNacimiento.Value;
            oCliente.CLI_Ingresos = decimal.Parse(txtIngresos.Text);
            oCliente.CLI_Direccion = txtDireccion.Text;
            oCliente.CLI_Telefono = txtTelefono.Text;

            TrabajarClientes.actualizarCliente(oCliente);
            MessageBox.Show("Los datos se actualizaron correctamente.");

            dgvClientes.DataSource = TrabajarClientes.traerClientes();//actualiza

            ClaseUtil.limpiarFormulario(gbCliente);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtDNI.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtSexo.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            dtFechaNacimiento.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtIngresos.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();
            string dni = txtDNI.Text;
            DialogResult result;
            result = MessageBox.Show("¿Desea eliminar al cliente " + txtNombre.Text + ", " + txtApellido.Text + "?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TrabajarClientes.eliminarCliente(dni);
                dgvClientes.DataSource = TrabajarClientes.traerClientes();
                MessageBox.Show("El cliente ha sido eliminado.");
            }
            ClaseUtil.limpiarFormulario(gbCliente);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea guardas los datos?", "Alta de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();
                oCliente.CLI_Nombre = txtNombre.Text;
                oCliente.CLI_Apellido = txtApellido.Text;
                oCliente.CLI_DNI = txtDNI.Text;
                oCliente.CLI_Sexo = txtSexo.Text;
                oCliente.CLI_FechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.Text);
                oCliente.CLI_Ingresos = Convert.ToDecimal(txtIngresos.Text);
                oCliente.CLI_Direccion = txtDireccion.Text;
                oCliente.CLI_Telefono = txtTelefono.Text;

                TrabajarClientes.agregarCliente(oCliente);
                dgvClientes.DataSource = TrabajarClientes.traerClientes();//actualiza
                MessageBox.Show("El cliente ha sido registrado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }

            ClaseUtil.limpiarFormulario(gbCliente);
        }

        private void rbtPorApellido_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = TrabajarClientes.ordenarPorApellido();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oFrmPrincipal = new Frm_Principal();
            oFrmPrincipal.Show();
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.LightBlue;
            btnGuardar.ForeColor = Color.Black;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Gainsboro;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.WhiteSmoke;
        }

    }
}
