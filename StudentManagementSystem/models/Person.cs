public class Person
{
    private int id;
    public int Id
    {
        get{return id;}
        set{id = value;}
    }

    private string? name;
    public string? Name
    {
        get{return name;}
        set{name = value;}
    }

    private int age;
    public int Age
    {
        get{return age;}
        set{age = value;}
    }


    public Person(int coId, string coName, int coAge) // "co" is shortcut for constructor
    {
    this.Id = coId;
    this.Name = coName;
    this.Age = coAge;
    }
}

