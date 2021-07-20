using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public class MateriaPrimaDAO:ConnectionSql
    {
        /*
        public void CreateMateriaPrima(MateriaPrima materiaPrima)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_createAlumno", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                    cmd.Parameters.AddWithValue("@dni", alumno.Dni);
                    cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", alumno.Direccion);
                    cmd.Parameters.AddWithValue("@email", alumno.Email);
                    cmd.Parameters.AddWithValue("@fechadenacimiento", alumno.FechaDeNacimiento);
                    cmd.Parameters.AddWithValue("@estadoA", alumno.Estado);
                    cmd.Parameters.AddWithValue("@observaciones", alumno.Observaciones);

                    cmd.ExecuteNonQuery();

                }
            }
        }


        public void UpdateMateriaPrima(MateriaPrima materiaPrima)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_updateAlumno", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", alumno.Id);
                    cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                    cmd.Parameters.AddWithValue("@dni", alumno.Dni);
                    cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", alumno.Direccion);
                    cmd.Parameters.AddWithValue("@email", alumno.Email);
                    cmd.Parameters.AddWithValue("@fechadenacimiento", alumno.FechaDeNacimiento);
                    cmd.Parameters.AddWithValue("@estadoA", alumno.Estado);
                    cmd.Parameters.AddWithValue("@observaciones", alumno.Observaciones);
                    cmd.ExecuteNonQuery();

                }
            }
        }




        public DataTable ListarMateriaPrima()
        {

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SP_listAlumn", connection))
                {

                    DataTable table = new DataTable();

                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader readRows = command.ExecuteReader();

                    table.Load(readRows);

                    readRows.Close();

                    return table;
                }
            }


        }


        //POR ID
        public DataTable SearchMateriaPrimaPorId(MateriaPrima materiaPrima)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_seachAlumId", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchTipoMaterial", materiaPrima.IdMateriaPrima);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }




        public void DeleteMateriaPrima(MateriaPrima materiaPrima)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_deleteAlumno", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idProducto", materiaPrima.IdMateriaPrima);
                    cmd.ExecuteNonQuery();

                }
            }
        }
        */
    }
}
