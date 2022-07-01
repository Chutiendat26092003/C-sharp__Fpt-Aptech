interface IAnimal
{
    void Drink();
}

interface ICarnvorous
{
    void Eat();
}

interface IReptile : IAnimal, ICarnvorous
{
    void Habitat();
}

class Crocedile : IReptile
{
    public void Drink()
    {
        Console.WriteLine("Drinks fresh water");
    }

    public void Eat()
    {
        Console.WriteLine("Eats Fresh");
    }

    public void Habitat()
    {
        Console.WriteLine("Can stay in  Water and Land");
    }

    static void Main(string[] args)
    {
        Crocedile crocedile = new Crocedile();
        Console.WriteLine(crocedile.GetType().Name);
        crocedile.Drink();
        crocedile.Eat();
        crocedile.Habitat();    
    }

}