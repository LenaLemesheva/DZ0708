/* Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен 
наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */

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

int[] FindIndexOfMinArray(int[,] arr) // находит индекс минимального значения
{
    int[] IndexOfMinArr = new int[2]; // создали массив
    int RowMin = 0;
    int ColMin = 0;
    int minArr = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minArr) // нашли минимум
            {
                minArr = arr[i, j];
                RowMin = i;
                ColMin = j;
            }
        }
        IndexOfMinArr[0] = RowMin;
        IndexOfMinArr[1] = ColMin;
    }
    return IndexOfMinArr;
}

int[,] CorrectArrayToMinimum(int[,] arr) // удаляем лишние строку и стобец (от минимума)
{
    int[,] CorrectArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int correctI = 0;
    int correctJ = 0;
    for (int i = 0; i < CorrectArr.GetLength(0); i++)
    {
        if (i >= FindIndexOfMinArray(arr)[0]) correctI = i + 1;
        else correctI = i;
        for (int j = 0; j < CorrectArr.GetLength(1); j++)
        {
           if (j >= FindIndexOfMinArray(arr)[1]) correctJ = j + 1;
           else correctJ = j;
           CorrectArr[i, j] = arr[correctI, correctJ];
        }
    }
    return CorrectArr;
}

int[,] myArray = GetArray(m, n, k, l);
PrintArray(myArray);
Console.WriteLine();

Console.WriteLine($"Наименьший элемент массива расположен на пересечении {String.Join(", ", FindIndexOfMinArray(myArray))}");
myArray = CorrectArrayToMinimum(myArray);
Console.WriteLine();
PrintArray(myArray);
