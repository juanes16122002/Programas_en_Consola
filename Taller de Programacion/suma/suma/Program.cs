using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar el primer numero que ingresa el usuario
        Console.Write("Ingrese el primer numero a sumar: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicitar el segundo numero que ingresa el usuario
        Console.Write("Ingrese el segundo numero a sumar: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Sumar los dos numeros ingresados por el usuario
        double suma = numero1 + numero2;

        // Mostrar el resultado de la suma
        Console.WriteLine("La suma de los dos numeros es: " + suma);

        // para que la consola no se cierre automatico al ejecutar, solo se utilizan estas dos lineas de codigo solo se utilizan para ejecutar programas en consola
        Console.WriteLine("Presione una tecla cualquiera");
        Console.ReadKey();
    }
}