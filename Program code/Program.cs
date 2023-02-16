string[] NewStringsArrayCreation()
{
    int i = 0;

    Console.Write("Введите размер массива строк: ");
    int elementsCount = int.Parse(Console.ReadLine()!);
    
    if (elementsCount < 1)
    {
        Console.WriteLine("Введите целое положительное число");
    }
        
    string[] array = new string[elementsCount];

    while (i < array.Length)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine()!;
        if (array[i] != "")
        {
            i++;
        }    
    }
    
    return array;
}

void PrintArray(string[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
} 

string[] ArrayOfStringsNoLongerThan3Symbols(string[] array)
{
    string stringOfElements = string.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            stringOfElements = string.Concat(stringOfElements, " " + array[i]);
            Console.WriteLine(stringOfElements);
        }
    }
    
    string[] result = stringOfElements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return result;
}

string[] strings = NewStringsArrayCreation();

PrintArray(strings);
Console.WriteLine();

string[] result = ArrayOfStringsNoLongerThan3Symbols(strings);

PrintArray(result);
