class ITSystem
{
    public virtual void Print()
    {
        Console.WriteLine("The system should be handled carefully");
    }
}

class CompanySystem : ITSystem
{
    public sealed override void Print()
    {
        Console.WriteLine("The system information is confidental");
        Console.WriteLine("The information should not be overridden");
    }
} 

class SealedSystem : CompanySystem
{
    public override void Print()
    {
        Console.WriteLine("This sratement won't get executed");
    }

    static void Main(string[] args)
    {
        SealedSystem objSealed = new SealedSystem();
        objSealed.Print(); 
    }
}