using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoriali_library
{
    public class FAtoriali
    {
        static public int Fattoriale(int number)
        {
            if (number < 0)
                return 0;
            else if (number <= 1)
                return 1;
            else
            {
                int prod = 1;
                for (int i = 2; i <= number; i++)
                {
                    prod *= i;

                }
                return prod;
            }
        }
    }
}
