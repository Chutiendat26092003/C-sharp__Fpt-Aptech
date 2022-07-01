interface ITerrestriaAnimal
{
    void Eat();
}

interface IMarineAnimal
{
    void Swim();
}

class Crocodile : ITerrestriaAnimal, IMarineAnimal
{
    public void Eat()
    {
        Console.WriteLine("THe Crocodile eats flesh");
    }

    public void Swim()
    {
        Console.WriteLine("THe Crocodile can swim four times faster than an Olympic swimmer");
    }

    static void Main(string[] args)
    {
        Crocodile crocodile = new Crocodile();
        crocodile.Eat();
        crocodile.Swim();
    }
}
