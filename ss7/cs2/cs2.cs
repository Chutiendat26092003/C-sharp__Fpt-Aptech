abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every animal eats food in order to survive");
    }
    public abstract void AnimalSound();
}
class Lion: Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Lion roars");
    }
    static void Main(string[] args)
    {
        Lion lion = new Lion();
        lion.AnimalSound();
        lion.Eat();
    }
}