using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCuotas
    {
        public static void agregarCuota(Cuota c)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("agregarCuota", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@prenum", c.PRE_Numero);
            cmd.Parameters.AddWithValue("@cuonum", c.CUO_Numero);
            cmd.Parameters.AddWithValue("@cuoven", c.CUO_Vencimiento);
            cmd.Parameters.AddWithValue("@cuoimp", c.CUO_Importe);
            cmd.Parameters.AddWithValue("@cuoest", c.CUO_Estado);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable traerCuotaPrestamo(int nro)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerCuotaPrestamo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nro", nro);
            
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static void cambiarEstadoCuota(int nro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("cambiarEstadoCuota", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nro", nro);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /*
            PUNTO 6 TP FINAL
        */
        public static DataTable traerDatos(int nro, string  dni)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerDatosPrestamo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nro", nro);
            cmd.Parameters.AddWithValue("@dni", dni);
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static DataTable traerCuotasPrestamo(int nro)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerCuotasPrestamo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nro", nro);

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
