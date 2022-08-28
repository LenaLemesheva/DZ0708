/* Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Write("Ввелите количество строк = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
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

double ArithmeticMeanArray(int[,] array, int j)
{
    double average = 0;
    int i;

    for (i = 0; i < array.GetLength(0); i++)
    {
        average += array[i, j];
    }

    average = average / i;

    return average;
}

int[,] myArray = GetArray(m, n, 0, 9);
PrintArray(myArray);
Console.WriteLine();

for (int j = 0; j < myArray.GetLength(1); j++)
{
    Console.Write($"    {ArithmeticMeanArray(myArray, j):F1}");
}
Console.WriteLine();
