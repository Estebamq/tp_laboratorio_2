using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Exceptions;
using Common;
using Common.Serializacion;

namespace DataAccess
{
    public class ProductosDAO:ConnectionSql
    {

        SqlConnection connection; 
        public bool CreateProductos(Producto producto)
        {

            bool retorno = false;
            try
            {
                SqlCommand command = new SqlCommand();
                connection = GetConnection();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                
                command.CommandText = "INSERT INTO Productos (tipoMaterial,cantidadFabricada) VALUES (@tipoMaterial,@cantidadFabricada);";
                command.Parameters.AddWithValue("@tipoMaterial",producto.TipoMaterial.ToString());
                command.Parameters.AddWithValue("@cantidadFabricada", producto.CantidadFabricada);

                connection.Open();
                command.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new SinConexionException();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return retorno;
        }

      /*
        public void UpdateProducto(Producto producto)
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
       
        

       
        public DataTable ListarProductos()
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
        public DataTable SearchProductoIdProducto(Producto producto)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_seachAlumId", connection))
                {
                    DataTable tabla = new DataTable();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchTipoMaterial", producto.IdProducto);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }

        


        public void DeleteMateriaPrima(Producto producto)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_deleteAlumno", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        //public string LeerArchivo(string path)
        //{
            
        //}

        //public void EscribirArchivo(Producto obj, string path)
        //{
        //    //SerializarArchivo<Producto>.Serializar(obj, path);
        //}
      */
    }
}
