using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Frm_Gestion_Usuarios : Form
    {
        public Frm_Gestion_Usuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Principal oPrincipal = new Frm_Principal();
            oPrincipal.Show();
        }

        
    }
}
