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
        public void condicional1()
        {
            double n1 = 0, n2 = 0, suma = 0;
            Pedir("Ingresar el 1er número: ", ref n1);
            Pedir("Ingresar el 2do número: ", ref n2);

            suma = n1 + n2;

            if (suma >= 0)
                Console.Write("\nLa suma es: {0}", suma.ToString("0.##"));
            else if (suma < 0)
                Console.Write("La suma es negativa!");
        }

        //Diseñar un algoritmo que al ingresar la edad de un usuario, y si es mayor de edad debe aparecer un mensaje
        //indicando que si lo es.
        public void condicional2()
        {
            int edad = 0;
            Pedir("Ingrese su edad: ", ref edad);

            if (edad >= 18)
                Console.Write("Si eres mayor de edad, tienes {0}", edad);
            else if (edad < 18)
                Console.Write("Eres menor de edad, tienes {0}", edad);
        }

        //Diseñe un algoritmo que capture el nombre de un estudiante, el nombre del curso, ->omitir(nota definitiva)<-, el número
        //de asistencia para las clases del semestre y el número de clases ausentes. En el caso que las ausencias superan el 20% del número
        //de clases en el semestre debe mostrar la nota desaprobatoria en este caso 0.
        public void condicional3()
        {
            string nombre = "", nombreCurso = "";
            //double nDefinitva = 0;
            int claseSemestre = 0, clasesAusentes = 0;

            Pedir("Ingrese su nombre: ", ref nombre);
            Pedir("Ingrese el nombre del curso: ", ref nombreCurso);
            //Pedir("Ingrese la ota definitiva: ", ref nDefinitva);
            Pedir("Ingrese el  número de clases del semestre: ", ref claseSemestre);
            Pedir("Ingrese el  número de clases ausentes: ", ref clasesAusentes);

            double porc = (claseSemestre * 20) / 100;
            double result = Math.Ceiling(porc);

            if (clasesAusentes >= result)
                Console.Write("\nNota desaprobatoria 0! \nPor Inhasistencia");
            else
                Console.Write("\nAprobado!");
        }
    }
}
