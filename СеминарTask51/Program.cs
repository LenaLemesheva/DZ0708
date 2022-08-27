/* Задайте двумерный массив. Найдите сумму элементов, находящихся
на главной диагонали (с индексами (0,0); (1;1) и т.д. */

Console.Write("Колличество строк = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Колличество столбцов = ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int SumDiagonalArray(int[,] array)
{
    int diagSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                diagSum += array[i, j];
            }
        }

    }
    return diagSum;
}

int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
Console.WriteLine();

int resultSum = SumDiagonalArray(myArray);
Console.WriteLine($"Сумма главной диагонали = {resultSum}");
