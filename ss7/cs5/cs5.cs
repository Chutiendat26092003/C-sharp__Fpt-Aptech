interface IAnimal
{
    void Habitat();
}

class Dog : IAnimal
{
    public void Habitat()
    {
        Console.WriteLine("Can be housed with human beings");
    }
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Console.WriteLine(dog.GetType().Name);
        dog.Habitat();
    }
} 

