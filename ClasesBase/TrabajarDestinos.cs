using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarDestinos
    {
        public static DataTable traerDestino()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerDestino", cnn);
            
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static void agregarDestino(Destino destino)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("agregarDestino", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@desc", destino.DES_Descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void actualizarDestino(Destino d)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("actualizarDestino", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@desc", d.DES_Descripcion);
            cmd.Parameters.AddWithValue("@cod", d.DES_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminarDestino(int cod)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("eliminarDestino", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cod", cod);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    
    }
}
