using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Productos;


namespace Domain
{
    public static class ProduccionFinal
    {
        private static List<Producto> listProductos;
        private static List<MateriaPrima> listmateriaPrima;

        static ProduccionFinal() 
        {
            listProductos = new List<Producto>();
            listmateriaPrima = new List<MateriaPrima>();
        }

        public static Producto IngresoProductoList
        {
            set
            {
                listProductos += value;
            }
        }

        public static MateriaPrima IngresoMateriaPrima
        {
            set
            {
                listmateriaPrima += value;
            }

        }

        public static MateriaPrima GastoMateriaPrima
        {
            set
            {
                listmateriaPrima -= value;
            }

        }


        public static Producto ConstruirProducto(Producto producto,int cantidadACrear) 
        {
             MateriaPrima materiaPrimaGasto = new MateriaPrima();
            
            foreach (MateriaPrima auxMateriaPrima in listmateriaPrima)
            {
                if (producto != null && cantidadACrear > 0 && auxMateriaPrima.TipoMaterial == producto.TipoMaterial)
                {
                    if (producto is Alambre)
                    {
                        materiaPrimaGasto = producto.ConstuyendoProducto(auxMateriaPrima, cantidadACrear);
                    }

                    if (producto is Barra)
                    {
                        materiaPrimaGasto = producto.ConstuyendoProducto(auxMateriaPrima, cantidadACrear);
                    }

                    if (producto is Tubo)
                    {
                        materiaPrimaGasto = producto.ConstuyendoProducto(auxMateriaPrima, cantidadACrear);
                    }

                    IngresoProductoList = producto;
                   
                }
            }

            GastoMateriaPrima = materiaPrimaGasto;

            return producto;

        }


        public static string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto auxProducto in listProductos)
            {
                if (auxProducto is Alambre)
                {
                    sb.AppendFormat($"\n****** Producto Alambre ****** \n {auxProducto.ToString()}");
                }

                if (auxProducto is Barra)
                {
                    sb.AppendFormat($"\n****** Producto Barra ****** \n {auxProducto.ToString()}");
                }

                if (auxProducto is Tubo)
                {
                    sb.AppendFormat($"\n ****** Producto Barra ****** \n {auxProducto.ToString()}");
                }
            }

            return sb.ToString();
        }

        public static string MostrarMateriaPrima()
        {
            StringBuilder sb = new StringBuilder();

            foreach (MateriaPrima auxMateriaPrima in listmateriaPrima)
            {    
               sb.AppendFormat($"****** Materias Primas ****** \n {auxMateriaPrima.ToString()}");
            }

            return sb.ToString();
        }


    }
}
