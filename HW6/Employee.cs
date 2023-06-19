class Employee : Person
{

public const string Solve = "The surgeon is engaged in various types of operations and assists with them.";
public string MiddleName;
public string Country;
public string Post;
public Employee (string name, string surname, string middleName,
 string country, int yearOfBirth, string post)
: base(name, surname, yearOfBirth)
{
    MiddleName = middleName;
    Country = country;
    Post = post;


}
public override string Info()
{
    var years = DateTime.Now.Year - YearOfBirth;
 return $"{Name} {Surname} {MiddleName} live in {Country}. He is {years} years old and holds the position of {Post}";
}


public override void SolveProblem()
{

Console.WriteLine(Solve);
}

}