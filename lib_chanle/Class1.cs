using System;
using System.Collections.Generic;
using System.Text;


namespace lib_chanle
{
    public class kiemtra
    {
        public string Main(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} là số chẵn!";
            }
            else
            {
                return $"{number} là số lẻ!";
            }
        }
    }
}
