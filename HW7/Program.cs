int[] numbers = new int[6];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Enter numbers[{0}]", i);
    numbers[i] = int.Parse(Console.ReadLine());
}

Array.Sort(numbers);
Array.Reverse(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");    
}

Console.ReadLine();