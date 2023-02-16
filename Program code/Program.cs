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
