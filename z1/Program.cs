//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
class Program
{
static void Main(string[] args)
{
int[] mas = new int[400];
Random r = new Random();
for (int i = 0; i < mas.Length; i++)
{
mas[i] = r.Next(100, 999);
Console.Write(mas[i] + " ");
}
Console.Read();



}
}
}