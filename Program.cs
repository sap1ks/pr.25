using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int n = int.Parse(Console.ReadLine());
            //    int[] masiv = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"masiv[{i}]=");
            //        masiv[i] = int.Parse(Console.ReadLine());
            //    }
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine($"masiv[{i}]={masiv[i]}");
            //    }
            //    Console.ReadLine();


            //    Console.Write("n=");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] masiv = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"massiv[{i}]=");
            //        masiv[i] = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"masiv[{i}]={masiv[i]}");
            //    }
            //    Console.ReadLine();

            //    Инициализировать одномерный массив с использованием конструктора, без указания размерности массива и без клавиатуры. 
            //    int[] masiv = new int[] { 3, -3, 5, 6, -7, 8 };
            //    foreach (var element in masiv)
            //    {
            //        Console.Write($"{element}\t");

            //    }
            //    Console.ReadLine();

            //    Заполнить одномерный массив соответствующими индексами и вывести с использованием цикла foreach.
            //    int[] mass = new int[] { 1, 2, 3, 4, 5 };
            //    foreach (var element in mass)
            //    {
            //        Console.WriteLine(mass[0]);
            //        Console.WriteLine(mass[1]);
            //        Console.WriteLine(mass[2]);
            //        Console.WriteLine(mass[3]);
            //        Console.WriteLine(mass[4]);
            //        Console.Read();
            //    }

            //Заполнить одномерный массив случайным образом и вывести на экран с использованием цикла foreach.
            int[] masiv = new int[6];
        Random x = new Random();
            for (int i = 0; i<masiv.Length; i++)
            {
                Console.WriteLine($"masiv[{i}]=");
                masiv[i] = x.Next(-10, 10);
            }
            foreach (var i in masiv)
            {
                Console.WriteLine($"{i}\t");
            }
Console.ReadLine();
        }
    }
}
