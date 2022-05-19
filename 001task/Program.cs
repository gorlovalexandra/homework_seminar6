/* Задача 1. Составить частотный словарь элементов двумерного массива.

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
        //i++;
        j++;
        Console.WriteLine("meets " + sum);
    }
}

int[,] array = new int[2, 5];

FillArray(array);
PrintArray(array);
FrequencyDictionary(array);
Console.WriteLine();

//int[,] arr = FrequencyDictionary(array);
//Console.WriteLine(arr); */

/* Задача 2. Найти произведение двух матриц.

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

int[,] Multiplication(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[0, 0];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                result[i, j] = arr1[i, k] * arr2[k, j];
            }
        }
    }
    return result;
}

int[,] arr1 = new int[3, 3];
int[,] arr2 = new int[3, 3];

FillArray(arr1);
PrintArray(arr1);
Console.WriteLine();
FillArray(arr2);
PrintArray(arr2);
Console.WriteLine();

int[,] result = Multiplication(arr1, arr2);
Console.WriteLine(result); */

/* Задача 3. Показать треугольник Паскаля:
- Сделать вывод в виде равнобедренного треугольника;
- Показать только нечетные числа в треугольнике;

int row = 9;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] =
            triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] % 2 != 0)
            Console.Write($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2;
        }

        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

FillTriangle();
PrintTriangle();
Magic(); */