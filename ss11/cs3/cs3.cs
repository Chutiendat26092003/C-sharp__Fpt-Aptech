using System;
using System.Collections.Generic;
class Employee
{
    string _epmName;
    int _empID;
    public Employee(string name, int num)
    {
        _epmName = name;
        _empID = num;
    }
    public string Name
    {
        get { return _epmName; }
    }
    public int ID
    {
        get { return _empID; }
    }
}

class GenericList<T> where T : Employee
{
    T[] _name = new T[3];
    int _counter = 0;
    public void Add(T val)
    {
        _name [_counter] = val;
        _counter++;
    }
    public void Display()
    {
        for (int i = 0; i < _counter; i++)
        {
            Console.WriteLine(_name[i].Name + " , " + _name[i].ID);
        }
    }
}
class ClassConstaintDemo
{
    static void Main(string[] args)
    {
        GenericList<Employee> objList = new GenericList<Employee>();
        objList.Add(new Employee("John", 100));
        objList.Add(new Employee("James", 200));
        objList.Add(new Employee("Patrich", 300));
        objList.Display();
    }
}

