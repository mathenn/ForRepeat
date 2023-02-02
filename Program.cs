using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OddsValues();
        }

        static void OddsValues()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }

        static void RangeValues()
        {
            int n = int.Parse(Console.ReadLine());

            int count_in = 0;
            int count_out = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    count_in = count_in + 1;
                }
                else
                {
                    count_out = count_out + 1;
                }
            }

            Console.WriteLine(count_in +" in");
            Console.WriteLine(count_out +" out");
        }
    }
}