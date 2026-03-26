using System;
using Proyecto.Decorador;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            TecnmComponent carrera = null;

            // 🎓 MENÚ DE CARRERA
            Console.WriteLine("Seleccione una carrera:");
            Console.WriteLine("1. Ingenieria en Sistemas Computacionales");
            Console.WriteLine("2. Ingenieria en Informatica");
            Console.WriteLine("3. Ingenieria en Ciberseguridad");

            int opcionCarrera = int.Parse(Console.ReadLine());

            switch (opcionCarrera)
            {
                case 1:
                    carrera = new IngSC();
                    break;
                case 2:
                    carrera = new IngI();
                    break;
                case 3:
                    carrera = new IngC();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    return;
            }

            int opcion;

            // 📚 MENÚ DE MATERIAS
            do
            {
                Console.WriteLine("\nSeleccione una materia:");
                Console.WriteLine("1. Fisica");
                Console.WriteLine("2. Calculo");
                Console.WriteLine("3. Programacion");
                Console.WriteLine("0. Terminar");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        carrera = new Fisica(carrera);
                        break;
                    case 2:
                        carrera = new Calculo(carrera);
                        break;
                    case 3:
                        carrera = new Programacion(carrera);
                        break;
                }

            } while (opcion != 0);

            // 🖥️ RESULTADO FINAL
            Console.WriteLine("\n===== RESULTADO FINAL =====\n");
            Console.WriteLine(carrera.Descripcion);
            Console.WriteLine("Clave: " + carrera.Clave);

            Console.ReadKey();
        }
    }
}
