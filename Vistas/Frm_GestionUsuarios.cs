using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Threading;

namespace Vistas
{
    public partial class Frm_GestionUsuarios : Form
    {
        public Frm_GestionUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuarios();
            dgvUsuarios.Columns[5].Visible = false;
            
            cmbRoles.DataSource = Trabajar_Roles.traerRoles();  
            cmbRoles.DisplayMember = "ROL_Descripcion";            
            cmbRoles.ValueMember = "ROL_Codigo";
            cmbRoles.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rbtPorUsername.Checked = false;
            rbtPorApellido.Checked = false;
            string ayn = txtBuscar.Text;

            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Nombre o Apellido a buscar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuarios();
            }
            else
            {
                dgvUsuarios.DataSource = TrabajarUsuarios.buscarUsuarios(ayn);
            }
        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea guardas los datos?", "Alta de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Usuario oUsuario = new Usuario();
                oUsuario.USU_NombreUsuario = txtUsuario.Text;
                oUsuario.USU_Contraseña = txtContraseña.Text;
                oUsuario.USU_ApellidoNombre = txtAyN.Text;
                oUsuario.ROL_Codigo = (string)cmbRoles.SelectedValue;

                TrabajarUsuarios.agregarUsuario(oUsuario);

                MessageBox.Show("El usuario ha sido registrado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuarios();//Actualiza la grilla
            }

            ClaseUtil.limpiarFormulario(gbUsuario);
        }
                
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.USU_ID = Convert.ToInt32(txtCodigo.Text);
            oUsuario.USU_NombreUsuario = txtUsuario.Text;
            oUsuario.USU_Contraseña = txtContraseña.Text;
            oUsuario.USU_ApellidoNombre = txtAyN.Text;
            oUsuario.ROL_Codigo = (string)cmbRoles.SelectedValue;

            TrabajarUsuarios.actualizarUsuario(oUsuario);

            
            MessageBox.Show("Los datos del usuario han sido actualizados.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuarios();//actualiza
          
            ClaseUtil.limpiarFormulario(gbUsuario);          
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtAyN.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            DataGridViewRow row = (DataGridViewRow)dgvUsuarios.CurrentRow;
            cmbRoles.SelectedValue = (string)row.Cells["rol_codigo"].Value;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();
            int id = Int32.Parse(txtCodigo.Text);
            DialogResult result;
            result=MessageBox.Show("¿Desea eliminar al usuario " + txtAyN.Text + "?" ,"ATENCION",MessageBoxButtons.YesNo, MessageBoxIcon.Question );
       
            if(result==DialogResult.Yes)
            {
                if (id == 2)
                {
                    MessageBox.Show("No puede eliminar este usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TrabajarUsuarios.eliminarUsuario(id);
                    MessageBox.Show("El usuario ha sido eliminado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuarios();
                }
            }
            ClaseUtil.limpiarFormulario(gbUsuario);
        }

        private void rbtPorUsername_CheckedChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuariosPorUsername();
        }

        private void rbtPorApellido_CheckedChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = TrabajarUsuarios.traerUsuariosPorApellido();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oPrincipal = new Frm_Principal();
            oPrincipal.Show();
        }
    }
}
