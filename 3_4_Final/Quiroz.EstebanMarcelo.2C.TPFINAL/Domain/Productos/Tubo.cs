using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Productos
{
    public class Tubo: Producto
    {

        /*
         * Valores aproximados de un Tubo normalizado
         * largoCm*(tuboPesoKgPorMetro/100);
         * 600*(10/100)
         */

        private const int largoCm = 600;
        private const int diametroCmExterior = 10;
        private const int diametroCmInterior = 8;

        private const int pesoTuboConstruida = 400;

        public Tubo():base()
        {
                    
        }

        public Tubo(int idProducto, ETipoMaterial tipoMaterial, int cantidadConstruida)
              :base(idProducto,tipoMaterial,cantidadConstruida)
        {
          
        }
        /// <summary>
        /// Metodo que construye el tubo recibiendo la materia prima y la cantidad a construir
        /// </summary>
        /// <param name="materiaPrima"></param>
        /// <param name="cantidadAconstruir"></param>
        /// <returns>retorna el objeto "MateriaPrima" modificando su cantidad</returns>

        public override MateriaPrima ConstuyendoProducto(MateriaPrima materiaPrima, int cantidadAconstruir)
        {
            int cantidadProducto = 0;
           
            if (materiaPrima != null && cantidadAconstruir != 0)
            {
                for (int i = 0; i < cantidadAconstruir; i++)
                {
                    if (materiaPrima.Cantidad > pesoTuboConstruida)
                    {
                        //Resta la cantidad de un tubo a la cantidad de materia prima de stock
                        materiaPrima.Cantidad -= pesoTuboConstruida;
                        cantidadProducto++;
                    }
                    else
                    {
                        break;
                    }
                }

                //suma la cantidad de tubo que se esta construyendo
                this.CantidadFabricada += cantidadProducto;
            }

            if (cantidadAconstruir != cantidadProducto)
            {
                throw new SinStockMateriaPrimaException();
            }

            return materiaPrima;
        }

        /// <summary>
        /// Muestra toda la informacion que contiene el tubo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}");
            sb.AppendFormat($"Diametro Exterior: {diametroCmExterior} Cm \n");
            sb.AppendFormat($"Diametro Interior: {diametroCmInterior} CM \n");
            sb.AppendLine($" Largo: {largoCm} Cm");

            return sb.ToString();
        }

    }
}
