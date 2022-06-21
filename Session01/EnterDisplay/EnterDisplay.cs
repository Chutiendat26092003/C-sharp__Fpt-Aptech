using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EnterDisplay
{
    static void Main(string[] args)
    {
        string name, address, phone;

        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Nhập tên :");
        name = Console.ReadLine();

        Console.WriteLine("Nhập địa chỉ :");
        address = Console.ReadLine();

        Console.WriteLine("Nhập số đt :");
        phone = Console.ReadLine();

        Console.Read();

        Console.WriteLine("Tên : {0}, Địa chỉ: {0}, SDT: {0}", name, address, phone);

    }
}