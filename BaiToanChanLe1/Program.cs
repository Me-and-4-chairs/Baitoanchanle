using System;

namespace BaiToanChanLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cấu hình Console để sử dụng mã hóa UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập một số nguyên: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{number} là số lẻ.");
            }

            Console.ReadKey();
        }
    }
}
