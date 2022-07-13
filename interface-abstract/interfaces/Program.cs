interface IAninal
{
    void Drink();
}
interface ICarnivorous
{
    void Eat();
}
interface IReptile : IAninal, ICarnivorous
{
    void Habitat();
} 
class Crocodile : IReptile
{
    public void Drink()
    {
        Console.WriteLine("Drinks fresh water");
    }
    public void Habitat()
    {
        Console.WriteLine("Can stay in Water and Land");
    }
    public void Eat()
    {
        Console.WriteLine("Eats Flesh");
    }

    static void Main(string[] args)
    {
        Crocodile crocodile = new Crocodile();
        Console.WriteLine(crocodile.GetType().Name);
        crocodile.Drink();
        crocodile.Eat();
        crocodile.Habitat();
    }
}