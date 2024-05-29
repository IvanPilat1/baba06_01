using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                // Введення даних для паралелограма
                Console.WriteLine("Введiть основу паралелограма (A): ");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введiть висоту паралелограма (H): ");
                double h = double.Parse(Console.ReadLine());

                Console.WriteLine("Введiть кут мiж основою i боковою стороною паралелограма (в градусах): ");
                double alfa = double.Parse(Console.ReadLine()) * (Math.PI / 180); // Кут в радіанах

                Parallelogram parallelogram = new Parallelogram
                {
                    A = a,
                    H = h,
                    Alfa = alfa
                };

                double parallelogramPerimeter = parallelogram.GetPerimeter();
                Console.WriteLine($"Периметр паралелограма: {parallelogramPerimeter}");

                // Введення даних для трапеції
                Console.WriteLine("Введiть першу основу трапецiї (C): ");
                double c = double.Parse(Console.ReadLine());

                Console.WriteLine("Введiть другу основу трапецiї (D): ");
                double d = double.Parse(Console.ReadLine());

                Console.WriteLine("Введiть висоту трапецiї (H): ");
                double ht = double.Parse(Console.ReadLine());

                Trapezium trapezium = new Trapezium
                {
                    C = c,
                    D = d,
                    H = ht
                };

                double trapeziumPerimeter = trapezium.GetPerimeter();
                Console.WriteLine($"Периметр трапецiї: {trapeziumPerimeter}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
