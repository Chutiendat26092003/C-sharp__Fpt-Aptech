class People
{
    public string Name
    {
        get; set;
    }

    public string DBO
    {
        get; set;
    }

    public string Gender
    {
        get; set;
    }

    public void Display()
    {
        Console.WriteLine("Ho va ten: " + Name);
        Console.WriteLine("Ngay thang nam sinh: " + DBO);
        Console.WriteLine("Gioi tinh: " + Gender);
    }
}

class Student : People
{

    public float Point
    {
        get; set;
    }

    new void Display()
    {
        base.Display();
        Console.WriteLine("Diem: " + Point);
    }
}

class Staff : People
{
    public float Salary
    {
        get; set;
    }

    new void Display()
    {
        base.Display();
        Console.WriteLine("Muc Luong: " + Salary);
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Student objStudent1 = new Student();
        objStudent1.Name = "Chu Tien Dat";
        objStudent1.DBO = "26/09/2003";
        objStudent1.Gender = "nam";
        objStudent1.Point = 9;

        objStudent1.Display();


        Console.WriteLine();


        Staff objStaff1 = new Staff();
        objStaff1.Name = "Chu Tien Dat";
        objStaff1.DBO = "26/09/2003";
        objStaff1.Gender = "nam";
        objStaff1.Salary = 200000;

        objStaff1.Display();
    }
}
