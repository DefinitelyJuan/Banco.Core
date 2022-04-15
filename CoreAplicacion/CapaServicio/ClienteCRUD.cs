using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoreAplicacion.CapaServicio
{
    public class CRUDCliente
    {
        public string ConnectionStrings;
        SqlConnection connection = new SqlConnection();
        SqlTransaction transaction;
        SqlCommand sqlCommand;
        Controlador controlador = new Controlador();

        public bool InsertarClientes(CoreAplicacion.Clases.ClienteInternetBanking cliente)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(controlador.ObtenerConexion()))
            {
                SqlCommand command = new SqlCommand("ppInsertarCliente", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Cedula", cliente.Cedula);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                command.Parameters.AddWithValue("@Dirección", cliente.Dirección);
                command.Parameters.AddWithValue("@Pais", cliente.Pais);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);
                command.Parameters.AddWithValue("@NombreUsuario", cliente.NombreUsuario);
                command.Parameters.AddWithValue("@ContraseñaUsuario", cliente.ContraseñaUsuario);
                command.Parameters.AddWithValue("@PIN", cliente.PIN);
                try
                {
                    connection.Open();
                    id = command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception err)
                {
                    //Log.Info(err);
                    return false;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

    }
}

    