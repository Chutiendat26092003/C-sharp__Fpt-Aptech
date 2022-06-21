using System;
using System.Text;
class ThreeNumber
{
    static void Main(string[] args)
    {
        int num1, num2, num3;

        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thứ 1 :");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số thứ 2 :");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số thứ 3 :");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.ReadLine();

        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("Số lớn nhất :{0}", num1);
        } else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("Số lớn nhất :{0}", num2);
        } else
        {
            Console.WriteLine("Số lớn nhất :{0}", num3);
        }


    }
}
