using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Productos
{
   
    public class Alambre:Producto
    {

        //cantidad de Materia para alambre es la cantidad de material que se consume para su construccion
        private const int cantidadDeMateriaParaAlambre = 1; //largoCm*(BarraPesoKgPorMetro/100);
        
        public Alambre() 
        {
           
        }
        public Alambre(int idProducto,ETipoMaterial tipoMaterial, int cantidadFabricada)
                      :base(idProducto, tipoMaterial, cantidadFabricada) 
        {
           
        }

        public override MateriaPrima ConstuyendoProducto(MateriaPrima materiaPrima, int cantidadAconstruir)
        {
            
            int cantidadProducto = 0;
            
            if (materiaPrima != null && cantidadAconstruir != 0)
            {
                for (int i = 0; i < cantidadAconstruir; i++)
                {
                    if (materiaPrima.Cantidad > cantidadDeMateriaParaAlambre)
                    {
                        //Resta la cantidad de un tubo a la cantidad de materia prima de stock
                        materiaPrima.Cantidad -= cantidadDeMateriaParaAlambre;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()} Kg.");
      
            return sb.ToString();
        }


    }
}
