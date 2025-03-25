namespace ConsoleApp1;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        
    }
    public virtual void OverLoad()
    {
        Console.WriteLine("Hello World");
    }
}

public class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int age, int grade) : base(name, age)
    {
        grade = Grade;
    }
    public override void OverLoad()
    {
        Console.WriteLine(Grade);
        
    }
}