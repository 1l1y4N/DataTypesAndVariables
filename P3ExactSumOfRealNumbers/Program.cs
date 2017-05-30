using System;


namespace P3ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = new decimal (0);
            for (int i = 0; i < n; i++)
            {
                decimal d = decimal.Parse(Console.ReadLine());
                sum = sum + d;
            }
            Console.WriteLine(sum);
        }
    }
}
