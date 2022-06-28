using System;

static void Main(string[] args)
{
    List<Author> authorList = new List<Author>();
    int id;
    string name, address, state;

    while (authorList.Count <= 3)
    {
        Console.Write("Enter the ID of author: "); id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the name of author: "); name = Console.ReadLine();
        Console.Write("Enter the address: "); address = Console.ReadLine();
        Console.Write("Enter the name of state: "); state = Console.ReadLine();
        authorList.Add(new Author(id, name, address, state));
    }

    Console.WriteLine();
    foreach (Author author in authorList)
    {
        Console.WriteLine(author);
    }

    //static void display()
    //{
    //    Console.Write(""); 
    //}
}

class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string State { get; set; }
        
    public Author(int id, string name, string address, string state)
    {
        this.Id = id;
        this.Name = name;
        this.Address = address;
        this.State = state;
    }
}


