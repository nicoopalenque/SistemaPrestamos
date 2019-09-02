using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;

        public int USU_ID
        {
            get { return usu_id; }
            set { usu_id = value; }
        }
        private string usu_nombreUsuario;

        public string USU_NombreUsuario
        {
            get { return usu_nombreUsuario; }
            set { usu_nombreUsuario = value; }
        }
        private string usu_contraseña;

        public string USU_Contraseña
        {
            get { return usu_contraseña; }
            set { usu_contraseña = value; }
        }
        private string usu_apellidoNombre;

        public string USU_ApellidoNombre
        {
            get { return usu_apellidoNombre; }
            set { usu_apellidoNombre = value; }
        }
        private string rol_codigo;

        public string ROL_Codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value; }
        }
    }
}
