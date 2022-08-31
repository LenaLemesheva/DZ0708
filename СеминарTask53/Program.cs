/* Задайте двумерный массив. Напишите программу, которая поменяет
местами первую и последнюю строку массива. */

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

void ChangeMatrixRows(int[,] matrix)
{
    int temp;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1, i];
        matrix[matrix.GetLength(0)-1, i] = temp;      
    }
}
void PrintArr(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MyMatrix = GetArray(m, n, k, l);
PrintArray(MyMatrix);
Console.WriteLine();

ChangeMatrixRows(MyMatrix);
PrintArr(MyMatrix);
