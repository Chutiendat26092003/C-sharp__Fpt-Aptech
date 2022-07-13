using System;
using System.Collections.Generic;
interface IDetails
{
    void GetDetails();
}

class Student: IDetails
{
    string _studName;
    int _stuID;
    public Student(string studName, int stuID)
    {
        _studName = studName;
        _stuID = stuID;
    }

    public void GetDetails()
    {
        Console.WriteLine(_stuID + "\t" + _studName);
    }
}
class GenericList<T> where T : IDetails
{
    T[] _values = new T[3];
    int _counter = 0;
    public void Add(T val)
    {
        _values[_counter] = val;
        _counter++; 
    }
    public void Display()
    {
        for (int i = 0; i < 3; i++)
        {
            _values[i].GetDetails();
        }
    }
}

class InterfaceConstrainDemo
{
    static void Main(string[] args)
    {
        GenericList<Student> objList = new GenericList<Student>();
        objList.Add(new Student("Wilson", 120));
        objList.Add(new Student("Jakc", 130));
        objList.Add(new Student("Peter", 140));
        objList.Display();
    }
}