using System;
using System.Linq;

namespace ConsoleApp
{
    public class Principal
    {
        /*
         Se proporciona una matriz A no vacía que consta de N números enteros. La matriz contiene un número 
        impar de elementos, y cada elemento de la matriz se puede emparejar con otro elemento que tenga el 
        mismo valor, excepto por un elemento que se deja sin emparejar.

        Por ejemplo, en la matriz A tal que:
 
             A [0] = 9 
             A [1] = 3 
             A [2] = 9
             A [3] = 3 
             A [4] = 9
             A [5] = 7
             A [6] = 9

            ●	los elementos en los índices 0 y 2 tienen valor 9,
            ●	los elementos en los índices 1 y 3 tienen valor 3,
            ●	los elementos en los índices 4 y 6 tienen valor 9,
            ●	el elemento en el índice 5 tiene valor 7 y no está emparejado.

         */
        static int solution(int[] arr)
        {
            arr = arr.OrderBy(x => x).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[i + 1] || arr[i] == arr[i - 1])
                    continue;
                else
                    return arr[i];
            }
            return 0;
        }        

        public static int simpleArraySum(int[] arr2)
        {
            int suma = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                suma += arr2[i];
            }
            return suma;
        }

        // Si pienso en un número, le sumo 9, multiplico al resultado por 3,
        // al total le resto 5 y finalmente divido lo mobtenido por 4, el 
        // resultado final es 7. ¿Cuál fue el número que pénse al comienzo?
        static void resultado7()
        {
            int nPensado = 0;
            Console.WriteLine("El resultado tiene que dar a 7");
            Pedir("Número pensasdo: ", ref nPensado);
            double suma = nPensado + 9;
            double mult = suma * 3;
            double resta = mult - 5;
            double div = resta / 4;
            Console.Write("Respuesta: {0}", div.ToString("0.##"));
            Console.WriteLine("\nNúmero pensado: {0}", nPensado);
        }

        static void Pedir(string m, ref int n)
        {
            Console.Write("{0} ", m);
            n = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            //int[] arr = { 9, 3, 9, 3, 9, 7, 9 };
            //int[] arr2 = { 1, 2, 3, 4, 10, 11, 5 };
            //int a = solution(arr);
            //int b = simpleArraySum(arr2);
            //int c = sumadeMatriz(arr, arr2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //resultado7();

            Secuenciales Pract1 = new Secuenciales();

            //Ejercicios Algoritmos Secuenciales
            //Pract1.Ejercicio1();
            //Pract1.Ejercicio2();
            //Pract1.Ejercicio3();
            //Pract1.Ejercicio4();
            //Pract1.Ejercicio5();
            //Pract1.Ejercicio6();
            //Pract1.Ejercicio7();
            //Pract1.Ejercicio8();
            //Pract1.Ejercicio9();
            //Pract1.Ejercicio10();
            //Pract1.Ejercicio11();
            //Pract1.Ejercicio12();

            CondicionalesSimples Pract2 = new CondicionalesSimples();

            //Ejercicios Algoritmos Condicionales Simples
            //Pract2.condicional1();
            //Pract2.condicional2();
            //Pract2.condicional3();
            //Pract2.condicional4();
            //Pract2.condicional5();
            Pract2.condicional6();

            Console.ReadKey();
        }
    }
}
