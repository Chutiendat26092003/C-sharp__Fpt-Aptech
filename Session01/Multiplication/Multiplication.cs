using System;
using System.Text;
class ThreeNumber
{
    static void Main(string[] args)
    {
        int num, i;

        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Mời bạn nhập số (1-9): ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.ReadLine();

        if ( 1<=num && num<=9 )
        {
            for (i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        } else
        {
            Console.WriteLine("Số bạn nhập k trong khoảng (1-9)");
        }

    }
}

