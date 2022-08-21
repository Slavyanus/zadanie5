//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



    using System;
    using System.Linq;
     
     
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double[] d = Enumerable.Repeat(0, 10).Select(x => rand.NextDouble()).ToArray();
            Console.WriteLine("Массив d:");
            Console.WriteLine(string.Join(" ", d.Select(x => x.ToString("F2")).ToArray()));
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("Максимум в массиве d: " + d.Max().ToString("F2"));
            Console.WriteLine("Минимум в массиве d: " + d.Min().ToString("F2"));
            Console.WriteLine("Разность для массива d:" + (d.Max() - d.Min()).ToString("F2"));
            Console.WriteLine(new string('-', 25));
            Console.ReadKey(true);
        }
    }