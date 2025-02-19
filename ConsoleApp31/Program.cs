using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    /// <summary>
    /// 2) Заполнить одномерный массив случайным образом целыми числами из интервала от -10 до 10, просмотреть значения массива и найти количество четных элементов. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Vvod();
            int[] omas = new int [n];
            Vvodmass(omas,n);
            Vivodmass(omas);
            Console.ReadLine();
        }
        public static int Vvod()
        {
            Console.Write("n=");
            int n=int.Parse(Console.ReadLine());
            return n;
        }
        public static void Vvodmass(int[] omas,int n)
        {
            Random random = new Random();
            for (int i = 0; i<n;i++)
            {
                omas[i] = random.Next(-10, 10);
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        public static void Vivodmass(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        public static void Elements(int[] omas)
        {
            int f= 0;
            if omas
            Console.WriteLine($"Количество чётных елементов={f}");
        }
    }
}
