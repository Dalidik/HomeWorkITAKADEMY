
var names = new List<string>(){ "Bella", "Kaleb", "Jakob"};

names.Add("Charli");

names.Sort();
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
    Console.WriteLine();
    names.Add("Renesme");

     foreach (var name in names)
     {
        Console.WriteLine($"Hello {name.ToUpper()}!");
     }
     Console.WriteLine();