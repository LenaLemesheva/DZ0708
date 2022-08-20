/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
Например: [3 7 22 2 78] -> 76 */

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Ведите начало диапазона случайных чисел: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ведите конец диапазона случайных чисел: ");
int b = int.Parse(Console.ReadLine());

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return res;
}

double maxElem(double[] mas)
{
    double max = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > max) max = mas[i];
    }
    return max;
}

double minElem(double[] mas)
{
    double min = mas[0];
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < min) min = mas[i];
    }
    return min;
}

double[] array = GetArray(N, a, b + 1);
Console.WriteLine(String.Join(" ", array));


Console.Write($"max {maxElem(array)} - min {minElem(array)}, = {maxElem(array)-minElem(array)}");
Console.WriteLine();

