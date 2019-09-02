using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private string rol_codigo;

        public string ROL_Codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value; }
        }
        private string rol_descripcion;

        public string ROL_Descripcion
        {
            get { return rol_descripcion; }
            set { rol_descripcion = value; }
        }
    }
}
