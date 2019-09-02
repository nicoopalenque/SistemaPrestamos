using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarPrestamos
    {

        public static int agregarPrestamo(Prestamo p)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("agregarPrestamo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@cli", p.CLI_DNI);
            cmd.Parameters.AddWithValue("@descod", p.DES_Codigo);
            cmd.Parameters.AddWithValue("@percod", p.PER_Codigo);
            cmd.Parameters.AddWithValue("@prefecha", p.PRE_Fecha);
            cmd.Parameters.AddWithValue("@preimp", p.PRE_Importe);
            cmd.Parameters.AddWithValue("@pretasa", p.PRE_TasaInteres);
            cmd.Parameters.AddWithValue("@precant", p.PRE_CantidadCuotas);
            cmd.Parameters.AddWithValue("@presta", p.PRE_Estado);

            cnn.Open();
            int ultimoID = (int)cmd.ExecuteScalar();
            cnn.Close();

            return ultimoID;
        }
        

        public static DataTable traerPrestamos()
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerPrestamos", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
         
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static DataTable traerPrestamosCliente(string dni)
        {
            //Establecer la conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            //Configurar la consulta
            SqlCommand cmd = new SqlCommand("traerPrestamoCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dni", dni);
            
            //crar una tabla
            DataTable tabla = new DataTable();

            //Llenar la tabla con el resultado de la consultas
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            //Devolver la tabla
            return tabla;
        }

        public static void cambiarEstadoPrestamo(int nro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("cambiarEstadoPrestamo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nro", nro);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarPrestamoDestino(string desc)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("buscarPrestamoDestino", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@desc", desc);

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            
            return tabla;
        }

        public static DataTable buscarPorFechas(DateTime fDesde, DateTime fHasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("buscarPrestamoFechas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fDesde", fDesde);
            cmd.Parameters.AddWithValue("@fHasta", fHasta);

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }

        public static DataTable buscarCuotaxPrestamo(int p)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("buscarCuotaPendiente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p", p);
          

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }

        public static void AnularPrestamo(int p)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("actualizarEstadoPrestamo", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p", p);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarPrestamoCliente(string dni, int nro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("buscarPrestamoCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@nro", nro);

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }
        public static DataTable buscarCuotas(int nro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("listarDetalleCuota", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro", nro);

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }
    }
}
