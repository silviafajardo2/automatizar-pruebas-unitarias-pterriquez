using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mate
{
    class Program
    {

        static public int errores = 0;
        static public int successfules = 0;

        static void Main(string[] args)
        {
           
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Terriquez\\Documents\\pruebas.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        if (line != "")
                            operacion(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*Falla*. \nEl archivo no existe, o no se puede leer esta sección.");
                Console.WriteLine(e.Message);
                Console.WriteLine("\n-----------------------------------------------------------\nRESULTADOS: \n");
                Console.WriteLine("ÉXITOS " + successfules);
                Console.WriteLine("ERRORES " + errores);
                Console.WriteLine("\n-----------------------------------------------------------\n");
            }

            Console.ReadKey();
        }

        static void operacion(String line)
        {
            double resultadoEsperado = Double.Parse(line.Substring(line.LastIndexOf(':') + 1));
            int[] arregloDeEnteros = stringToArray(line);

            if (line.Contains("mediaAritmetica"))
                if (medias.mediaAritmetica(arregloDeEnteros) == resultadoEsperado)
                {
                    Console.WriteLine(line + "\nÉxito! Valor Calculado = " + resultadoEsperado + "\n");
                    successfules++;
                }
                else
                {
                    Console.WriteLine(line + "\n*Falla* Media aritmética Esperada = " + resultadoEsperado + ", Calculado = " + medias.mediaAritmetica(arregloDeEnteros) + "\n");
                    errores++;
                }
            else if (line.Contains("mediaGeometrica"))
                if (medias.mediaGeometrica(arregloDeEnteros) == resultadoEsperado)
                {
                    Console.WriteLine(line + "\nÉxito!Valor Calculado = " + resultadoEsperado + "\n");
                    successfules++;
                }
                else
                {
                    Console.WriteLine(line + "\n*Falla* Media geométrica Esperada = " + resultadoEsperado + ", Calculado = " + medias.mediaGeometrica(arregloDeEnteros) + "\n");
                    errores++;
                }
            else if (medias.mediaArmonica(arregloDeEnteros) == resultadoEsperado)
            {
                Console.WriteLine(line + "\nÉxito! Valor Calculado = " + resultadoEsperado + "\n");
                successfules++;
            }
            else
            {
                Console.WriteLine(line + "\n*Falla* Media armónica Esperada = " + resultadoEsperado + ", Calculado = " + medias.mediaArmonica(arregloDeEnteros) + "\n");
                errores++;
            }
        }

        static int[] stringToArray(String line)
        {
            String recortada = line.Substring(line.IndexOf(':', 5) + 1, line.Substring(line.IndexOf(':', 5)).LastIndexOf(':') - 1);
            return recortada.Split(' ').Select(int.Parse).ToArray();
        }
    }
}
