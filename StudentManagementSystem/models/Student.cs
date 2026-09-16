public class Student : Person
{
    private string? major;
    public string? Major
    {
        get{return major;}
        set{major = value;}
    }

    private double gpa;
    public double GPA
    {
        get{return gpa;}
        set{gpa = value;}
    }


    public Student(int coId, string coName, int coAge, string coMajor, double coGPA) 
    : base(coId, coName, coAge) // "co" is shortcut for constructor
    {
        this.Major = coMajor;
        this.GPA = coGPA;

    }
}
