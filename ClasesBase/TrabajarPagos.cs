using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPagos
    {
        public static void agregarPago(Pago p)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("agregarPago", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cod",p.CUO_Codigo);
            cmd.Parameters.AddWithValue("@fecha", p.PAG_Fecha);
            cmd.Parameters.AddWithValue("@imp",p.PAG_Importe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listarPagos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("listarPagos", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }

        public static DataTable listarPagosCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("listarPagoCliente", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dni", dni);

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }

        public static DataTable buscarPorFechas(DateTime fDesde, DateTime fHasta, string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand("buscarCuotasFechas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fDesde", fDesde);
            cmd.Parameters.AddWithValue("@fHasta", fHasta);
            cmd.Parameters.AddWithValue("@dni", dni);

            DataTable tabla = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            return tabla;
        }
    }
}
