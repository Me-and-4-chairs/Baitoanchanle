using System;
using System.Collections.Generic;
using System.Text;

namespace BaiToanChanLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} la so chan.");
            }
            else
            {
                Console.WriteLine($"{number} la so le.");
            }
            Console.ReadKey();

        }
    }
}