using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClasesBase;

namespace ClasesBase
{
    public class DestinoABM
    {
        public static DataTable list_destinos_sp()
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("list_destinos_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void InsertarDestino(string descripcion)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("insert_destino_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarDestino(int codigo, string descripcion)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("modify_destino_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarDestino(int codigo)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("delete_destino_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static bool ExisteDestino(string descripcion)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand("existe_destino_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", descripcion);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();

            return count > 0;
        }
        public static bool ExisteDestinoExcepto(string descripcion, int codigoExcluir)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Destino WHERE LOWER(des_descripcion) = LOWER(@descripcion) AND des_codigo <> @codigo", cnn);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@codigo", codigoExcluir);
            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();
            return count > 0;
        }

    }
}
