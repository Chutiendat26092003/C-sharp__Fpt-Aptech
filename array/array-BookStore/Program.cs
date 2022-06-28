using System;

namespace BookStore
{
    class Authors
    {
        static void Main(string[] args)
        {
            Array objAuthorID = Array.CreateInstance(typeof(int), 3);
            Array objAuthorNames = Array.CreateInstance(typeof(string), 3);
            Array objAddress = Array.CreateInstance(typeof(string), 3);
            Array objState = Array.CreateInstance(typeof(string), 3);


            string input = "";
            for (int i = 0; i < objAuthorID.Length; i++)
            {
                Console.Write("Enter the ID of author: ");
                input = Console.ReadLine();
                objAuthorID.SetValue(Convert.ToInt32(input), i);

                Console.Write("Enter the name of author: ");
                input = Console.ReadLine();
                objAuthorNames.SetValue(input, i);

                Console.Write("Enter the address: ");
                input = Console.ReadLine();
                objAddress.SetValue(input, i);

                Console.Write("Enter the name of state: ");
                input = Console.ReadLine();
                objState.SetValue(input, i);

                Console.WriteLine();
            }

            Console.WriteLine("\n Details of the authors: \n");
            Console.WriteLine("Author ID\tName\t\tAddress\t\t\tState");
            for (int i = 0; i < objAuthorID.Length; i++)
            {
                Console.Write(objAuthorID.GetValue(i) + "\t\t");
                Console.Write(objAuthorNames.GetValue(i) + "\t");
                Console.Write(objAddress.GetValue(i) + "\t\t\t");
                Console.WriteLine(objState.GetValue(i));
            }

            Array.Sort(objAuthorNames);
            Console.WriteLine("\nAuthor names after sorting: \n");
            for (int i = 0; i <= objAuthorID.GetUpperBound(0); i++)
            {
                Console.WriteLine(objAuthorNames.GetValue(i) + "\t");
            }
        }
    }
}