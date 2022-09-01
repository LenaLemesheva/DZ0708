/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

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

int LineMinimumAmount(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += arr[i, j];
                minSum += arr[i, j]; 
            }
            else sum += arr[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i + 1;
        }
        sum = 0;
    }
    return minNum;
}

int[,] myArray = GetArray(m, n, k, l);
PrintArray(myArray);
Console.WriteLine();

Console.WriteLine("Cтрока с наименьшей суммой элементов: " + LineMinimumAmount(myArray));
