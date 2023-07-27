class Lodka : Transport
{
    public Lodka(string name, int speedInHour)
        : base (name, speedInHour) { }

  public new void Moving()
    {
        Console.WriteLine("This lodka is moving on the water");
    }

}