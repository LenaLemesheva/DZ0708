/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты. */

Console.Write("строки = ");
int m = int.Parse(Console.ReadLine());
Console.Write("столбцы = ");
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

int[,] CorrectArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }

    }
    return array;
}

int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
Console.WriteLine();

myArray = CorrectArray(myArray);
PrintArray(myArray);
