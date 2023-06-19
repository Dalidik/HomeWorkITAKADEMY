 abstract class Person
{
 public string Name;
 public string Surname;
 public int YearOfBirth;

public Person(string name, string surname, int yearOfBirth)
{
    Name = name;
    YearOfBirth = yearOfBirth;
    Surname = surname;
}

public virtual string Info()
{
    var years = DateTime.Now.Year - YearOfBirth;
 return $"{Name} {Surname} was {years} years old";
}
public abstract void SolveProblem();


}