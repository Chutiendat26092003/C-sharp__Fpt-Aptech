using System;
using System.Collections;
class Deparment : IEnumerable
{
    string[] departmentNames = { "Marketing", "Finance", "Information", "Technology", "Human Resources" };
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < departmentNames.Length; i++)
        {
            yield return departmentNames[i];
        }
    }

    static void Main(string[] args)
    {
        Deparment objDepartment = new Deparment();
        Console.WriteLine("Department Names");
        Console.WriteLine();
        foreach(string str in objDepartment)
        {
            Console.WriteLine(str);
        }
    }
}