using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Destino
    {
        private int des_codigo;

        public int DES_Codigo
        {
            get { return des_codigo; }
            set { des_codigo = value; }
        }
        private string des_descripcion;

        public string DES_Descripcion
        {
            get { return des_descripcion; }
            set { des_descripcion = value; }
        }
    }
}
