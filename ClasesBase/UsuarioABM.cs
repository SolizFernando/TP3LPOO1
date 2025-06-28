using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{

    public class UsuarioABM
    {

        public static void insert_usuario_sp(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_usuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_codigo);
            cmd.Parameters.AddWithValue("@ape", user.Usu_apellidoNombre);
            cmd.Parameters.AddWithValue("@usu", user.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_contrasenia);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modify_usuario_sp(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modify_usuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", usuario.Usu_id);
            cmd.Parameters.AddWithValue("@cod", usuario.Rol_codigo);
            cmd.Parameters.AddWithValue("@usu", usuario.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@pas", usuario.Usu_contrasenia);
            cmd.Parameters.AddWithValue("@ape", usuario.Usu_apellidoNombre);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void delete_usuario_sp(string idUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "delete_usuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", int.Parse(idUsuario));
            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable search_usuarios_sp(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "search_usuarios_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_roles_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_roles_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_usuarios_ordenados_sp(string criterio)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand("list_usuarios_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@criterio", criterio);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static string verificar_loginBD_sp(string username, string contrasena)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand("verificar_loginBD_sp", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario", username);
            cmd.Parameters.AddWithValue("@pas", contrasena);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                throw new Exception("Usuario no encontrado");

            return dt.Rows[0]["rol_codigo"].ToString();
        }

        public static string get_rolDescripcion_sp(string rolCod)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "get_rolDescripcion_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cod", rolCod);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0]["rol_descripcion"].ToString();
        }

        public static Boolean search_username_sp(string username)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "search_username_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@us", username);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();
            return count == 0;
        }

        public static string get_id_usuario_sp(string username)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamosConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "get_id_usuario_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@us", username);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                return dt.Rows[0]["usu_id"].ToString();
            }
            catch
            {
                return "null";
            }
        }

    }    
}
    
