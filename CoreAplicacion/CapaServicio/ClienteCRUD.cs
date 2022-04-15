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
        SqlCommand command;
        Controlador controlador = new Controlador();

        public bool InsertarClientes(CoreAplicacion.Clases.ClienteClase cliente)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(controlador.ObtenerConexion()))
            {
                command = new SqlCommand("ppInsertCliente", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Cedula_Cliente", cliente.Cedula_Cliente);
                command.Parameters.AddWithValue("@Nombre_Cliente", cliente.Nombre_Cliente);
                command.Parameters.AddWithValue("@Direccion_Cliente", cliente.Direccion_Cliente);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", cliente.Direccion_Cliente);
                command.Parameters.AddWithValue("@ID_Provincia", cliente.IDProvincia);
                command.Parameters.AddWithValue("@ID_Municipio", cliente.IDMunicipio);
                command.Parameters.AddWithValue("@ID_Sector", cliente.IDSector);
                command.Parameters.AddWithValue("@IngresosMensuales", cliente.IngresosMensuales);
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

    