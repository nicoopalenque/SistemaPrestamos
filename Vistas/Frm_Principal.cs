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
    public partial class Frm_Principal : Form
    {
        
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login oFrmLogin = new Frm_Login();
            oFrmLogin.Show();
        }
        
        private void gestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_GestionClientes oFrmGestionClientes = new Frm_GestionClientes();
            oFrmGestionClientes.Show();
        }               

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
                Frm_GestionUsuarios oUsuarios = new Frm_GestionUsuarios();
                oUsuarios.Show();
        }

        private void realizarPréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_GestionPrestamos oGestionPrestamo = new Frm_GestionPrestamos();
            oGestionPrestamo.Show();
        }

        private void listadoDePréstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ListadoPrestamos oFrmListaPrestamos = new Frm_ListadoPrestamos();
            oFrmListaPrestamos.Show();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_GestionUsuarios oFrmGestioUsuarios = new Frm_GestionUsuarios();
            oFrmGestioUsuarios.Show();
        }
                
        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_GestionDestinos oFrmDestino = new Frm_GestionDestinos();
            oFrmDestino.Show();            
        }

        private void registrarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_GestionPagos oFrmPagos = new Frm_GestionPagos();
            oFrmPagos.Show();
        }

        private void listadoDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ListadoPagos oFrmListadoPagos = new Frm_ListadoPagos();
            oFrmListadoPagos.Show();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            if (Frm_Login.rol == "adm")
            {
                this.clientesToolStripMenuItem.Visible = false;
                this.gestiónDeClientesToolStripMenuItem.Visible = false;
                this.realizarPréstamoToolStripMenuItem.Visible = false;
                this.listadoDePréstamosToolStripMenuItem.Visible = false;
               
                this.registrarPagosToolStripMenuItem.Visible = false;
                this.listadoDePagosToolStripMenuItem.Visible = false;

            }
            else if (Frm_Login.rol == "ope")
            {
                this.usuariosToolStripMenuItem.Visible = false;
                this.destinosToolStripMenuItem.Visible = false;
              
            }
        }

      
    }
}
