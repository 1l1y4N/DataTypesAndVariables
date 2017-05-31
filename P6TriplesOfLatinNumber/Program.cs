using System;


namespace P6TriplesOfLatinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            char letter = (char)('a' + range);
            for (char i = 'a'; i < letter; i++)
            {
                for (char j = 'a'; j < letter; j++)
                {
                    for (char k = 'a'; k < letter; k++)
                    {
                        Console.Write(i);
                        Console.Write(j);
                        Console.Write(k);
                        Console.Write("\r\n");
                    }
              
                }
                
            }

        }
    }
}
