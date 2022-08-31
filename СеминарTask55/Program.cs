/* Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

Console.Write("Ввелите количество строк = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Ввелите начало диапазона = ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона = ");
int l = int.Parse(Console.ReadLine());

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

int[,] ReplaceRowsColumns(int[,] array)
{
    int[,] tmp = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp[i, j] = array[j, i];
        }
    }
    return tmp;
}

int[,] myArray = GetArray(m, n, k, l);
PrintArray(myArray);
Console.WriteLine();

if (myArray.GetLength(0) == myArray.GetLength(1))
{
    PrintArray(ReplaceRowsColumns(myArray));
}
else
{
    Console.Write("Количество столбцов не совпадает с количеством строк!");
    Console.WriteLine();
}
