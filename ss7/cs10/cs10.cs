using System;
interface ICalculate
{
    double Area();
}

class Rectangle : ICalculate
{
    float _length;
    float _breadth;
    public Rectangle(float length, float breadth)
    {
        _length = length;
        _breadth = breadth;
    }
    public double Area()
    {
        return _length * _breadth;
    }

    static void Main(string[] args)
    {
        Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
        if (objRectangle is ICalculate)
        {
            Console.WriteLine("Area of rectangle: {0:F2}", objRectangle.Area());
        } else
        {
            Console.WriteLine("Interface method not implemented");
        }
    }
}