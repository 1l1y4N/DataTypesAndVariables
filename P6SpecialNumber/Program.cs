using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                int result = i.ToString().Sum(c => c - '0');
                
                if (result==5)
                {
                    Console.WriteLine("{0}->True",i);
                } else if (result == 7)
                {
                    Console.WriteLine("{0}->True", i);
                }
                else if (result == 11)
                {
                    Console.WriteLine("{0}->True", i);
                }
                else
                {
                    Console.WriteLine("{0}->False", i);
                }
            }
        }
    }
}
