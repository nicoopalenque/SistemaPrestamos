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
    public partial class Frm_Usuario_Alta : Form
    {
        public Frm_Usuario_Alta()
        {
            InitializeComponent();
        }

        private void Frm_Usuario_Alta_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = TrabajarUsuarios.TraerRoles();
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea guardas los datos?", "Alta de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Usuario oUsuario = new Usuario();
                oUsuario.USU_NombreUsuario = txtUsuario.Text;
                oUsuario.USU_Contraseña = txtContrasaeña.Text;
                oUsuario.USU_ApellidoNombre = txtApellidoNombre.Text;
                oUsuario.ROL_Codigo = (string)cmbRol.SelectedValue;

                TrabajarUsuarios.agregarUsuario(oUsuario);

                MessageBox.Show("Los datos del cliente han sido guardado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TrabajarUsuarios.limpiarFormulario(this);
                this.Show();
            }
            else
                TrabajarUsuarios.limpiarFormulario(this);
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oFrmPrincipal = new Frm_Principal();
            oFrmPrincipal.Show();
        }
    }
}
