using System;

class Program 
{
    static void Main()
    {
        bool seguirusando = true;
        while(seguirusando)
        {
            Console.WriteLine("Ingrese la primera nota entre 1.0 y 7.0: ");
            double nota1 = ObtenerNota();
            Console.WriteLine("Ingrese la segunda nota entre 1.0 y 7.0: ");
            double nota2 = ObtenerNota();
            Console.WriteLine("Ingrese la tercera nota entre 1.0 y 7.0: ");
            double nota3 = ObtenerNota();

            //Calcular nuestro promedio
            double promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio de las tres notas es: " + promedio);

            Console.WriteLine("¿Desea seguir usando la calculadora? (S/N)");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta != "S")
            {
                seguirusando = false;
            }
        }
    }

    static double ObtenerNota()
    {
        double nota;
        while (true)
        {
            //intentamos convertir lo que ingreso el usuario a numero
            if (double.TryParse(Console.ReadLine(), out nota))
            {
                //verificamos si la nota esta dentro del rango
                if (nota >= 1.0 && nota <= 7.0) 
                {
                    return nota;
                }
                else
                {
                    Console.WriteLine("Nota fuera de rango, por favor ingrese una nota entre 1.0 y 7.0");
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida, por favor ingrese un numero");
            }
        }
    }
}