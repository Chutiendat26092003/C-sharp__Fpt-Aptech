using System;
class Pattern
{
    static void Main(string[] args)
    {
        int i = 0;
        int j;
        while (i <= 5)
        {
            j = 0;
            while (j <= i)
            {
                Console.WriteLine("*");
                j++;
            }
            Console.WriteLine();
            i++;
        }
    }
}