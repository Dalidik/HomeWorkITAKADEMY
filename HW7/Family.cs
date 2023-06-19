abstract class Family

{

public string Name;

public string Surname;
public string Color;
public Family (string name, string surname, string color)
{
    Name = name;
    Surname = surname;
    Color = color;
}
 public abstract void PrintSmth();

public virtual string Info()
{
return $"Name - {Name}, Surname - {Surname}, Color - {Color}";
}
}