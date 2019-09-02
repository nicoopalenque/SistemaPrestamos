using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private String cli_dni;

        public String CLI_DNI
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }
        private String cli_nombre;

        public String CLI_Nombre
        {
            get { return cli_nombre; }
            set { cli_nombre = value; }
        }
        private string cli_apellido;

        public string CLI_Apellido
        {
            get { return cli_apellido; }
            set { cli_apellido = value; }
        }
        private string cli_sexo;

        public string CLI_Sexo
        {
            get { return cli_sexo; }
            set { cli_sexo = value; }
        }
        private DateTime cli_fechaNacimiento;

        public DateTime CLI_FechaNacimiento
        {
            get { return cli_fechaNacimiento; }
            set { cli_fechaNacimiento = value; }
        }
        private decimal cli_ingresos;

        public decimal CLI_Ingresos
        {
            get { return cli_ingresos; }
            set { cli_ingresos = value; }
        }
        private string cli_direccion;

        public string CLI_Direccion
        {
            get { return cli_direccion; }
            set { cli_direccion = value; }
        }
        private string cli_telefono;

        public string CLI_Telefono
        {
            get { return cli_telefono; }
            set { cli_telefono = value; }
        }
    }
}
