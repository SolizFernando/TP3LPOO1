using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class PagoABM
    {
        public static DataTable ListarClientes()
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("list_clientes_para_pago_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ListarPrestamosPendientes(string dni)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("prestamos_pendientes_por_cliente_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ListarCuotasPendientes(int preNumero)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("cuotas_pendientes_por_prestamo_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pre_numero", preNumero);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ListarPagosPorCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("pagos_por_cliente_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni_cliente", dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void RegistrarPago(int cuoCodigo, DateTime fecha, decimal importe)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("registrar_pago_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cuo_codigo", cuoCodigo);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@importe", importe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }



    }
}
