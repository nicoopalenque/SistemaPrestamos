using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace ClasesBase
{
    public class TrabajarClientes
    {
        public static void agregarCliente(Cliente c)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("agregarCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@dni", c.CLI_DNI);
            cmd.Parameters.AddWithValue("@nombre", c.CLI_Nombre);
            cmd.Parameters.AddWithValue("@apellido", c.CLI_Apellido);
            cmd.Parameters.AddWithValue("@sexo", c.CLI_Sexo);
            cmd.Parameters.AddWithValue("@fechanac", c.CLI_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", c.CLI_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", c.CLI_Direccion);
            cmd.Parameters.AddWithValue("@telefono", c.CLI_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void actualizarCliente(Cliente ocliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("actualizarCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@dni", ocliente.CLI_DNI);
            cmd.Parameters.AddWithValue("@n", ocliente.CLI_Nombre);
            cmd.Parameters.AddWithValue("@ap", ocliente.CLI_Apellido);
            cmd.Parameters.AddWithValue("@s", ocliente.CLI_Sexo);
            cmd.Parameters.AddWithValue("@f", ocliente.CLI_FechaNacimiento);
            cmd.Parameters.AddWithValue("@i", ocliente.CLI_Ingresos);
            cmd.Parameters.AddWithValue("@d", ocliente.CLI_Direccion);
            cmd.Parameters.AddWithValue("@t", ocliente.CLI_Telefono);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminarCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("eliminarCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable traerClientes()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("listarClientes", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static DataTable traerClientesSP()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerClientes", cnn);
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }
       
        public static DataTable buscarClientes(string dni, string ape )
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("buscarCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@ape", "%" + ape + "%");
            cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");

            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static DataTable buscarClientesPorDNI(string dni)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("buscarClientePorDNI", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");

            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static DataTable buscarClientesPorApellido(string ape)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("buscarClientePorApellido", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ape", "%" + ape + "%");

            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static DataTable ordenarPorApellido()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("ordenarClientePorApellido", cnn);
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;

            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static Cliente traerClientePorDNI(string dni)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerClientePorDNI", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", dni);

            SqlDataReader reader;
            Cliente oCliente;
            cnn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                oCliente = new Cliente();
                oCliente.CLI_Nombre = (String)reader["CLI_Nombre"];
                oCliente.CLI_Apellido = (String)reader["CLI_Apellido"];
                oCliente.CLI_DNI = (String)reader["CLI_DNI"];
                return oCliente;
            }
            return null;
        }
    }
}
