using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodo
        /// <summary>
        /// Realiza la operacion segun el operador a los 2 objetos Numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>resultado de la operacion asignada entre los objetos Numero</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string aux;
            aux = ValidarOperador(operador);
            double restultado = 0;
            switch (operador)
            {
                case "+":
                    restultado = (num1 + num2);
                    break;
                case "-":
                    restultado = (num1 - num2);
                    break;
                case "*":
                    restultado = (num1 * num2);
                    break; 
                case "/":
                    restultado = (num1 / num2);
                    break;
            }
            return restultado;
        }

        /// <summary>
        /// Comprueba si el operador es valido 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Restorna el operador valido, caso contrario "+"</returns>
        private static string ValidarOperador(string operador)
        {
            switch (operador)
            {
                case "-":
                    return "-";
                case "*":
                    return "*";
                case "/":
                    return "/";
                default :
                    return "+";
            }
        }
        #endregion
    }
}
