class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal contructor without patameters");
    }
    public Animal(String name)
    {
        Console.WriteLine("Animal contructor witha string patameter");
    }
}
class Canine: Animal
{
    public Canine() : base ("Lion")
    {
        Console.WriteLine("Derived Canine");
    }
}

class Details
{
    static void Main(string[] args)
    {
        Canine objCanine = new Canine();
    }
}