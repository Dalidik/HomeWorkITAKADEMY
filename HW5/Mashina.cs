class Mashina : Transport
{
    public Mashina(string name, int speedInHour)
        : base(name, speedInHour) { }

    public new void Moving()
    {
        Console.WriteLine("This car is moving on the ground");
    }

}