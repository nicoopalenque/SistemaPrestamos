using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pago
    {
        private int pag_codigo;

        public int PAG_Codigo
        {
            get { return pag_codigo; }
            set { pag_codigo = value; }
        }
        private int cuo_codigo;

        public int CUO_Codigo
        {
            get { return cuo_codigo; }
            set { cuo_codigo = value; }
        }
        private DateTime pag_fecha;

        public DateTime PAG_Fecha
        {
            get { return pag_fecha; }
            set { pag_fecha = value; }
        }
        private decimal pag_importe;

        public decimal PAG_Importe
        {
            get { return pag_importe; }
            set { pag_importe = value; }
        }
    }
}
