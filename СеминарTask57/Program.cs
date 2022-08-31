/* Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается 
элемент входных данных. */


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

int[] GetRowArray(int[,] array) // из двумерного в одномерный
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[index] = array[i, j];
            index++;
        }
    }
    return newArray;
}

void SortArray(int[] inArray) // сортировка пузырьком
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if(inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void FreqArray(int[] array) // отсортированный пузырьком пересчитывает числа
{
    int count = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{array[i]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"{array[array.Length - 1]} встречается {count} раз");
}

int[,] myArray = GetArray(m, n, k, l);
PrintArray(myArray);
Console.WriteLine();

int[] arr = GetRowArray(myArray);
SortArray(arr);
FreqArray(arr);
