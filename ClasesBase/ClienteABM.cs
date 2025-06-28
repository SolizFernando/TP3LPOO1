using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ClienteABM
    {
        public static void insert_cliente_sp(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_dni);
            cmd.Parameters.AddWithValue("@ape", cliente.Cli_apellido);
            cmd.Parameters.AddWithValue("@nom", cliente.Cli_nombre);
            cmd.Parameters.AddWithValue("@dire", cliente.Cli_direccion);
            cmd.Parameters.AddWithValue("@sexo", cliente.Cli_sexo);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_telefono);
            cmd.Parameters.AddWithValue("@fecha", cliente.Cli_fechaNacimiento);
            cmd.Parameters.AddWithValue("@ingre", cliente.Cli_ingresos);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modify_cliente_sp(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modify_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_dni);
            cmd.Parameters.AddWithValue("@ape", cliente.Cli_apellido);
            cmd.Parameters.AddWithValue("@nom", cliente.Cli_nombre);
            cmd.Parameters.AddWithValue("@dire", cliente.Cli_direccion);
            cmd.Parameters.AddWithValue("@sexo", cliente.Cli_sexo);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_telefono);
            cmd.Parameters.AddWithValue("@fecha", cliente.Cli_fechaNacimiento);
            cmd.Parameters.AddWithValue("@ingre", cliente.Cli_ingresos);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_clientes_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand("list_clientes_sp",cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable search_clientes_sp(string dni, string telefono)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "search_clientes_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");
            cmd.Parameters.AddWithValue("@tel", "%" + telefono + "%");

           
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void delete_cliente_sp(string dniCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "delete_cliente_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dniCliente);

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static Boolean search_dni_sp(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "search_dni_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            cmd.Parameters.Add("@count_client", SqlDbType.Int);
            cmd.Parameters["@count_client"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return ((int)cmd.Parameters["@count_client"].Value) == 0;
        }



    }
}
