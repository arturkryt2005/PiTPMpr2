using System;

class Program
{
    static void Main()
    {
        double storona1, storona2, storona3;

        Console.WriteLine("Введите данные сторон треугольника"); 
            if (double.TryParse(Console.ReadLine(), out storona1) && double.TryParse(Console.ReadLine(), out storona2) && double.TryParse(Console.ReadLine(), out storona3))
            {
                if (storona1 > 0 && storona2 > 0 && storona3 > 0)
                {
                    if (storona1 + storona2 > storona3 && storona1 + storona3 > storona2 && storona2 + storona3 > storona1)
                    {
                        if (storona1 == storona2 && storona2 == storona3)
                        {
                            Console.WriteLine("Равносторонний треугольник");
                            double s = CalculateArea(storona1, storona2, storona3);
                            Console.WriteLine($"Площадь треугольника: {s}");
                        }
                            else if (storona1 == storona2 || storona1 == storona3 || storona2 == storona3)
                            {
                                Console.WriteLine("Равнобедренный треугольник");
                                double s = CalculateArea(storona1, storona2, storona3);
                                Console.WriteLine($"Площадь треугольника: {s}");
                            }
                                else
                                {
                                    Console.WriteLine("Разносторонний треугольник");
                                    double s = CalculateArea(storona1, storona2, storona3);
                                    Console.WriteLine($"Площадь треугольника: {s}");
                                }
                                
                    }
                    else
                    {
                        Console.WriteLine("Треугольник с заданными сторонами не существует.");
                    }
                }
                else
                {
                    Console.WriteLine("Все стороны треугольника должны быть положительными числами.");
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные. Пожалуйста, введите числа.");
            }
    }

        static double CalculateArea(double a, double b, double c)//Формула Герона
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
}