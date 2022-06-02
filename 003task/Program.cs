/* Задача 3. Показать треугольник Паскаля:
- Сделать вывод в виде равнобедренного треугольника;
- Показать только нечетные числа в треугольнике; */

int row = 16;
int[,] triangle = new int[row, row];
const int width = 3;

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

void OddIsoscelesTriangle()
{
    int col = width * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] % 2 != 0)
            Console.Write($"{triangle[i, j],width}");
            col += width * 2;
        }

        col = width * row - width * (i + 1);
        Console.WriteLine();
    }
}

FillTriangle();
OddIsoscelesTriangle();
