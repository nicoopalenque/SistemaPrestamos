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
    public partial class Frm_Periodo_Alta : Form
    {
        public Frm_Periodo_Alta()
        {
            InitializeComponent();
        }

        public void limpiarFormulario(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty || txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Código y/o Descripción.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea guardas los datos?", "Alta de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    Periodo oPeriodo = new Periodo();
                    oPeriodo.PER_Codigo = Convert.ToInt32(txtCodigo.Text);
                    oPeriodo.PER_Descripcion = txtDescripcion.Text;

                    MessageBox.Show("Los datos del cliente han sido guardado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    MessageBox.Show("Código: " + oPeriodo.PER_Codigo + "\n" + "Descripción: " + oPeriodo.PER_Descripcion, "Datos Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarFormulario(this);

                    this.Show();
                }
            }
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

        private void Frm_Periodo_Alta_Load(object sender, EventArgs e)
        {

        }
    }
}
