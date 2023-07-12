using System.Collections;
using System.Collections.Generic;
ArrayList list = new ArrayList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);

foreach (object o in list)
{
 Console.WriteLine(o);
}

Console.WriteLine();

list.RemoveAt(3);

foreach (object o in list)
{
 Console.WriteLine(o);
}

Console.WriteLine();

list.RemoveAt(0);

foreach (object o in list)
{
 Console.WriteLine(o);
}

Console.WriteLine(); 

Console.WriteLine($"We have {list[0]} and {list[1]}");


Console.WriteLine();


List<string> colors = new List<string>() { "Black", "White"};
colors.Add("Pink");
colors.Add("Gray");

foreach (var color in colors)
{
    Console.WriteLine(color);

}
Console.WriteLine();

colors.RemoveAt(3);

foreach (var color in colors)
{
    Console.WriteLine(color);

}
Console.WriteLine();

colors.RemoveAt(0);

foreach (var color in colors)
{
    Console.WriteLine(color);

}
Console.WriteLine();

 Console.WriteLine($"We have {colors[0]} and {colors[1]}");

