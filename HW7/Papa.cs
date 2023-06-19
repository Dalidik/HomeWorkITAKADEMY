class Papa : Family
{
    public const string Voice = "Oink!";
public int Age;
public Papa( string name, string surname, string color, int age)
: base(name, surname, color)
{
Age = age;
}

    public override void PrintSmth()
    {
        Console.WriteLine(Voice);
    }
    public override string Info()
    {
        return $"{Name} {Surname} is - {Color} and {Age} years old";
    }

}