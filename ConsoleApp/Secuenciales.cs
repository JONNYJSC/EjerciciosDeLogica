using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Secuenciales
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

        /*----------------- Ejercicios de estudios ---------------*/
        // Diseñar un algoritmo que permita ingresar por teclado el nombre,
        // edad y ciudad de una persona, los resultados deben mostrarse en pantalla.
        static void Ejercicio1()
        {
            string nombre = "", ciudad = "";
            int edad = 0;
            Pedir("Ingrese nombre: ", ref nombre);
            Pedir("Ingrese edad: ", ref edad);
            Pedir("Ingrese ciudad: ", ref ciudad);

            Console.WriteLine("\nNombre: " + nombre + "\nEdad: " + edad + "\nCiudad: " + ciudad);
        }

        // Diseñar un algoritmo que permita calcular el salario mensual de un 
        // trabajador teniendo en cuenta los días que trabajo y el valor de cada día.
        static void Ejercicio2()
        {
            char cont = ' ';
            string nombre = "";
            double diasTrab = 0, valorDia = 0, suma = 0;
            do
            {
                Pedir("Ingrese nombre del trabajador: ", ref nombre);
                Pedir("Valor del dia: ", ref valorDia);
                Pedir("Dias trabajados: ", ref diasTrab);

                suma = valorDia * diasTrab;

                Console.WriteLine("\nNombre: " + nombre + "\nValor del día: " + valorDia + "\nDias Trabajados: " + diasTrab + "\nTotal del pago: " + suma);

                Pedir("\nContinuar con otro tranajdor S/N?: ", ref cont);
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
                Pedir("Calculadora");
                Pedir("1. Suma");
                Pedir("2. Resta");
                Pedir("3. Multiplicacion");
                Pedir("4. Division");
                Pedir("5. Salir");
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
            Pedir("\nDatos de ecuaciones aritmeticas");
            Pedir("\nIngrese un num#: ", ref n1);
            Pedir("Ingrese un num#: ", ref n2);
        }

        // Diseñar un algoritmo que permita aplicar un descuento en el supermercado
        // de tal forma que permita visualizar el monto a pagar después de aplicar dicho
        // procedimiento.
        static void Ejercicio4()
        {
            char resp = ' ';
            string prod = "";
            double precio = 0, desc = 0;
            do
            {
                Pedir("Nombre del producto: ", ref prod);
                Pedir("Precio del producto: ", ref precio);

                Pedir("Porcentaje Descuento del producto %: ", ref desc);

                double totalDes = (precio * desc) / 100;
                double aplicarDesc = precio - totalDes;

                Console.Write("\nProducto: {0}", prod);
                Console.Write("\nPrecio con descuento: {0}", aplicarDesc);

                Pedir("\n\nDesea realizar otra compra S/N: ", ref resp);
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
        //1 dólar es igual a 35.5 córdobas.
        static void Ejercicio8()
        {
            char r = ' ';
            double dolarAcord = 0, dolar = 0, resp = 0;
            do
            {
                Pedir("Ingrese el valor del dólar actual: ", ref dolarAcord);
                Pedir("Ingrese la cantidad en dólares: ", ref dolar);
                resp = dolarAcord * dolar;
                Console.Write("Cambio a moneda Córdoba: {0} ", resp.ToString("0.##"));

                Pedir("\nDesea seguir S/N: ", ref r);
            } while (r == 'S' || r == 's');
        }

        /*
         Defina un algoritmo que permita calcular la nota final de un alumno, teniendo en cuenta que ha realizado 
        3 evaluaciones y que cada evaluación esta sometida a un peso , el cual es:

          *  La primera nota tiene un peso de 25%

          *  La segunda nota tiene un peso de 45%

          *  La tercera nota tiene un peso de 30%
         */
        static void Ejercicio9()
        {
            int[] notas = new int[3];
            for (int i = 0; i < notas.Length; i++)
            {
                Pedir("De la nota: ", ref notas[i]);
            }
            double n1 = notas[0] * 25 / 100;
            double n2 = notas[1] * 45 / 100;
            double n3 = notas[2] * 30 / 100;

            double suma = n1 + n2 + n3;
            Console.WriteLine("\nNota Final {0}", suma);
        }

        //Defina un algoritmo que permita calcular el nuevo salario de un trabajador si a
        //este le incrementaron su sueldo en un 25% adicional a su sueldo anterior.
        static void Ejercicio10()
        {
            double sal = 0;
            Pedir("De su salario: ", ref sal);
            double calc = sal * 25 / 100;
            double nuevoSal = sal + calc;
            Console.WriteLine("\nSalario anterior {0} aumento del 25% {1}", sal, nuevoSal);
        }

        /*
         Un alumno desea saber cual será su calificación final en la materia de Matemáticas, dicha calificación 
        se compone por 3 porcentajes , a su vez cada porcentaje tiene cierta cantidad de notas, primero diremos los siguiente:

          * La nota de los 3 primeros exámenes parciales tiene un peso de 55%.

          * La nota del examen final tiene un peso de 30%.

          * La nota del trabajo final tiene un peso de 15%.

            Hallar la calificación final de todas notas
         */
        static void Ejercicio11()
        {
            double exParc = 0, suma = 0, exfinal = 0, trab = 0;
            int[] parciales = new int[3];
            for (int i = 0; i < parciales.Length; i++)
            {
                Pedir("De la nota de examenes parciales: ", ref exParc);
                suma += exParc;
            }

            double nParc = (suma * 55) / 100;
            double nParcF = nParc / parciales.Length;
            Pedir("De la nota del examen final: ", ref exfinal);
            Pedir("De la nota del trabajo final: ", ref trab);

            double exf = exfinal * 30 / 100;
            double trabF = trab * 15 / 100;

            Console.WriteLine("\nNota de examenes parciales: {0}", nParcF.ToString("0.##"));
            Console.WriteLine("\nNota de examen final: {0}", exf);
            Console.WriteLine("\nNota de trabajo final: {0}", trabF);

            double nFinal = nParcF + exf + trabF;
            Console.WriteLine("\nCalificación Final de Matemáticas es: {0}", nFinal.ToString("0.##"));
        }

        /*
         Tenemos un trabajador gana S/69.23 al día, durante 26 días laborables, nos pide hallar cuanto 
        recibe de sueldo y cuanto se aporta a su seguro pensionario si se sabe que el porcentaje de 
        aporte mensual es el 11.74% el cual esta compuesto por :

          *  10% ingresa a su AFP.

          *  0.38% es el Cobro por la administración e inversión de tu fondo.

          *  1.36% por Seguro de Invalidez, Sobrevivencia y Gastos de Sepelio.
         */
        static void Ejercicio12()
        {
            double diasTrab = 0, salDia = 0;
            Pedir("De la cantidad salario diario: ", ref salDia);
            Pedir("De la cantidad de dias trabajados: ", ref diasTrab);
            double diasMult = salDia * diasTrab;
            double pension = (diasMult * 11.74) / 100;
            double afp = (diasMult * 10) / 100;
            double invFondo = (diasMult * 0.38) / 100;
            double seguroInv = (diasMult * 1.36) / 100;
            double salActual = diasMult - pension;

            Console.Write("\nSalario de dias trabajados sin deducciones: {0}", diasMult.ToString("0.##"));
            Console.Write("\nCantidad de dias trabajados: {0}", diasTrab.ToString("0.##"));
            Console.Write("\nSalario diario: {0}", salDia.ToString("0.##"));
            Console.Write("\nPension del 11.74%: {0}", pension.ToString("0.##"));
            Console.Write("\nIngreso a su AFP 10%: {0}", afp.ToString("0.##"));
            Console.Write("\nCobro por la administración 0.38%: {0}", invFondo.ToString("0.##"));
            Console.Write("\nSeguro de Invalidez: {0}", seguroInv.ToString("0.##"));
            Console.Write("\nDeducciones: {0}", pension.ToString("0.##"));
            Console.Write("\nSalario de dias trabajados con deducciones: {0}", salActual.ToString("0.##"));
        }
    }
}
