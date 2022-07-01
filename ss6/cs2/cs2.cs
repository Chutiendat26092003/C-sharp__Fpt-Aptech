class Animal
{
    public void Eat()
    {
        Console.WriteLine("Every  animal eats something.");
    }

    public void DoSomething()
    {
        Console.WriteLine("Every  animal does something.");
    }
}

class Cat : Animal
{
    static void Main(string[] args)
    {
        Cat objDog = new Cat();
        objDog.Eat();
        objDog.DoSomething();
    }
}
