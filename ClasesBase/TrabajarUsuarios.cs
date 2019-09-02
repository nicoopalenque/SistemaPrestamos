using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ClasesBase
{
    public class TrabajarUsuarios
    {
        public static DataTable traerUsuarios()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
                        
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerUsuarios", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
           
            //Devolver la tabla
            return tabla;           
        }

        public static Usuario traerUsuario(String u, String p)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("validarUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@u",u);
            cmd.Parameters.AddWithValue("@p",p);

            SqlDataReader reader;
            Usuario oUsuario;
            cnn.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read()){
                oUsuario =  new Usuario();
                oUsuario.ROL_Codigo =(String)reader["ROL_Codigo"];
                oUsuario.USU_ApellidoNombre = (String)reader["USU_ApellidoNombre"];
                oUsuario.USU_NombreUsuario = (String)reader["USU_NombreUsuario"];
                oUsuario.USU_Contraseña = (String)reader["USU_Contraseña"];
                return oUsuario;
            }
            return null;
        }

        public static void agregarUsuario(Usuario u)
        {            
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            SqlCommand cmd = new SqlCommand("agregarUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", u.USU_NombreUsuario);
            cmd.Parameters.AddWithValue("@password", u.USU_Contraseña);
            cmd.Parameters.AddWithValue("@lastname", u.USU_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", u.ROL_Codigo);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarUsuarios(string ayn)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("buscarUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
      
            cmd.Parameters.AddWithValue("@ayn", "%" + ayn + "%");

            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static void actualizarUsuario(Usuario ousuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("actualizarUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
        
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", ousuario.USU_ID);
            cmd.Parameters.AddWithValue("@a", ousuario.USU_NombreUsuario);
            cmd.Parameters.AddWithValue("@p", ousuario.USU_Contraseña);
            cmd.Parameters.AddWithValue("@ayn", ousuario.USU_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", ousuario.ROL_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminarUsuario(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("eliminarUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
                
        public static DataTable traerUsuariosPorUsername()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerUsuarioPorUsername", cnn);
            cmd.CommandType = CommandType.StoredProcedure;            
        
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static DataTable traerUsuariosPorApellido()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerUsuarioPorApellido", cnn);
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