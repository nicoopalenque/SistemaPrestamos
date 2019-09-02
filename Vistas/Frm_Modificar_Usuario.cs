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
    public partial class Frm_Modificar_Usuario : Form
    {
        public Frm_Modificar_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Usuario_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = TrabajarUsuarios.ListaUsuarios();
            cmbUsuarios.DisplayMember = "USU_ApellidoNombre";
            cmbUsuarios.ValueMember = "USU_ID";
            
            
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Usuarios oUsuarios = new Frm_Usuarios();
            oUsuarios.Show();
        }

    }
}
