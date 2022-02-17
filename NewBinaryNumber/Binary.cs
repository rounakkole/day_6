using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBinaryNumber
{
    internal class Binary
    {
        public void GetBinary(int number)
        {
            int[] Array = new int[8] { 128, 64, 32, 16, 8, 4, 2, 1 };
            int power2 = Array[0];
            int i = 4;
            int answer = 0;
            int bit;
            while (power2 > 0)
            {
                if (number >= power2)
                {
                    number -= power2;
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }
                power2 /= 2;
                answer += (bit * Array[i]);
                i++;
                i = i == 8 ? 0 : i;
            }
            Console.WriteLine(answer);
        }
    }
}
