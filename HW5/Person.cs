class Person : Transport
{
    private Transport transport;
    public Transport TransportMetod
    {
        get { return transport; }
        set { transport = value; }
    }



    public Person(string name, int speedInHour, Transport personTransport)
       : base(name, speedInHour)
    { 
        this.transport = personTransport;
    }

    public void PersonMoving(Transport usedTransport)
    {
        Console.WriteLine($"This person is moving by {usedTransport.Name}");
    }
    public void TransportChangeProperty()
    {
Console.WriteLine($"This person is moving by {transport.Name}");
    }
}