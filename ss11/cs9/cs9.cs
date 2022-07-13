using System;
using System.Collections;
using System.Collections.Generic;

class GenericList<T>
{
    protected T ItemOne;
    public GenericList(T itemOne)
    {
        ItemOne = itemOne;
    }

    public virtual T GetValue()
    {
        return ItemOne;
    }
}

class Student<T> : GenericList<T>
{
    public T Value;
    public Student(T valOne, T valTwo): base(valOne)
    {
        Value = valTwo;
    }
    public override T GetValue()
    {
        Console.WriteLine(base.GetValue() + "\t\t");
        return Value;
    }
}

class StudentList
{
    public static void Main()
    {
        Student<string> objStudent = new Student<string>("Patrick", "Male");
        Console.WriteLine("Name\t\tSex");
        Console.WriteLine(objStudent.GetValue());
    }
}
