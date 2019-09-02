using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cuota
    {
        private int cuo_codigo;

        public int CUO_Codigo
        {
            get { return cuo_codigo; }
            set { cuo_codigo = value; }
        }
        private int pre_numero;

        public int PRE_Numero
        {
            get { return pre_numero; }
            set { pre_numero = value; }
        }
        private int cuo_numero;

        public int CUO_Numero
        {
            get { return cuo_numero; }
            set { cuo_numero = value; }
        }
        private DateTime cuo_vencimiento;

        public DateTime CUO_Vencimiento
        {
            get { return cuo_vencimiento; }
            set { cuo_vencimiento = value; }
        }
        private decimal cuo_importe;

        public decimal CUO_Importe
        {
            get { return cuo_importe; }
            set { cuo_importe = value; }
        }
        private string cuo_estado;

        public string CUO_Estado
        {
            get { return cuo_estado; }
            set { cuo_estado = value; }
        }
    }
}
