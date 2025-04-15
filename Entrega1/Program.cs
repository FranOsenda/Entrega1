using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace Entrega1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string alumno = "";
            alumno = Console.ReadLine();
            while (alumno == "" || alumno == " ")
            {
                Console.WriteLine("El nombre ingresado es incorrecto. Ingrese un nombre ");
                alumno = Console.ReadLine();
            }

            Console.WriteLine($"{alumno} ingrese cuantas calificaciones va a cargar (Entre 1 y 5)");
            int cantidad_notas = int.Parse(Console.ReadLine());
            while (cantidad_notas < 1 || cantidad_notas > 5)
            {
               Console.WriteLine("La cantidad ingresada es incorrecta, debe ser entre 1 y 5. Intentelo nuevamente.");
                cantidad_notas = int.Parse(Console.ReadLine());
            }

            double suma = 0;
            double nota;
            for (int i = 1; i < cantidad_notas + 1; i++)
            {
                Console.WriteLine($"Ingrese la nota N°{i}: ");
                nota = double.Parse(Console.ReadLine());
                while (nota < 1 || nota > 10)
                {
                    Console.WriteLine("El valor ingresado es incorrecto, debe ser entre 1 y 10. Intentelo nuevamente");
                    nota = double.Parse(Console.ReadLine());
                }
                suma += nota; 
            }
            double promedio = suma / cantidad_notas;
            string calificacion = ""; 
            if (promedio >= 9)
            {
                calificacion = "Excelente";
            }
            else if (promedio >= 7 && promedio < 9)
            {
                calificacion = "Bueno";
            }
            else if (promedio >= 6 && promedio < 7)
            {
                calificacion = "Regular";
            }
            else if (promedio < 6)
            {
                calificacion = "Reprobado";
            }
            Console.WriteLine($"El promedio de {alumno} es: {promedio} y su calificacion es: {calificacion}");
        }
    }           

}