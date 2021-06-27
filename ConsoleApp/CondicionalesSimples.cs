using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CondicionalesSimples
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
        static void Pedir(string m)
        {
            Console.Write("{0} ", m);
        }

        /*-------------Ejercicios con condicionales simples-------------------------*/

        //Diseñar un algoritmo que lea 2 números ingresados por el teclado en la cual al efectuar la suma de 
        //ambos números debe visualizarse los números ingresados y el resultado final, solo si el resultado
        //no es negativo
        public void condicional1() { }

        //Diseñar un algoritmo que al ingresar la edad de un usuario, y si mayor de edad debe aparecer un mensaje
        //indicando que si lo es.
        public void condicional2() { }

        //Diseñe un algoritmo que capture el nombre de un estudiante, el nombre del curso, nota definitiva, el número
        //de clases del semestre y el número de clases ausentes. En el caso que las ausencias superan el 20% del número
        //de clases en el semestre debe mostrar la nota desaprobatoria en este caso 0.
        public void condicional3() { }
    }
}
