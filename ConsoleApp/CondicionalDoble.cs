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
          asignar valor: a=1, b=2 y c=-8
        resultado: x1=2, x2=-4
         */
        public void condDoble1()
        {
            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0, result = 0, raiz = 0, div = 0, result1 = 0, result2 = 0, s1 = 0, s2 = 0;
            Pedir("De el valor de a: ", ref a);
            Pedir("De el valor de b: ", ref b);
            Pedir("De el valor de c: ", ref c);

            if (a != 0 && b != 0 && c != 0)
            {
                double cuad = Math.Pow(b, 2);
                double multi = (4 * a * (c * -1));
                if (multi < 0)
                {
                    double m = multi * -1;

                    div = (2 * a);
                    //result guarda el resultado para calcular la raiz 
                    result = (cuad + m);
                    raiz = Math.Sqrt(result);

                    //Conversión a negativo
                    result1 = -b * 1;
                    result2 = -b * 1;

                    //s1 guarda el resultado de -b + raiz para dividirlo y x1 toma la respuesta 
                    s1 = result1 + raiz;
                    x1 = s1 / div;
                    s2 = result2 - raiz;
                    x2 = s2 / div;

                    Console.WriteLine("\nx1: {0}\nx2: {1}", x1, x2);
                }
                else
                {
                    div = (2 * a);
                    //result guarda el resultado para calcular la raiz 
                    result = (cuad + multi);
                    raiz = Math.Sqrt(result);

                    //Conversión a negativo
                    result1 = -b * 1;
                    result2 = -b * 1;

                    //s1 guarda el resultado de -b + raiz para dividirlo y x1 toma la respuesta 
                    s1 = result1 + raiz;
                    x1 = s1 / div;
                    s2 = result2 - raiz;
                    x2 = s2 / div;

                    Console.WriteLine("\nx1: {0}\nx2: {1}", x1, x2);
                }
            }
            else
                Console.WriteLine("Ingrese un valor ditinto de 0!");
        }
    }
}
