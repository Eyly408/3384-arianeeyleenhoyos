using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //probando commit
                        Console.WriteLine("Hola Mundo");
            //probando commit 2

            Console.WriteLine("Bienvenidos");

            //Primer ejercicio
            Double sis;
            Double adm;
            Double cont;
            Double total;
            Double porSis;
            Double porAdm;
            Double porCont;

            Console.WriteLine("Ingrese la cantidad de alumnos en Ingenieria de sistemas");
            sis = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            Console.WriteLine("Ingerese la cantidad de alumnos en Administracion");
            adm = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            Console.WriteLine("Ingrese la cantidad de alumnos en Contabilidad");
            cont = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            total = (sis + adm + cont);
            porSis = (sis / total) * 100;
            porAdm = (adm / total) * 100;
            porCont = (cont / total) * 100;
            Console.WriteLine($"El porcentaje de alumnos en Ingenieria de sistemas es {porSis}.");
            Console.WriteLine($"El porcentaje de alumnos en Administracion es {porAdm}.");
            Console.WriteLine($"El porcentaje de alumnos en Contabilidad es {porCont}.");

            Console.ReadKey();

            
            

            

        }
    }
}
