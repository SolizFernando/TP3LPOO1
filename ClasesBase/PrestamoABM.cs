using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class PrestamoABM
    {
        public static int InsertarPrestamo(DateTime fecha, decimal importe, float tasa, int cuotas, string dni, int desCodigo, int perCodigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("insert_prestamo_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@importe", importe);
            cmd.Parameters.AddWithValue("@tasa", tasa);
            cmd.Parameters.AddWithValue("@cuotas", cuotas);
            cmd.Parameters.AddWithValue("@cli_dni", dni);
            cmd.Parameters.AddWithValue("@des_codigo", desCodigo);
            cmd.Parameters.AddWithValue("@per_codigo", perCodigo);

           
            SqlParameter outputIdParam = new SqlParameter("@pre_numero", SqlDbType.Int);
            outputIdParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputIdParam);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)outputIdParam.Value;
        }

        public static void InsertarCuotas(int preNumero, decimal importe, int cuotas, DateTime primerVencimiento)
        {
           
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("insert_cuotas_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@pre_numero", preNumero);
            cmd.Parameters.AddWithValue("@importe", importe);
            cmd.Parameters.AddWithValue("@cuotas", cuotas);
            cmd.Parameters.AddWithValue("@primerVencimiento", primerVencimiento);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listar_prestamos_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("list_prestamos_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable ListarPrestamosPorDestino(int codDestino)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("prestamos_por_destino_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_destino", codDestino);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable ListarPrestamosFiltrados(int codDestino, DateTime desde, DateTime hasta)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("prestamos_filtrados_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cod_destino", codDestino);
            cmd.Parameters.AddWithValue("@fechaDesde", desde);
            cmd.Parameters.AddWithValue("@fechaHasta", hasta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ListarDestinos()
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("list_destinos_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static DataTable buscar_prestamo_por_numero(int preNumero)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand("buscar_prestamo_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pre_numero", preNumero);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
    }
}
