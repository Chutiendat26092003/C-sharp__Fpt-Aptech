using System;
using System.Collections.Generic;

class General<T>
{
    T[] values;
    int _counter = 0;
    public General (int max)
    {
        values = new T[max];
    }

    public void Add(T val)
    {
        if (_counter < values.Length)
        {
            values[_counter++] = val;
            _counter++;
        }
    }
    public void Display()
    {
        Console.WriteLine("Contructed Class is of type: " + typeof(T));
        Console.WriteLine("Vakues stored in the object of constructed class are: ");
        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine(values[i]);
        }
    }
}
class Students
{
    static void Main(string[] args)
    {
        General<string> objGeneral = new General<string>(3);
        objGeneral.Add("John");
        objGeneral.Add("Patrick");
        objGeneral.Display();
        General<int> objGeneral2 = new General<int>(2);
        objGeneral2.Add(200);
        objGeneral2.Add(35);
        objGeneral2.Display();
    }
}