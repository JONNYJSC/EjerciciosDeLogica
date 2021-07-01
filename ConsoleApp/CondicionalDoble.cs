using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CondicionalDoble
    {
        static void Pedir(string m, ref char n)
        {
            Console.Write("{0} ", m);
            n = char.Parse(Console.ReadLine());
        }
        static void Pedir(string m, ref int n)
        {
            Console.Write("{0} ", m);
            n = int.Parse(Console.ReadLine());
        }

        static void Pedir(string m, ref double n)
        {
            Console.Write("{0} ", m);
            n = double.Parse(Console.ReadLine());
        }

        static void Pedir(string m, ref string n)
        {
            Console.Write("{0} ", m);
            n = Console.ReadLine();
        }
        static void Imp(string m)
        {
            Console.Write("{0} ", m);
        }

        /*-------------Ejercicios con condicionales Dobles-------------------------*/

        /*Tenemos un algortimo para resolver una ecuacion de segundo grado. La ecuación es:
            * ax2 + bx + c = 0
          Determinar las soluciones o raices de la ecuación
          asignar valor: a, b y c
         */
        public void condDoble1()
        {
            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;
            Pedir("De el valor de a: ", ref a);
            Pedir("De el valor de b: ", ref b);
            Pedir("De el valor de c: ", ref c);

            double cuad = Math.Pow(b, 2);
            double multi = (4 * a * (c * -1));
            double div = (2 * a);
            //result guarda el resultado para calcular la raiz 
            double result = (cuad + multi);
            double raiz = Math.Sqrt(result);

            //Conversión a negativo
            double result1 = -b * 1;
            double result2 = -b * 1;

            //s1 guarda el resultado de -b + raiz para dividirlo y x1 toma la respuesta 
            double s1 = result1 + raiz;
            x1 = s1 / div;
            double s2 = result2 - raiz;
            x2 = s2 / div;

            Console.WriteLine("\nx1: {0}\nx2: {1}", x1, x2);
        }
    }
}
