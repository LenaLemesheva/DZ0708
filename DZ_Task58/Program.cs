/* Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Write("Ввелите количество строк матриц = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матриц = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона матриц = ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона матриц = ");
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

int[,] MatricesComposition(int[,] arr1, int[,] arr2)
{

    //if (arr1.GetLength(1) != arr2.GetLength(0))

    int[,] compArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {

            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                temp = temp + (arr1[i, k] * arr2[k, j]);
            }
            compArr[i, j] = temp;
            temp = 0;
        }
    }
    return compArr;
}

int[,] myArray1 = GetArray(m, n, k, l);
int[,] myArray2 = GetArray(m, n, k, l);
PrintArray(myArray1);
Console.WriteLine();
PrintArray(myArray2);
Console.WriteLine();

if (myArray1.GetLength(0) != myArray2.GetLength(1) || myArray1.GetLength(1) != myArray2.GetLength(0))
{
    Console.WriteLine($"Матрицы несовместимы");
}
else
{
    int[,] myCompArray = GetArray(m, n, k, l);
    myCompArray = MatricesComposition(myArray1, myArray2);
    PrintArray(myCompArray);
}
