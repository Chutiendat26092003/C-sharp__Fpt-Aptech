class ImplicitilyTypedLocal
{
    static void Main(string[] args)
    {
        var i = 5;
        var s = "hello";
        var d = 1.0;
        Console.WriteLine("i*1: " +i * 1);

        Console.WriteLine("s in upper case: " + s.ToUpper());

        Console.WriteLine("type of d:" + d.GetType());
        Console.ReadLine();
    }
}