using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Exceptions;

namespace Domain.Productos
{
    public class Barra:Producto
    {
        private const int largoCm = 600;
        private const int diametroCmExterior = 10;
        private const int BarraPesoKgPorMetro = 21;

        private const int pesoBarraConstruida = 600; 
        //largoCm*(BarraPesoKgPorMetro/100);
        public Barra()
        {
                
        }

        public Barra(int idProducto, ETipoMaterial tipoMaterial,int stockProducto)
                    :base(idProducto,tipoMaterial,stockProducto)
        {

        }

        public override MateriaPrima ConstuyendoProducto ( MateriaPrima  materiaPrima, int cantidadAconstruir)
        {
            int cantidadProducto = 0;
            
            if (materiaPrima != null && cantidadAconstruir != 0)
            {
                for (int i = 0; i < cantidadAconstruir; i++)
                {
                    if (materiaPrima.Cantidad > pesoBarraConstruida)
                    {
                        //Resta la cantidad de un tubo a la cantidad de materia prima de stock
                        materiaPrima.Cantidad -= pesoBarraConstruida;
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
            sb.Append($"{base.ToString()}");
            sb.AppendFormat($"Diametro Exterior: {diametroCmExterior} Cm\n");
            sb.AppendLine($"Largo: {largoCm} Cm.");

            return sb.ToString();
        }

    }
}
