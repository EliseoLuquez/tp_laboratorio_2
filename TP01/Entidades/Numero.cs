using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedad
        /// <summary>
        /// Setea el valor previamente validado
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Numero() : this(Convert.ToString(0))
        {
        }

        /// <summary>
        /// Constructor que recibe double como parametro
        /// </summary>
        /// <param name="numero">Valor a asignar a numero</param>
        public Numero(double numero) : this(numero.ToString())
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que recibe string como parametro
        /// </summary>
        /// <param name="strNumero">Valor a asignar a numero</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region Metodo
        /// <summary>
        /// Comprueba que el valor recibido sea numérico
        /// </summary>
        /// <param name="strNumero">Valor a compobar si es numerico</param>
        /// <returns>El numero convertido en double, caso contrario 0</returns>
        private double ValidarNumero(string strNumero)
        {
            if(double.TryParse(strNumero, out double numero))
            {
                return numero;
            }
            return numero = 0;    
        }

        /// <summary>
        /// Convierte un Numero Binario a Decimal
        /// </summary>
        /// <param name="binario">numero binario a convertir</param>
        /// <returns>Valor convertido, caso contrario "Valor invalido".</returns>
        public string BinarioDecimal(string binario)
        {
            double valor = 0;
            int tam;
            bool retorno = false;
            tam = binario.Length;
            for (int i = 1; i <= tam; i++)
            {
                if (binario[i - 1] == '0' || binario[i - 1] == '1')
                {
                    valor += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, tam - i);
                }
                else
                {
                    retorno = true;
                }
            }
            return retorno ? "Valor Invalido" : valor.ToString();
        }


        /// <summary>
        /// Convierte de decimal a binario
        /// </summary>
        /// <param name="numero">string a convertir a binario</param>
        /// <returns>Valor convertido, caso contrario "Valor Invalido"</returns>
        public string DecimalBinario(string numero)
        {
            bool retorno;
            string valor = "";
            string invalido = "Valor Invalido";
            retorno = double.TryParse(numero, out double binario);
            if (retorno && binario > 0)
            {
                do
                {
                    valor = ((int)binario % 2).ToString() + valor;
                    binario = binario / 2;

                } while (binario >= 1);
            }

            return retorno && binario > 0 ? valor.ToString() : invalido;
        }

        /// <summary>
        /// Covierte de decimal a binario
        /// </summary>
        /// <param name="numero">Double a convertir en binario</param>
        /// <returns>Valor convertido, caso contrario "Valor Invalido"</returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }
        #endregion

        #region Operador
        /// <summary>
        /// Realiza la resta entre dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// Realiza la suma entre dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// Realiza la multiplicacion entre dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        /// <summary>
        /// Realiza la division entre dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la division si no se esta dividiendo por 0, sino double.MinValue</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return (n1.numero / n2.numero);
            }
        }
        #endregion

    }
}
