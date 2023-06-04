


Console.WriteLine("please input W, A, S, D to move the object");

var input = Console.ReadLine();

switch (input)
{
    case "w":
    Console.WriteLine("The object has been moved up!");
        break;

    case "a":
    Console.WriteLine("The object has been moved to the left!");
        break;

    case "s":
    Console.WriteLine("The object has been moved down!");
        break;

    case "d":
    Console.WriteLine("The object has been moved right!");
        break;

    default:
        Console.WriteLine("The object is not moving...");
        break;
}

