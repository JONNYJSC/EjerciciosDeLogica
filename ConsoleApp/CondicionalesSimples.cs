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
        static void Imp(string m)
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
                Console.Write("\nLa suma es: {0}", suma.ToString("N2"));
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
                Imp("\nNota desaprobatoria 0! \nPor Inhasistencia");
            else
                Imp("\nAprobado!");
        }

        //Diseña un algoritmo que lea 2 números y visualice si son positivos.
        public void condicional4()
        {
            double n1 = 0, n2 = 0;
            Pedir("Ingrese el 1er número: ", ref n1);
            Pedir("Ingrese el 2do número: ", ref n2);

            if (n1 > 0 && n2 > 0)
                Console.WriteLine("Son números positivos! {0} y {1}", n1, n2);
            else if (n1 > 0 && n2 < 0)
                Console.WriteLine("El número 1 es positivo {0}", n1);
            else if (n2 > 0 && n1 < 0)
                Console.WriteLine("El número 2 es positivo {0}", n2);
        }

        /*Un hombre desea saber cuanto dinero se genera por concepto de intereses 
        en relación la cantidad que tiene en inversión en el banco. 
        
         El decidirá reinvertir los intereses siempre y cuando estos no excedan a $7000, 
         y en ese caso diseña un algoritmo para saber cuanto dinero tendrá finalmente en su cuenta.
         */
        public void condicional5()
        {
            double dinero = 0, interes = 0, mes = 0;
            Pedir("De la cantidad de dinero: $", ref dinero);
            Pedir("De la cantidad de interes: %", ref interes);
            Pedir("De la cantidad de meses: ", ref mes);

            if (dinero <= 7000)
            {
                double resp = (dinero * interes) / mes;
                Console.WriteLine("cantidad que tiene en inversión en el banco. $ {0}", resp.ToString("N2"));
            }
            else
                Console.WriteLine("\nSobrepaso los $7000");
        }

        /*6. Diseñar un algoritmo que lea el nombre de un empleado, su salario básico por hora, 
        el nro. de horas trabajadas en un mes. Nos pide lo siguiente:

        Calcular su salario mensual adicionalmente el subsidio de transporte, si su sueldo es 
        mayor o igual a 2 salarios mínimos legal vigente. Tener en cuenta que el salario mínimo 
        es 9000 córdobas y el subsidio por transporte es 500 córdobas.

        Mostrar: el nombre del empleado, su salario mensual, el subsidio de transporte y su sueldo neto.*/

        public void condicional6()
        {
            double salBxHora = 0, nHtrabaj = 0, transp = 5.56, subTransp = 0;
            string nombre = "";

            Pedir("Ingrese su nombre: ", ref nombre);
            Pedir("Ingrese su salario basico por hora: ", ref salBxHora);
            Pedir("Ingrese el número de horas trabajadas en el mes: ", ref nHtrabaj);
            //160 horas = 20 dias
            //dias 56.25
            //salario 9,000
            //5.56% trasnporte
            double salMensual = salBxHora * nHtrabaj;


            if (salMensual >= 9000 || salMensual >= (9000 * 2))
            {
                subTransp = (salMensual * transp) / 100;
                Console.WriteLine("nombre: {0}", nombre);
                Console.WriteLine("Salario por Hora: {0}", salBxHora);
                Console.WriteLine("Horas del mes trabajadas: {0}", nHtrabaj);
                Console.WriteLine("Salario mensual: {0}", salMensual.ToString("N2"));
                Console.WriteLine("Subsidio por transporte: {0}", subTransp.ToString("N2"));
            }
            else
                Console.WriteLine("\nNo llega al salario minimo! \nSu salario mensual fue de: {0}", salMensual.ToString("N2"));
        }

        /*Diseñe un algoritmo que lea el nombre del estudiante, el valor de su matricula en un 
        diplomado que responda si¿ Es egresado de la universidad?, si la respuesta es SI, se le 
        aplica un 25 % descuento. Muestre el nombre del estudiante y el valor de la matricula a pagar.*/
        public void condicional7()
        {
            double matricula = 0, aplDes = 0;
            string nombre = "", s1 = "", s2 = "SI";

            Pedir("Nombre del estudiante: ", ref nombre);
            Pedir("¿Es egresado de la universidad? Si/No: ", ref s1);
            s1 = s1.ToUpper();
            int s = String.Compare(s1, s2);
            if (s >= 0)
            {
                Pedir("Pagar matricula: ", ref matricula);
                double des = (matricula * 25) / 100;
                aplDes = matricula - des;

                Console.WriteLine("\nNombre: {0}", nombre);
                Console.WriteLine("Matricula: {0}", aplDes);
            }
            else if (s < 0)
            {
                Pedir("Pagar matricula: ", ref matricula);

                Console.WriteLine("\nNombre: {0}", nombre);
                Console.WriteLine("Matricula: {0}", matricula);
            }
        }

        /*Diseñar un algoritmo que muestre si una persona tiene ingresos o no, pero para ser mas 
        específicos se responderá a las siguientes preguntas:

         * Si no tiene efectivo entonces esta en nros rojos.

         * Si tiene poco efectivo menor a 1000, que muestre que debe trabajar mas.

         * Si tiene un efectivo menor a 2000 entonces significa que le va regularmente bien.

         * Si tiene un efectivo mayor a 2000 entonces significa que tiene buen status financiero.*/
        public void condicional8()
        {
            double ingreso = 0;

            Pedir("Ingresos: ", ref ingreso);
            
            if(ingreso == 0)
                Console.WriteLine("Su efectivo esta en números rojos");
            else if (ingreso <= 1000)
                Console.WriteLine("Debe trabajar mas");
            else if (ingreso > 1000 || ingreso <= 2000)
                Console.WriteLine("Le va regularmente bien");
            else if (ingreso > 2000)
                Console.WriteLine("Tiene buen status financiero");
        }
    }
}
