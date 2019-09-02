using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Prestamo
    {
        private int pre_numero;

        public int PRE_Numero
        {
            get { return pre_numero; }
            set { pre_numero = value; }
        }
        private string cli_dni;

        public string CLI_DNI
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }
        private int des_codigo;

        public int DES_Codigo
        {
            get { return des_codigo; }
            set { des_codigo = value; }
        }
        private int per_codigo;

        public int PER_Codigo
        {
            get { return per_codigo; }
            set { per_codigo = value; }
        }
        private DateTime pre_fecha;

        public DateTime PRE_Fecha
        {
            get { return pre_fecha; }
            set { pre_fecha = value; }
        }
        private decimal pre_importe;

        public decimal PRE_Importe
        {
            get { return pre_importe; }
            set { pre_importe = value; }
        }
        private decimal pre_tasaInteres;

        public decimal PRE_TasaInteres
        {
            get { return pre_tasaInteres; }
            set { pre_tasaInteres = value; }
        }
        private int pre_cantidadCuotas;

        public int PRE_CantidadCuotas
        {
            get { return pre_cantidadCuotas; }
            set { pre_cantidadCuotas = value; }
        }
        private string pre_estado;

        public string PRE_Estado
        {
            get { return pre_estado; }
            set { pre_estado = value; }
        }
    }
}
