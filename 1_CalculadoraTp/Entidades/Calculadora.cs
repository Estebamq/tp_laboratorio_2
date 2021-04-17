using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        
        /// <summary>
        /// es un metodo static que recibe dos objetos de la clase numero y opera
        /// </summary>
        /// <param name="num1">Objeto de la clase Numero</param>
        /// <param name="num2">Objeto de la clase Numero</param>
        /// <param name="operador">string operar</param>
        /// <returns> retorna el valor de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador) 
        {
            double respuesta=0;
            char operadorValidado;


            char.TryParse(operador, out operadorValidado);
            
            switch (ValidarOperador(operadorValidado))
            {
                    case '+':
                        respuesta = num1 + num2;
                        break;
                    case '-':
                        respuesta = num1 - num2;
                        break;
                    case '*':
                        respuesta = num1 - num2;
                        break;
                    case '/':
                        respuesta = num1 / num2;
                        break;
            }
            

            return respuesta;
        }

        /// <summary>
        /// Valida el operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>retorna el operador, si no es valido retorna '+'</returns>

        private static char ValidarOperador(char operador) 
        {
            char retorno= '+';

            switch (operador) 
            {
                case '+':
                    retorno =  operador;
                    break;
                case '-':
                    retorno = operador;
                    break;

                case '*':
                    retorno = operador;
                    break;
                case '/':
                    retorno = operador;
                    break;
               
            }
            return retorno;

        }
    }
}
