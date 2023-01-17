using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagnostica
{
    internal class Diagnostica
    {


        public static void Main(string[] args)
        {
            Variable c = new Variable();

            int ingresos, Empleados;

            Console.WriteLine("/////Programa de calculacion del INNS del empleado/////");
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Digite la cantidad de empleados: ");
                        Empleados = Convert.ToInt32(Console.ReadLine());
                        c.Pempleados(Empleados);
                    } while (Empleados < 1 || Empleados > 10);

                    for (int i = 0; i < Empleados; i++)
                    {
                        do
                        {
                            Console.WriteLine("Digite los ingresos del empleado #" + (i+1));
                            ingresos = Convert.ToInt32(Console.ReadLine());
                            c.Pingresos(ingresos);
                            if (ingresos < 4800 || ingresos > 500000) { Console.WriteLine("Error, digite el dato correcto"); }
                        } while (ingresos < 4800 || ingresos > 500000);
                        Console.WriteLine("El inss laboral del empleado #" + i + " es " + c.calcularInnsL(ingresos));
                        Console.WriteLine("El inss patronal del empleado #" + i + " es " + c.calcularInnsP(ingresos));
                    }

                }
                catch (FormatException e) { Console.WriteLine("No se aceptan letras"); }
                Console.ReadKey();
            }while(true);
            //switch (Empleados)
            //{
            //    case 1:

            //        do
            //        {

            //            Console.WriteLine("Digite la cantidad de ingreso del empleado 1: ");
            //            ingresos = int.Parse(Console.ReadLine());
            //            if (ingresos < 4800 || ingresos > 500000) { Console.WriteLine("Error"); }
            //        } while (ingresos < 4800 || ingresos > 500000);

            //        Console.WriteLine("Empleado #1");
            //        inssL = ingresos * 0.07;
            //        inssP = ingresos * 0.21;
            //        Console.WriteLine("El inss laboral del empleado es " + inssL);
            //        Console.WriteLine("El inss patronal del empleado es "+inssP);

            //        break;

            //        case 2:


            //        do
            //        {
            //            Console.WriteLine("Digite la cantidad de ingreso del empleado 1: ");
            //            ingresos = int.Parse(Console.ReadLine());
            //            if (ingresos < 4800 || ingresos > 500000) { Console.WriteLine("Error"); }
            //        } while (ingresos < 4800 || ingresos > 500000);


            //        Console.WriteLine("Cantidad de Empleados 1");
            //        inssL = ingresos * 0.07;
            //        inssP = ingresos * 0.21;
            //        Console.WriteLine("El inss laboral del empleado 1 es " + inssL);
            //        Console.WriteLine("El inss patronal del empleado 1 es " + inssP);

            //        do
            //        {
            //            Console.WriteLine("Digite la cantidad de ingreso del empleado 2: ");
            //            ingresos = int.Parse(Console.ReadLine());
            //            if (ingresos < 4800 || ingresos > 500000) { Console.WriteLine("Error"); }
            //        } while (ingresos < 4800 || ingresos > 500000);


            //        Console.WriteLine("Cantidad de Empleados 2");
            //        inssL = ingresos * 0.07;
            //        inssP = ingresos * 0.21;
            //        Console.WriteLine("El inss laboral del empleado 2 es " + inssL);
            //        Console.WriteLine("El inss patronal del empleado 2 es " + inssP);

            //        break;
            //    case 3:
            //        do
            //        {
            //            Console.WriteLine("Digite la cantidad de ingreso del empleado 1: ");
            //            ingresos = int.Parse(Console.ReadLine());
            //            if (ingresos < 4800 || ingresos > 500000) { Console.WriteLine("Error"); }
            //        } while (ingresos < 4800 || ingresos > 500000);


            //        Console.WriteLine("Empleado 1");
            //        inssL = ingresos * 0.07;
            //        inssP = ingresos * 0.21;
            //        Console.WriteLine("El inss laboral del empleado 1 es " + inssL);
            //        Console.WriteLine("El inss patronal del empleado 1 es " + inssP);

            //        do
            //        {
            //            Console.WriteLine("Digite la cantidad de ingreso del empleado 2: ");
            //            ingresos = int.Parse(Console.ReadLine());
            //            if (ingresos < 4800 || ingresos > 500000) { Console.WriteLine("Error"); }
            //        } while (ingresos < 4800 || ingresos > 500000);


            //        Console.WriteLine("Empleado 2");
            //        inssL = ingresos * 0.07;
            //        inssP = ingresos * 0.21;
            //        Console.WriteLine("El inss laboral del empleado 2 es " + inssL);
            //        Console.WriteLine("El inss patronal del empleado 2 es " + inssP);


            //        do
            //        {
            //            Console.WriteLine("Digite la cantidad de ingreso del empleado 3: ");
            //            ingresos = int.Parse(Console.ReadLine());
            //            if (ingresos < 4800 || ingresos > 500000) { Console.WriteLine("Error"); }
            //        } while (ingresos < 4800 || ingresos > 500000);


            //        Console.WriteLine("Empleado 3");
            //        inssL = ingresos * 0.07;
            //        inssP = ingresos * 0.21;
            //        Console.WriteLine("El inss laboral del empleado 3 es " + inssL);
            //        Console.WriteLine("El inss patronal del empleado 3 es " + inssP);

            //        break;
            //}
        }

      
    }
    
}
