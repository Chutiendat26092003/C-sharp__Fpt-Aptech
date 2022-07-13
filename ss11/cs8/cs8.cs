using System;
using System.Collections;
using System.Collections.Generic;
class Generic<T, U>
{
    T _valOne;
    U _valTwo;

    public void AcceptValues(T item)
    {
        _valOne = item;

    }
    public void AcceptValues(U item)
    {
        _valTwo = item;
    }

    public void Display()
    {
        Console.WriteLine(_valOne + "\t" + _valTwo);
    }
}

class MethodOverload
{
    static void Main(string[] args)
    {
        Generic<int, string> objGenOne = new Generic<int, string>();
        objGenOne.AcceptValues(10);
        objGenOne.AcceptValues("Smith");
        Console.WriteLine("ID\tName\tDesignation\tSalary");
        objGenOne.Display();
        Generic<string, float> objGenTwo = new Generic<string, float>();
        objGenTwo.AcceptValues("Mechanic");
        objGenTwo.AcceptValues(2500);
        Console.Write("\t");
        objGenTwo.Display();
        Console.WriteLine();
    }
}