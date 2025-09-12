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


            //Segundo ejercicio
            Double precio;
            Double descuento;
            Double totalPagar;
           
            Console.WriteLine("Ingrese el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            descuento = (precio * 0.15);
            totalPagar = (precio - descuento);
            Console.WriteLine($"El total a pagar con el descuento del 15% es {totalPagar}.");
            
            Console.ReadKey();

            //Tercer ejercicio
            Double precio1;
            Double precio2;
            Double precio3;
            Double precioFinal;
            
            Console.WriteLine("Ingrese el precio del primer producto");
            precio1 = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            Console.WriteLine("Ingrese el precio del segundo producto");
            precio2 = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            Console.WriteLine("Ingrese el precio del tercer producto");
            precio3 = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            precioFinal = (precio1 + precio2 + precio3);
            Console.WriteLine($"El precio final de los tres productos es {precioFinal}.");
            
            Console.ReadKey();

            
            //Cuarto ejercicio
            Double precioProducto;
            Double impuesto;
            Double precioFinalProducto;
            
            Console.WriteLine("Ingrese el precio del producto");
            precioProducto = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            impuesto = (precioProducto * 0.19);
            precioFinalProducto = (precioProducto + impuesto);
            Console.WriteLine($"El precio final del producto con el impuesto del 19% es {precioFinalProducto}.");
            
            Console.ReadKey();

            //Quinto ejercicio
            
            Double salarioHora;
            Double horasTrabajadas;
            Double salarioMensual;
            
            Console.WriteLine("Ingrese el valor de su hora de trabajo");
            salarioHora = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes");
            horasTrabajadas = Convert.ToDouble(Console.ReadLine());
            Console.Beep(900, 500);
            salarioMensual = (salarioHora * horasTrabajadas);
            Console.WriteLine($"Su salario mensual es de {salarioMensual}.");
            
            Console.ReadKey();

            //Sexto ejercicio
            
            Double area;
            Double basetriangulo;
            Double altura;

            Console.WriteLine("Ingresa la base del triagunlo");
            basetriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del triangulo");
            altura = Convert.ToDouble(Console.ReadLine());
            area = (basetriangulo * altura) / 2;
            Console.WriteLine($"El área del triangulo es {area}");

            Console.ReadKey();

            //Séptimo ejercicio
            
            Double celsius;
            Double fahrenheit;
            
            Console.WriteLine("Ingrese la temperatura en grados Celsius");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"La temperatura en grados Fahrenheit es {fahrenheit}");
            
            Console.ReadKey();







        }
    }
}
