using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mate
{
    class medias
    {

        /**
         * Calcula y regresa la media aritmética
         */
        public static double mediaAritmetica(params int[] vals)
        {

            double promedio = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                promedio += vals[i];
            }

            return promedio / vals.Length;
        }

        /**
         * Calcula y regresa la raiz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n)
        {

            return Math.Pow(x, (1 / (double)n));
        }

        /**
         * Usa raizEnesima para calcular y regresar la media geométrica
         */
        public static double mediaGeometrica(params int[] vals) {

            double media = 1;

            for (byte i = 0; i < vals.Length; i++)
                media *= vals[i];

            return Math.Round(raizEnesima(media, vals.Length), 2);

        }

        /**
         * Este método no está implementado
         */
        public static double mediaArmonica(params int[] vals)
        {
            throw new NotImplementedException();
            //throw new System.ArgumentException("MÉTODO NO IMPLEMENTADO", "MÉTODO MEDIA ARMÓNICA");

            /*
            double sumainferior = 0;
            double resultado = 0;

            for (int i = 0; i < vals.Length; i++)
            {
                sumainferior += (1 / vals[i]);
            }

            resultado = vals.Length / sumainferior;
            return resultado;


            6:mediaArmonica:120 20 100 130:52.61

            */
        }
    }
}
