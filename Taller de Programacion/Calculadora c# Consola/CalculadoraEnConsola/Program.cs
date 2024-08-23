using System;

namespace CalculadoraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguirUsando = true;

            while (seguirUsando)
            {
                Console.Clear(); // Add this line to clear the console screen

                Console.WriteLine("Bienvenido a la calculadora de operaciones basicas");
                Console.WriteLine("Por favor ingrese el primer numero");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("Por favor ingrese el primer numero");
                }

                Console.WriteLine("Por favor ingrese el segundo numero");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("Por favor ingrese el segundo numero");
                }

                Console.WriteLine("Elija la operacion que desea realizar:");
                Console.WriteLine("Presione 1 para sumar");
                Console.WriteLine("Presione 2 para restar");
                Console.WriteLine("Presione 3 para multiplicar");
                Console.WriteLine("Presione 4 para dividir");

                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option (1-4).");
                    Console.WriteLine("Elija la operacion que desea realizar:");
                    Console.WriteLine("Presione 1 para sumar");
                    Console.WriteLine("Presione 2 para restar");
                    Console.WriteLine("Presione 3 para multiplicar");
                    Console.WriteLine("Presione 4 para dividir");
                }

                double resultado = 0;
                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("El resultado de la resta es: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("El resultado de la division es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre cero");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("¿Desea seguir usando la calculadora? (S/N)");
                string respuesta = Console.ReadLine().ToUpper();

                if (respuesta != "S")
                {
                    seguirUsando = false;
                }
            }
        }
    }
}