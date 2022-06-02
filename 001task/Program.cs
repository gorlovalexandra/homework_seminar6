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
    foreach (int element in array)
    {
        int i = 0;
        int j = 0;
        int sum = 0;
        while (array[i, j] < array.GetLength(0) && array[i, j] < array.GetLength(1))
        {
            if (array[i, j] == element)
                sum = sum + 1;
        }
        i++;
        j++;
        Console.WriteLine("occurs " + sum + " time");
    }
}

int[,] array = new int[2, 5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(array);
Console.WriteLine();
