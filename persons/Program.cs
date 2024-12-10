namespace persons;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person person = new();
        person.AskUserNames();
        person.Print();

    }
}

class Person
{
    readonly List<string> persons = [];

    public List<string> AskUserNames()
    {
        for (int i = 1; i < 4; i++)
        {
            Console.Write($"Enter username {i}:");
            string? username = Console.ReadLine();
            if (username != null)
            {
                persons.Add(username);
            }

        }
        return persons;
    }

    public void Print()
    {
        foreach (string person in persons)
        {
            Console.WriteLine(person);
        }
    }

}






