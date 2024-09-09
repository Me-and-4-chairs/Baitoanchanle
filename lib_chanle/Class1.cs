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
                return $"{number} la so chan";
            }
            else
            {
                return $"{number} la so le.";
            }
        }
    }
}
