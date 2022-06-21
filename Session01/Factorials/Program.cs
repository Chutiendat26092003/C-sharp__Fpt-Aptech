using System;
using System.Text;
class ThreeNumber
{
    static void Main(string[] args)
    {
        int num, i, fac=1;

        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Mời bạn nhập số trong đoạn 1-20: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.ReadLine();

        if (1 <= num && num <= 20)
        {
            for (i = num; i >= 1; i--)
            {
                fac = fac * i;
            }
            Console.WriteLine("{0}! = {1}", num, fac);

        }
        else
        {
            Console.WriteLine("Số bạn nhập k trong đoạn 1-20");
        }

    }
}

