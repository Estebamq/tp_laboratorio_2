using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    
    public class MateriaPrima 
    {
        private int idMateriaPrima;
        private int cantidad;
        private ETipoMaterial tipoMaterial;
        private DateTime fechaDeIngreso;

        public MateriaPrima()
        {

        } 
        public MateriaPrima(int numLote, int cantidad, ETipoMaterial tipoMaterial, DateTime fechaDeIngreso)
        {
            this.IdMateriaPrima = numLote;
            this.Cantidad = cantidad;
            this.TipoMaterial = tipoMaterial;
            this.FechaDeIngreso = fechaDeIngreso;
        }

        public int IdMateriaPrima
        {
            get 
            {
                return idMateriaPrima; 
            }
            
            set 
            {
                idMateriaPrima = value; 
            }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public ETipoMaterial TipoMaterial
        {
            get 
            { 
                return tipoMaterial; 
            }
            
            set 
            { 
                tipoMaterial = value; 
            }
        }
        public DateTime FechaDeIngreso
        {
            get 
            {
                return fechaDeIngreso; 
            }

            set 
            { 
                fechaDeIngreso = value; 
            }

        }

        public static List<MateriaPrima> operator +(List<MateriaPrima> listMateriaPrima, MateriaPrima materiaPrima)
        {
            if (materiaPrima != null)
            {
                listMateriaPrima.Add(materiaPrima);
            }

            return listMateriaPrima;
        }

        public static List<MateriaPrima> operator -(List<MateriaPrima> listMateriaPrima, MateriaPrima materiaPrima)
        {
            if (materiaPrima != null && listMateriaPrima.Count!=0)
            {
                foreach (MateriaPrima auxMateriaPrima in listMateriaPrima)
                {
                    if (auxMateriaPrima == materiaPrima) 
                    {
                         materiaPrima.Cantidad = auxMateriaPrima.Cantidad;
                        
                    }
                }
              
            }

            return listMateriaPrima;
        }

        public static bool operator ==(MateriaPrima materiaPrimaUno,MateriaPrima materiaPrimaDos) 
        {
            if (!(materiaPrimaDos is null) && !(materiaPrimaUno is null))
            {
                if (materiaPrimaUno.tipoMaterial == materiaPrimaDos.tipoMaterial)
                {
                    return true;
                }
            }
            
            return false;
        }


        public static bool operator !=(MateriaPrima materiaPrimaUno, MateriaPrima materiaPrimaDos) 
        {
            return !(materiaPrimaUno == materiaPrimaDos);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nº lote del Producto: {this.IdMateriaPrima}\n");
            sb.AppendLine($"Cantidad de Material: {this.Cantidad}");
            sb.AppendLine($"Tipo de Material:{this.TipoMaterial}");
          
            return sb.ToString();
        }

        
    }
}
