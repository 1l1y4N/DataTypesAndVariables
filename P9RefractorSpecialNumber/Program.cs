using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9RefractorSpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;
            for (int num = 1; num <= totalNumber; num++)
            {
                int currentNumber = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecial}");
                sum = 0;
                num = currentNumber;
            }
        }
    }
}
