using System;
using System.Text;
class ThreeNumber
{
    static void Main(string[] args)
    {
        int num;

        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Mời bạn nhập số (1-7): ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.ReadLine();

        switch(num)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default: 
                Console.WriteLine("Chỉ nhận số (1-7)");
                break;
        }


    }
}
