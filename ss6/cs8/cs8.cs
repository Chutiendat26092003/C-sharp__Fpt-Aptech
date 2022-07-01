class Animla
{
    public virtual void Eat()
    {
        Console.WriteLine("Wvery animal eats something");
    }

    protected void DoSomething()
    {
        Console.WriteLine("Wvery animal does something");
    }
}

class Cat : Animla
{
    public override void Eat()
    {
        Console.WriteLine("Cat loves to eat the mouse");
    }
    static void Main(string[] args)
    {
        Cat objCat = new Cat();
        objCat.Eat();
    }
}