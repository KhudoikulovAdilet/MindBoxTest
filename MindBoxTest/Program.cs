using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("S - вычислить площадь круга");
            Circle circle = new Circle();
            Console.WriteLine("D - вычислить площадь треугольника");
            Triangle triangle = new Triangle();
            Console.WriteLine("K - вычислить площадь любого четырехугольника");
            Chetyrehugolnik chetyrehugolnik = new Chetyrehugolnik();
            var key = Console.ReadKey();
            Console.WriteLine();

            switch(key.Key)
            {
                case ConsoleKey.S:
                    Console.WriteLine("Введите радиус круга");
                    circle.Radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Площадь круга радиусом {circle} равна {circle.Square()}");
                    break;
                    case ConsoleKey.D:
                    Console.WriteLine("Введите значение стороны 1");
                    triangle.Storona1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны 2");
                    triangle.Storona2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны 3");
                    triangle.Storona3 = Convert.ToInt32(Console.ReadLine());

                    if(Math.Pow(triangle.Storona3, 2) == Math.Pow(triangle.Storona2, 2) + Math.Pow(triangle.Storona1, 2))
                    {
                        Console.WriteLine("У вас прямоугольный треугольник");
                        Console.WriteLine($"Площадь прямоугольного треугольника равна {triangle.Ploshad()}");
                    }
                    else
                    {
                        Console.WriteLine($"Площадь треугольника равна {triangle.TrianSquare()}");
                    }
                    break;
                case ConsoleKey.K:
                    Console.WriteLine("");
                         Console.WriteLine("Введите значение стороны A");
                    chetyrehugolnik.A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны B");
                    chetyrehugolnik.B = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение H");
                    chetyrehugolnik.H = Convert.ToInt32(Console.ReadLine());
                    if (chetyrehugolnik.H == 0)
                    {
                        Console.WriteLine($"Площадь прямоугольника равна {chetyrehugolnik.kvadrat()}");
                    }
                    else if(chetyrehugolnik.B == 0)
                    {
                        Console.WriteLine($"Площадь параллелограмма равна {chetyrehugolnik.paralelogram()}");
                    }
                    else
                    {
                        Console.WriteLine($"Площадь трапеции равна {chetyrehugolnik.trapetzia()}");
                    }
                    
                    break;

            }

          
            Console.ReadLine();
        }
    }
}
