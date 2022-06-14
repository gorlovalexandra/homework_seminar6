/* Задача 1. Составить частотный словарь элементов двумерного массива. */

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FrequencyDictionary(int[,] array)
{
    Dictionary<int, int> countArr = new Dictionary<int, int>();

    foreach (int element in array)
    {
        if (countArr.ContainsKey(element))
            countArr[element]++;
        else
            countArr.Add(element, 1);
    }

    foreach (var element in countArr)
    {
        Console.WriteLine($"element {element.Key} occurs {element.Value} times");
    }
}

int[,] array = new int[2, 5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(array);
Console.WriteLine();
