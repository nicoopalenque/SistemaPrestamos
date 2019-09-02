using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

using ClasesBase;

namespace Vistas
{
    public partial class Frm_Login : Form
    {
        public static String rol;

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        
        
        public Frm_Login()
        {
            InitializeComponent();
        }                  

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string u = txtUsuario.Text;
            string p = txtContraseña.Text;

            if (txtUsuario.Text == string.Empty ||  txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Usuario y/o Contraseña.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            

            Usuario oUsuario = TrabajarUsuarios.traerUsuario(u,p);
            if (oUsuario != null)
            {
                rol = oUsuario.ROL_Codigo;
                this.Hide();
                MessageBox.Show("Bienvenido al Sistema: " + oUsuario.USU_ApellidoNombre, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm_Principal oFrmPrincipal = new Frm_Principal();
                oFrmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto/s", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SendMessage(txtUsuario.Handle, EM_SETCUEBANNER, 0, "Usuario");
            SendMessage(txtContraseña.Handle, EM_SETCUEBANNER, 0, "Contraseña");
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.SkyBlue;
            btnIngresar.ForeColor = Color.Black;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.DodgerBlue;
            btnIngresar.ForeColor = Color.White;
        }     
    }
}