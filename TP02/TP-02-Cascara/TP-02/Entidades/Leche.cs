﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo tipo;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche(EMarca marca, string patente, ConsoleColor color, ETipo tipo)
            : base(patente, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string patente, ConsoleColor color) : this(marca, patente, color, ETipo.Entera) 
        {
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        /// <summary>
        /// Muestra los atributos del producto Leche
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine((string)this);
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
