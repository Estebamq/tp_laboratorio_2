using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Domain.Productos;

namespace Domain
{
    [Serializable]
    [XmlInclude(typeof(Alambre))]
    [XmlInclude(typeof(Tubo))]
    [XmlInclude(typeof(Barra))]

    public abstract class Producto
    {
        protected int idProducto;
        protected ETipoMaterial tipoMaterial;
        protected int cantidadFabricada;

        protected Producto()
        {
            this.IdProducto = 0;
            this.CantidadFabricada = 0;
        }

        protected Producto(int idProducto, ETipoMaterial tipoMaterial,
                            int cantidadFabricada) : this()
        {
            this.IdProducto = idProducto;
            this.TipoMaterial = tipoMaterial;
            this.CantidadFabricada = cantidadFabricada;
        }

        public int IdProducto
        {
            get 
            { 
                return idProducto; 
            }
            set 
            { 
                idProducto = value; 
            }
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


        public int CantidadFabricada
        {
            get 
            { 
                return this.cantidadFabricada; 
            }
            set 
            { 
                this.cantidadFabricada = value; 
            }
        }

        public abstract MateriaPrima ConstuyendoProducto(MateriaPrima materiaPrima, int cantAConstruir);
       

        public static List<Producto>  operator +(List<Producto> listProductos, Producto producto) 
        {
            Producto auxProducto;

            if (producto != null && listProductos!=null) 
            {

               
                for (int i = 0; i < listProductos.Count; i++) 
                { 
                    //miro si contiene el producto en la lista
                        if (listProductos.Contains(producto))
                        {
                         
                            //si lo contiene que me lo devuelva en una variable auxiliar
                            auxProducto=listProductos.ElementAt(i);
                            //si son iguales 
                            if (auxProducto == producto) 
                            {
                                //Rompe el bucle
                                break;
                            }
  
                        }
                        else
                        {
                            //si no lo contiene agregarlo
                            listProductos.Add(producto);
                            break;
                        }
                }

                //si no hay productos ingresar uno nuevo
                if (listProductos.Count == 0)
                {
                    listProductos.Add(producto);
                }


            }
            return listProductos;
        }

        public static bool operator ==(Producto productoUno, Producto productoDos) 
        {
            if (!(productoUno is null) && !(productoDos is null)) {
                if (productoUno.GetType() == productoDos.GetType() && productoUno.tipoMaterial == productoDos.tipoMaterial)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nº lote del Producto: {this.IdProducto}\n");
            sb.AppendLine($"Tipo de Material: {this.TipoMaterial}");
            sb.AppendLine($"Cantidad Construida:{this.CantidadFabricada}");
            
            return sb.ToString();
        }

    }
}
