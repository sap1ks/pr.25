using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //Console.Write("n=");
            //int n= int.Parse(Console.ReadLine());
            //int[]omas = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write($"omas[{i}]=");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}

            //Console.ReadKey();

            ////task2
            ////int[] omas = new int[] { -1, 5, 0, -3, 2, -2 };
            ////foreach(int el in omas)
            ////{
            ////    Console.WriteLine($"{el}/t");
            ////}
            ////Console.ReadKey();
            int[] omas = new int[6];
            Random rnd= new Random();
            for(int i = 0; i < omas.Length; i++)
            {
                omas[i]=rnd.Next(-10, 10);
            }
            foreach(var element in omas)
            {
                Console.Write($"{element}\t");
            }
            Console.ReadKey();
        }
    }
}
