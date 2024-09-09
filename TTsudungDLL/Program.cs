using System;
using lib_chanle;

class Program
{
    static void Main(string[] args)
    {
        kiemtra checker = new kiemtra();

        Console.Write("Nhap mot so nguyen: ");
        int number = int.Parse(Console.ReadLine());

        string result = checker.Main(number);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
