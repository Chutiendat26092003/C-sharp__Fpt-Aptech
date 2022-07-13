using System;
using System.Collections.Generic;
class GenericDepartment<T>
{
    T[] item;
    public GenericDepartment(T[] item)
    {
        this.item = item;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach(T item in item)
        {
            yield return item;
        }
    }
}

class GenericIterator
{
    static void Main(string[] args)
    {
        string[] args1 = { "Marketing", "Finance", "Information Technology", "Human Resources" };
        GenericDepartment<string> objGenericName = new GenericDepartment<string>(args1);
        foreach(string arg in args1)
        {
            Console.Write(arg + "\t\t");
        }

        int[] departmentID = { 101, 110, 210, 220 };
        GenericDepartment<int> objGenericID = new GenericDepartment<int>(departmentID);
        Console.WriteLine();
        foreach(int arg in departmentID)
        {
            Console.Write(arg + "\t\t");
        }

        Console.WriteLine();
    }
}


