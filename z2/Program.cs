//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        int[] msv = (new int[10]).Select(i => rnd.Next(-5, 6)).ToArray();
        Console.WriteLine("Исходный массив:");
        foreach (int i in msv) Console.Write("{0} ", i);
 
        var sum1 = msv.Where((n, i) => (i++ % 2) == 0).Sum();
        Console.Write("\n\nCуммa элементов массива с нечетными номерами: {0}\n\n", sum1);
 
        
    }
}