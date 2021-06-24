using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
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

        static int simpleArraySum(int[] arr2)
        {
            int suma = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                suma += arr2[i];
            }
            return suma;
        }

        static void Pedir(string m, ref int n)
        {
            Console.Write("{0} ", m);
            n = int.Parse(Console.ReadLine());
        }

        static void Pedir(string m, ref double n)
        {
            Console.Write("{0} ", m);
            n = int.Parse(Console.ReadLine());
        }

        static void Pedir(string m, string n)
        {
            Console.Write("{0} ", m);
            n = Console.ReadLine();
        }

        /*----------------- Ejercicios de estudios ---------------*/
        // Diseñar un algoritmo que permita ingresar por teclado el nombre,
        // edad y ciudad de una persona, los resultados deben mostrarse en pantalla.
        static void Ejercicio1()
        {
            string nombre, ciudad;
            int edad;
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese ciudad: ");
            ciudad = Console.ReadLine();

            Console.WriteLine("\nNombre: " + nombre + "\nEdad: " + edad + "\nCiudad: " + ciudad);
        }

        // Diseñar un algoritmo que permita calcular el salario mensual de un 
        // trabajador teniendo en cuenta los días que trabajo y el valor de cada día.
        static void Ejercicio2()
        {
            char cont;
            string nombre;
            double diasTrab, valorDia, suma = 0;
            do
            {
                Console.Write("Ingrese nombre del trabajador: ");
                nombre = Console.ReadLine();

                Console.Write("Valor del dia: ");
                valorDia = double.Parse(Console.ReadLine());

                Console.Write("Dias trabajados: ");
                diasTrab = double.Parse(Console.ReadLine());

                suma = valorDia * diasTrab;

                Console.WriteLine("\nNombre: " + nombre + "\nValor del día: " + valorDia + "\nDias Trabajados: " + diasTrab + "\nTotal del pago: " + suma);

                Console.Write("\nContinuar con otro tranajdor S/N?: ");
                cont = char.Parse(Console.ReadLine());
            } while (cont == 'S' || cont == 's');
        }

        // Diseñar un algoritmo que permita calcular las operaciones aritméticas básicas
        // ingresando 2 valores numéricos por teclado.
        static void Ejercicio3()
        {
            double n1 = 0, n2 = 0, result = 0;

            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Datos(ref n1, ref n2);
                        Console.WriteLine("\nSuma: {0}", result = n1 + n2); Console.ReadKey(); Ejercicio3(); break;
                    case 2:
                        Datos(ref n1, ref n2);
                        Console.WriteLine("\nResta: {0}", result = n1 - n2); Console.ReadKey(); Ejercicio3(); break;
                    case 3:
                        Datos(ref n1, ref n2);
                        Console.WriteLine("\nMultiplicacion: {0}", result = n1 * n2); Console.ReadKey(); Ejercicio3(); break;
                    case 4:
                        Datos(ref n1, ref n2);
                        Console.WriteLine("\nDivision: {0}", result = n1 / n2); Console.ReadKey(); Ejercicio3(); break;
                    case 5: Console.Write("\nSaliendo! "); break;
                    default:
                        Console.WriteLine("\nError opciones del 1 al 5!"); Console.ReadKey(); Ejercicio3();
                        break;
                }
            } while (opc > 0 && opc <= 4);
        }

        static void Datos(ref double n1, ref double n2)
        {
            Console.WriteLine("\nDatos de ecuaciones aritmeticas");
            Console.Write("\nIngrese un num#: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese un num#: ");
            n2 = double.Parse(Console.ReadLine());
        }

        // Diseñar un algoritmo que permita aplicar un descuento en el supermercado
        // de tal forma que permita visualizar el monto a pagar después de aplicar dicho
        // procedimiento.
        static void Ejercicio4()
        {
            char resp;
            do
            {
                Console.Write("Nombre del producto: ");
                string prod = Console.ReadLine();

                Console.Write("Precio del producto: ");
                double precio = double.Parse(Console.ReadLine());

                Console.Write("Porcentaje Descuento del producto %: ");
                double desc = double.Parse(Console.ReadLine());

                double totalDes = (precio * desc) / 100;
                double aplicarDesc = precio - totalDes;

                Console.Write("\nProducto: {0}", prod);
                Console.Write("\nPrecio con descuento: {0}", aplicarDesc);

                Console.Write("\n\nDesea realizar otra compra S/N: ");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 'S' || resp == 's');
        }

        //En un salón de clase nos pide diseñar un algoritmo que permita determinar
        //el porcentaje de varones y el porcentaje de mujeres.
        //Cantidad de Niños 78 - Niñas 43.
        static void Ejercicio5()
        {
            int niños = 0, niñas = 0;
            double suma = 0, respV = 0, respF = 0;
            Pedir("De la cantidad de niños: ", ref niños);
            Pedir("De la cantidad de niñas: ", ref niñas);

            suma = niños + niñas;
            respV = (niños * 100) / suma;

            respF = (niñas * 100) / suma;

            Console.Write("\nEl procentaje de niños es: {0} %", respV.ToString("0.##"));
            Console.Write("\nEl procentaje de niñas es: {0} %", respF.ToString("0.##"));
        }

        //Determina su área y volumen de un cilindro, aplicando un radio ingresando
        //su valor por teclado y también su altura.
        static void Ejercicio6()
        {
            double area = 0, volumen = 0, radio = 0, altura = 0;

            Pedir("Ingrese el radio del cilindro: ", ref radio);
            Pedir("Ingrese el altura del cilindro: ", ref altura);

            area = (2 * Math.PI * Math.Pow(radio, 2));
            double area2 = (2 * Math.PI * radio);
            volumen = Math.PI * Math.Pow(radio, 2) * altura;
            double volumen2 = Math.PI * radio * altura;

            Console.Write("\nArea con PI: {0} PI", area2.ToString("0.##"));
            Console.Write("\nArea: {0}", area.ToString("0.##"));
            Console.Write("\nVolumen con PI: {0} PI", volumen2.ToString("0.##"));
            Console.Write("\nVolumen: {0}", volumen.ToString("0.##"));
        }

        //Diseñar un algoritmo que lea por consola el valor de una factura, en este
        //caso aplicaremos un IGV 18% (Perú).
        static void Ejercicio7()
        {
            double igv = 18, fact = 0;
            Pedir("De el valor de la factura: ", ref fact);

            double conv = (fact * igv) / 100;
            double resp = fact + conv;

            Console.Write("\nIGV del 18%: {0}", conv.ToString("0.##"));
            Console.Write("\nAplicando IGV: {0}", resp.ToString("0.##"));
        }

        //Realizar un algoritmo de tipo de cambio de moneda sabiendo que
        //1 dólar es igual a 3.34 soles peruanos.
        static void Ejercicio8()
        { }

        /*
         Defina un algoritmo que permita calcular la nota final de un alumno, teniendo en cuenta que ha realizado 
        3 evaluaciones y que cada evaluación esta sometida a un peso , el cual es:

          *  La primera nota tiene un peso de 25%

          *  La segunda nota tiene un peso de 45%

          *  La tercera nota tiene un peso de 30%
         */
        static void Ejercicio9()
        { }

        //Defina un algoritmo que permita calcular el nuevo salario de un trabajador si a
        //este le incrementaron su sueldo en un 25% adicional a su sueldo anterior.
        static void Ejercicio10()
        { }

        /*
         Un alumno desea saber cual será su calificación final en la materia de Matemáticas, dicha calificación 
        se compone por 3 porcentajes , a su vez cada porcentaje tiene cierta cantidad de notas, primero diremos los siguiente:

          * La nota de los 3 primeros exámenes parciales tiene un peso de 55%.

          * La nota del examen final tiene un peso de 30%.

          * La nota del trabajo final tiene un peso de 15%.

            Hallar la calificación final de todas notas
         */
        static void Ejercicio11()
        { }

        /*
         Tenemos un trabajador gana S/69.23 al día, durante 26 días laborables, nos pide hallar cuanto 
        recibe de sueldo y cuanto se aporta a su seguro pensionario si se sabe que el porcentaje de 
        aporte mensual es el 11.74% el cual esta compuesto por :

          *  10% ingresa a su AFP.

          *  0.38% es el Cobro por la administración e inversión de tu fondo.

          *  1.36% por Seguro de Invalidez, Sobrevivencia y Gastos de Sepelio.
         */
        static void Ejercicio12()
        { }
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

	    //Ejercicios Algoritmos Secuenciales
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
            //Ejercicio9();
            //Ejercicio10();
            //Ejercicio11();
            //Ejercicio12();
            Console.ReadKey();
        }
    }
}
