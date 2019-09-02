using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Periodo
    {
        private int per_codigo;

        public int PER_Codigo
        {
            get { return per_codigo; }
            set { per_codigo = value; }
        }
        private string per_descripcion;

        public string PER_Descripcion
        {
            get { return per_descripcion; }
            set { per_descripcion = value; }
        }
    }
}
