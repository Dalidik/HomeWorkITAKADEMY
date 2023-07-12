int[,] elements = { { 1, 2, 3 }, { 22, 13, 18 }, { 6, 7, 8 } };

for (int i = 0; i < elements.GetLength(0); i++)
{
    int maxNumber = elements[i, 0];

    for (int j = 0; j < elements.GetLength(1); j++)
    {
        if (elements[i, j] > maxNumber)
        {
            maxNumber = elements[i, j];
        }        
    }

    Console.WriteLine("Max element in {0} array is {1}", i, maxNumber);
}
