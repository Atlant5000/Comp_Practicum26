using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    /// <summary>
    /// 1) Заполнить одномерный массив из n элементов с клавиатуры и вывести его на экран.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Vvod();
            int[] omas = new int[n];
            Vvodmass(omas,n);
            Vivodmass(omas);
            Console.ReadLine();
        }
        public static int Vvod()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            return n; 
        }
        public static void Vvodmass(int[] omas,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
            }
            
        }
        public static void Vivodmass(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }

    }
}
