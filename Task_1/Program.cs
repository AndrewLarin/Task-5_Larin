using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaSK_5_1_Larin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            double s = 0;
            int k = 0;
            //Console.WriteLine("Введите последовательность чисел: ");
            for (int i = 0; i < 7; i++) 
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                k++;            //idk
            }


            Console.WriteLine("Среднее арифметическое равно: ");

            Console.WriteLine((s / k)); // почему нельзя поставить double?
            Console.ReadKey();
        }
    }
}
