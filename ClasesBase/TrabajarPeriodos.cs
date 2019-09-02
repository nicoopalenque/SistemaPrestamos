using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPeriodos
    {
        public static DataTable traerPeriodo()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerPeriodo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }
    }
}
