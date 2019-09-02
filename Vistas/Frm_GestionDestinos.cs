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
    public partial class Frm_GestionDestinos : Form
    {
 
        public Frm_GestionDestinos()
        {
            InitializeComponent();
        }

        private void Frm_GestionDestino_Load(object sender, EventArgs e)
        {
            dgvDestino.DataSource = TrabajarDestinos.traerDestino();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la descripción del destino a agregar.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea guardas los datos?", "Alta de Destino", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    Destino oDestino = new Destino();
                    oDestino.DES_Descripcion = txtDescripcion.Text;
                    TrabajarDestinos.agregarDestino(oDestino);
                    dgvDestino.DataSource = TrabajarDestinos.traerDestino();
                    MessageBox.Show("Se ha registrado correctamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TrabajarDestinos.traerDestino();//para actualizar el dgvDestino con el registro agregado
                }
            }
            ClaseUtil.limpiarFormulario(gbDestino);
        }
               
        private void dgvDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvDestino.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvDestino.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Destino oDestino = new Destino();
            oDestino.DES_Codigo = Convert.ToInt32(txtCodigo.Text);
            oDestino.DES_Descripcion = txtDescripcion.Text;
            TrabajarDestinos.actualizarDestino(oDestino);
            MessageBox.Show("El resgistro ha sido actualizado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ClaseUtil.limpiarFormulario(gbDestino);
            dgvDestino.DataSource = TrabajarDestinos.traerDestino();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            TrabajarDestinos.eliminarDestino(codigo);
            MessageBox.Show("El registro ha sido eliminado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClaseUtil.limpiarFormulario(gbDestino);
            dgvDestino.DataSource = TrabajarDestinos.traerDestino();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oFrmPrincipal = new Frm_Principal();
            oFrmPrincipal.Show();
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.SkyBlue;
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
