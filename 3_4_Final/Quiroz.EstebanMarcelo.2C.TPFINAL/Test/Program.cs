using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Productos;
using DataAccess;
using Common.Exceptions;
using Common.Serializacion;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MateriaPrima materia = new MateriaPrima(1, 80000, ETipoMaterial.Aluminio, DateTime.Today);
            MateriaPrima materiaBronce = new MateriaPrima(1, 80000, ETipoMaterial.Bronce, DateTime.Today);
            MateriaPrima materiaCobre = new MateriaPrima(1, 80000, ETipoMaterial.Cobre, DateTime.Today);
            ProduccionFinal.IngresoMateriaPrima = materia;
            ProduccionFinal.IngresoMateriaPrima = materiaBronce;
            ProduccionFinal.IngresoMateriaPrima = materiaCobre;
            ///Base de datos
            ProductosDAO productosDAO = new ProductosDAO();



            //ingreso de materia prima
            Console.WriteLine("Ingreso de Materia Prima \n");
            Console.WriteLine(ProduccionFinal.MostrarMateriaPrima());
            Console.WriteLine("\n --------------------------------------");


            Console.WriteLine("\n Construccion de Productos");
            Barra barra = new Barra(1009, ETipoMaterial.Aluminio, 0);
            Barra barra2 = new Barra(1008, ETipoMaterial.Bronce, 0);
            Barra barra3 = new Barra(1007, ETipoMaterial.Cobre, 0);

            try
            {
                productosDAO.CreateProductos(ProduccionFinal.ConstruirProducto(barra, 10));
                //productosDAO.CreateProductos(ProduccionFinal.ConstruirProducto(barra2, 10));
                //productosDAO.CreateProductos(ProduccionFinal.ConstruirProducto(barra3, 10));
                //productosDAO.CreateProductos(ProduccionFinal.ConstruirProducto(barra2, 30));
                //productosDAO.CreateProductos(ProduccionFinal.ConstruirProducto(barra2, 30));
            }
            catch(SinConexionException ex)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MiArchivo.xml";
                SerializarArchivo<Barra>.Serializar(barra,path);
                Console.WriteLine(ex.Message);
            }
           
            

            

            Console.WriteLine(ProduccionFinal.MostrarProductos());
            Console.WriteLine("\n --------------------------------------");

            Console.WriteLine("\n Gasto de Materia Prima");

            Console.WriteLine(ProduccionFinal.MostrarMateriaPrima());
            Console.WriteLine("\n --------------------------------------");
            Console.ReadKey();

        }
    }
}
