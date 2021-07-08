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
                Imp("Ingrese un valor ditinto de 0!");
        }

        /*Una persona es apta para prestar el servicio militar obligatorio cuando esta en el rango de edad entre
        18 y 25 años, ademas que los postulantes deberan ser de genero masculino.

         * Realizar un algoritmo que permita determinar si una persona es apta o no para prestar el servicio
        militar.*/
        public void condDoble2()
        {
            int edad = 0;
            char sexo = ' ';
            Pedir("ingrese su edad: ", ref edad);
            Pedir("ingrese su sexo M/F: ", ref sexo);

            if (edad >= 18 && edad <= 25 && sexo == 'M' && sexo == 'm')
            {
                Imp("\nUsted es apto para entrar al servicio militar");

            }
            else { Imp("\nNo cuenta con la edad requerida debe ser entre 18 y 25"); }
        }

        /*Una empresa quiere hacer una compra de varias piezas de la misma clase a una fabrica. Dependiendo 
        del monto total de la compra, se decidirá que hacer para pagar al fabricante, para esto plantea lo 
        siguiente:

        * Si el monto total de la compra excede $500 000 la empresa tendrá la capacidad de invertir de su 
        propio dinero en 50% del monto de la compra, pedir prestado al banco un 30%, y el restante 20% 
        lo pagara solicitando un crédito al fabricante.

        * Caso contrario si el monto total de la compra no excede de $500 000 la empresa tendrá la capacidad 
        de invertir su propio dinero un 70% , pedir prestado al banco un 25% y el restante 5% lo pagara 
        solicitando crédito al fabricante.

        * Diseñar un algoritmo que determine el monto propio del dinero de la empresa, el monto del prestamo 
        otorgado por el banco y el crédito otorgado al fabricante.*/
        public void condDoble3()
        {
            double montoTCompra = 0, invertir = 0, prestBanco = 0, creditoF = 0;

            Pedir("De el monto de la compra: ", ref montoTCompra);

            if (montoTCompra >= 500000)
            {
                invertir = (montoTCompra * 50) / 100;
                prestBanco = (montoTCompra) * 30 / 100;
                creditoF = (montoTCompra * 20) / 100;

                Imp("\nEl monto total es igual o sobre pasa la capacidad de compra de la empresa del 50%");
                Console.Write("\nMonto total: {0}", montoTCompra.ToString("N2"));
                Console.Write("\nCapacidad de inversion de la empresa: {0}", invertir.ToString("N2"));
                Console.Write("\nPrestamo al banco: {0}", prestBanco.ToString("N2"));
                Console.Write("\nCredito al fabricante: {0}", creditoF.ToString("N2"));
            }
            else if (montoTCompra < 500000)
            {
                invertir = (montoTCompra * 70) / 100;
                prestBanco = (montoTCompra) * 25 / 100;
                creditoF = (montoTCompra * 5) / 100;

                Imp("\nEl monto total no excede la capacidad de compra de la empresa del 70%");
                Console.Write("\nMonto total: {0}", montoTCompra.ToString("N2"));
                Console.Write("\nCapacidad de inversion de la empresa: {0}", invertir.ToString("N2"));
                Console.Write("\nPrestamo al banco: {0}", prestBanco.ToString("N2"));
                Console.Write("\nCredito al fabricante: {0}", creditoF.ToString("N2"));
            }
        }

        /*Una tienda ha puesto en oferta la venta al por mayor de cierto producto, ofreciendo un descuento 
        el 15% por la compra de mas de 3 docenas y 10% en caso contrario.

        * Diseñe un algoritmo que determine el monto de la compra, el monto del descuento y el monto a pagar.*/
        public void condDoble4()
        {
            string nameP = "";
            double precio = 0, cant = 0, desc = 0, resta = 0, mult = 0;

            Pedir("Nombre del producto: ", ref nameP);
            Pedir("Ingrese el precio del producto: ", ref precio);
            Pedir("Ingrese la cantidad del producto: ", ref cant);

            if (cant >= 36)
            {
                mult = precio * cant;
                desc = (mult * 15) / 100;
                resta = mult - desc;

                Console.Write("\nNombre producto: {0}", nameP);
                Console.Write("\nPrecio por unidad producto: {0}", precio.ToString("N2"));
                Console.Write("\nPrecio total sin descuento producto: {0}", mult.ToString("N2"));
                Console.Write("\nDescuento producto: {0}", desc.ToString("N2"));
                Console.Write("\nTotal a pagar: {0}", resta.ToString("N2"));
            }
            else if (cant < 36)
            {
                mult = precio * cant;
                desc = (mult * 10) / 100;
                resta = mult - desc;

                Console.Write("\nNombre producto: {0}", nameP);
                Console.Write("\nPrecio por unidad producto: {0}", precio.ToString("N2"));
                Console.Write("\nPrecio total sin descuento producto: {0}", mult.ToString("N2"));
                Console.Write("\nDescuento producto: {0}", desc.ToString("N2"));
                Console.Write("\nTotal a pagar: {0}", resta.ToString("N2"));
            }
        }

        /*  Se ha establecido un programa para estimular a los alumnos, el cual consiste en que si la nota 
            promocional obtenido por los alumnos durante todo el año en cada materia, se calculará las 6 notas 
            finales de cada materia cursada. Si la nota promocional es mayor o igual a 60 se le aplicará un 
            descuento del 30% en la matricula del estudiante, caso contrario se le aplicará un 10% adicional 
            en el pago de su matricula.

            * Diseñe un algoritmo que determine el monto del descuento y el monto a pagar.*/

        public void condDoble5()
        {
            int cNotas = 0;
            double suma = 0, nFinal = 0, matric = 200, desc = 0, total = 0;
            Pedir("De la cantidad de notas: ", ref cNotas);
            double[] notas = new double[cNotas];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("De la nota #{0}: ", i + 1);
                notas[i] = double.Parse(Console.ReadLine());
                suma += notas[i];
            }
            nFinal = suma / notas.Length;

            if (nFinal >= 60)
            {
                desc = (matric * 30) / 100;
                total = matric - desc;

                Console.Write("\nSu nota final fue de: {0}\n", nFinal.ToString("N2"));
                Console.Write("\nMatricula valor: {0}", matric.ToString("N2"));
                Console.Write("\nDescuento: {0}", desc.ToString("N2"));
                Console.Write("\nTotal a pagar: {0}", total.ToString("N2"));
            }
            else
            {
                desc = (matric * 10) / 100;
                total = desc + matric;

                Console.Write("\nSu nota final fue de: {0}\n", nFinal.ToString("N2"));
                Console.Write("\nMatricula valor: {0}", matric.ToString("N2"));
                Console.Write("\nPago adicional: {0}", desc.ToString("N2"));
                Console.Write("\nTotal a pagar: {0}", total.ToString("N2"));
            }
        }

        /*  En un supermercado se hace una promoción mediante la cual el cliente obtiene un descuento 
            dependiendo de un número que se escoge al azar. Si el número escogido es menor que 74, se aplicará 
            un descuento del 15% en relación al total de la compra, si es mayor e igual a 74 el descuento 
            aplicado será del 20%. Obtener cuanto dinero se le descuenta.*/
        public void condDoble6()
        {
            double tCompra = 0, suma = 0, desc = 0;
            Random rd = new Random();
            int azar = rd.Next(0, 148);

            Pedir("Monto total de compras: ", ref tCompra);
            Console.WriteLine(azar);
            if (azar < 74)
            {
                desc = (tCompra * 15) / 100;
                suma = tCompra - desc;

                Console.Write("\nMonto compra: {0}", tCompra.ToString("N2"));
                Console.Write("\nDescuento compra: {0}", desc.ToString("N2"));
                Console.Write("\nMonto Total: {0}", suma.ToString("N2"));
            }
            else if (azar >= 74)
            {
                desc = (tCompra * 20) / 100;
                suma = tCompra - desc;

                Console.Write("\nMonto compra: {0}", tCompra.ToString("N2"));
                Console.Write("\nDescuento compra: {0}", desc.ToString("N2"));
                Console.Write("\nMonto Total: {0}", suma.ToString("N2"));
            }
        }

        /*Determinar si un alumno aprueba o reprueba un curso, sabiendo que aprobará si su promedio de 
        tres calificaciones es mayor o igual a 60, caso contrario reprobará. */
        public void condDoble7()
        {
            int cNotas = 0;
            double suma = 0;
            Pedir("Ingrese la cantidad de calificaciones: ", ref cNotas);
            double[] calif = new double[cNotas];

            for (int i = 0; i < calif.Length; i++)
            {
                Console.Write("Nota #{0}: ", i + 1);
                calif[i] = double.Parse(Console.ReadLine());
                suma += calif[i];
            }
            double prom = suma / calif.Length;
            if (prom >= 60)
                Imp("\nApróbado");
            else if (prom < 60)
                Imp("\nRepróbado");
        }

        /*Diseñar un algoritmo que permita emitir una factura correspondiente a una compra de un articulo 
        del cual se adquieren varias unidades, lo que sabe es que solo tenemos el precio, pero sin IGV (18%).

        * Si el monto total supera los $/70 entonces aplicamos un descuento del 5%, de lo contrario pagará 
        el total calculado, tener en cuenta incluir el precio + IGV.
        */
        public void condDoble8()
        {
            double convDolar = 0, igv = 18, precio = 0, desc = 0, total = 0, iva = 0;

            Pedir("De el precio del producto: ", ref precio);
            convDolar = precio / 35.2;

            if (convDolar > 70)
            {
                double sumaIGV = (precio * igv) / 100;
                total = precio + sumaIGV;
                double totalSinDesc = total;
                desc = (total * 5) / 100;
                total = total - desc;
                double tFinal = total;
                convDolar = tFinal / 35.2;
                Console.Write("\nPrecio: {0} + iva: {1}", precio.ToString("N2"), sumaIGV.ToString("N2"));
                Console.Write("\nLa cantidad de pago sin descuento es: {0}", totalSinDesc.ToString("N2"));
                Console.Write("\nLa cantidad de descuento del 5% es: {0}", desc.ToString("N2"));
                Console.Write("\nLa cantidad a pagar en córdoba es: {0}", total.ToString("N2"));
                Console.Write("\nLa cantidad a pagar en dólares es: {0}", convDolar.ToString("N2"));
            }
            else if (convDolar < 70)
            {
                iva = (precio * igv) / 100;
                total = precio + iva;
                convDolar = total / 35.2;
                Console.Write("\nPrecio: {0} + iva: {1}", precio.ToString("N2"), iva.ToString("N2"));
                Console.Write("\nLa cantidad a pagar en córdoba es: {0}", total.ToString("N2"));
                Console.Write("\nLa cantidad a pagar en dólares es: {0}", convDolar.ToString("N2"));
            }
        }

        /*Diseñar un algoritmo para determinar si el numero ingresado por teclado es par o impar.*/
        public void condDoble9()
        {
            double numero = 0;
            Pedir("De un número: ", ref numero);

            if (numero % 2 == 0)
                Imp("\nEl número es par");
            else
                Imp("\nEs impar");
        }

        /*Desarrollar un algoritmo que permita hallar el sueldo neto y descuento provisional de un 
        trabajador, tener en cuenta que si un cargo es administrativo se le descontará el 12% del sueldo 
        bruto, y si es operativo se le descontara el 17%.*/

        public void condDoble10()
        {
            double descPro = 0, sal = 0, cargo = 0, total = 0;

            Pedir("Ingrese su salario bruto: ", ref sal);
            Pedir("Elija su cargo: \n1. Administrativo\n2. Operativo\n Opcion: ", ref cargo);

            if (cargo == 1)
            {
                descPro = (sal * 12) / 100;
                total = sal - descPro;
                Console.Write("\nSe le desconto el 12%: {0}, Salario: {1}", descPro.ToString("N2"), total.ToString("N2"));
            }
            else if (cargo == 2)
            {
                descPro = (sal * 17) / 100;
                total = sal - descPro;
                Console.Write("\nSe le desconto el 17%: {0}, Salario: {1}", descPro.ToString("N2"), total.ToString("N2"));
            }
        }

        /*
         Los empleados de una fábrica trabajan en dos turnos: diurno y nocturno. El jornal diario se 
            paga según:

             * Tarifa diurna $50 por hora.

             * Tarifa nocturna $80 por hora.

             * Teniendo en cuenta el número de horas diurnas y nocturnas que trabajo un empleado durante 
            el día elaborar un algoritmo que calcule cuanto debe pagársele si se le debe descontar un 1% 
            si gana más de $600.

         */
        public void condDoble11()
        {
            double hDiurno = 0, hNoct = 0, diasTrab = 0, sumaD = 0, sumaN = 0, total = 0, desc = 0, sumGeneral = 0;

            Pedir("De la cantidad de días trabajados: ", ref diasTrab);
            Pedir("Horas trabajadas en horario diurno: ", ref hDiurno);
            Pedir("Horas trabajadas en horario nocturno: ", ref hNoct);

            sumaD = hDiurno * diasTrab;
            sumaN = hNoct * diasTrab;

            total = sumaD + sumaN;

            if (total > 600)
            {
                desc = (total * 1) / 100;
                sumGeneral = total - desc;
                Console.Write("\nSalario: $ {0}", sumGeneral.ToString("N2"));
            }
            else if (total < 600)
                Console.Write("\nSalario: $ {0}", total.ToString("N2"));
        }

        /*
         Una empresa desea conocer el monto de comisión correspondiente a una venta realizada por 
        un vendedor bajo las siguientes condiciones:

         * Si la venta es menor a $1000 se le otorga el 3% de comisión al vendedor.

         * Si la venta es de $1000 a más el vendedor recibirá el 5% de comisión.
         */
        public void condDoble12()
        {
            double precio = 0, comision = 0, suma = 0;
            char resp = ' ';
            do
            {
                Console.Clear();
                Pedir("De el precio: ", ref precio);
                suma += precio;

                Pedir("Desea realizar otra compra S/N: ", ref resp);
            } while (resp == 'S' || resp == 's');

            if (suma < 1000)
            {
                comision = (suma * 3) / 100;
                Console.Write("\nComisión del vendedor es de: {0}", comision.ToString("N2"));
            }
            else if (suma > 1000)
            {
                comision = (suma * 5) / 100;
                Console.Write("\nComisión del vendedor es de: {0}", comision.ToString("N2"));
            }
        }

        public void orden()
        {
            int[] n = new[] { 1, 8, 5, 6, 4 };

            Console.WriteLine("\nImpresion con for");
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(" {0} ", n[i]);
            }
            Console.WriteLine("\nOrdenando array con LINQ: int[] m = n.OrderBy(x => x).ToArray();");
            int[] m = n.OrderBy(x => x).ToArray();
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(" {0} ", m[i]);
            }
            int f = n.FirstOrDefault();
            Console.WriteLine("\nPrimer elemento: {0}", f);
            int w = n.LastOrDefault();
            Console.WriteLine("\nÚltimo elemento: {0}", w);
            int g = n.Max();
            Console.WriteLine("\nmaximo: {0}", g);
            int h = n.Min();
            Console.WriteLine("\nmanimo: {0}", h);

            Console.WriteLine("Impresion inversa LINQ: Reverse()");
            IEnumerable<int> j = n.Reverse();
            foreach (var l in j)
            {
                Console.Write(l + " ");
            }

            Console.WriteLine("\nImpresion for reversa");
            for (int q = n.Length - 1; q >= 0; q--)
            {
                Console.Write(n[q] + " ");
            }
        }
    }
}
