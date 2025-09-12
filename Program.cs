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

            Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Primer ejercicio");
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Segundo ejercicio");
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Tercer ejercicio");
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Cuarto ejercicio");
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Quinto ejercicio");
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sexto ejercicio");
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Séptimo ejercicio");
            Console.ResetColor();

            //Séptimo ejercicio

            Double celsius;
            Double fahrenheit;
            
            Console.WriteLine("Ingrese la temperatura en grados Celsius");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"La temperatura en grados Fahrenheit es {fahrenheit}");
            
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Octavo ejercicio");
            Console.ResetColor();

            //Octavo ejercicio
            Double radio;   
            Double areaCirculo;
            Double perimetro;
            Double pi = 3.1416;
            
            Console.WriteLine("Ingrese el radio del circulo");
            radio = Convert.ToDouble(Console.ReadLine());
            areaCirculo = (pi * (radio * radio));
            perimetro = (2 * pi * radio);
            Console.WriteLine($"El área del circulo es {areaCirculo}");
            Console.WriteLine($"El perímetro del circulo es {perimetro}");
            
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Noveno ejercicio");
            Console.ResetColor();
            
            //Noveno ejercicio

            Double numero1;
            Double numero2;
            Double suma;
           
            Console.WriteLine("Ingrese el primer número");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            numero2 = Convert.ToDouble(Console.ReadLine());
            suma = (numero1 + numero2);
            Console.WriteLine($"La suma de los dos números es {suma}");
            
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Décimo ejercicio");
            Console.ResetColor();

            //Décimo ejercicio
            Double baseRectangulo;
            Double alturaRectangulo;
            Double areaRectangulo;

            Console.WriteLine("Ingrese la base del rectángulo");
            baseRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectángulo");
            alturaRectangulo = Convert.ToDouble(Console.ReadLine());
            areaRectangulo = (baseRectangulo * alturaRectangulo);
            Console.WriteLine($"El área del rectángulo es {areaRectangulo}");
            
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Onceavo ejercicio");
            Console.ResetColor();

            //Onceavo ejercicio
            Double deposito;    
            Double interes;
            Double totalConInteres;
            
            Console.WriteLine("Ingrese la cantidad de dinero a depositar");
            deposito = Convert.ToDouble(Console.ReadLine());
            interes = (deposito * 0.04);
            totalConInteres = (deposito + interes);
            Console.WriteLine($"El total con el interés del 4% es {totalConInteres}");
            
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Doceavo ejercicio");
            Console.ResetColor();

            //Doceavo ejercicio

            Double precioProducto12;
            Double descuento12;
            Double totalPagar12;
            
            Console.WriteLine("Ingrese el precio del producto");
            precioProducto12 = Convert.ToDouble(Console.ReadLine());
            descuento12 = (precioProducto12 * 0.10);
            totalPagar12 = (precioProducto12 - descuento12);
            Console.WriteLine($"El total a pagar con el descuento del 10% es {totalPagar12}");
            
            Console.ReadKey();

            









        }
    }
}
