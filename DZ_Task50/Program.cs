/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет */

Console.Write("Ввелите количество строк = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите номер позиции строки элемента = ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите номер позиции столбца элемента = ");
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

    if (k < 0 | k > array.GetLength(0) | l < 0 | l > array.GetLength(1))
    {
        Console.WriteLine($"Позиция выходит за пределы заданного массива");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[k - 1, l - 1]);
    }
}

int[,] myArray = GetArray(m, n, 0, 9);
PrintArray(myArray);
Console.WriteLine();
