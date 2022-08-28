/* Задайте двумерный массив размером m×n, заполненный случайными
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

double[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:F1} ");
        Console.WriteLine();
    }
}

double[,] myArray = GetArray(m, n, -10, 9);
PrintArray(myArray);

