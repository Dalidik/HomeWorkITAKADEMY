class Transport
{
    public string Name { get; set; }
    public int SpeedInHour { get; set; }

    public Transport(string name, int speedInHour)
    {
        Name = name;
        SpeedInHour = speedInHour;
    }
    public void Moving()
    {
        Console.WriteLine($"This transport goes very fast");
    }
}
