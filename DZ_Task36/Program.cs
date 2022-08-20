/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Например: [3, 7, 23, 12] -> 19;
[-4, -6, 89, 6] -> 0 */

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Ведите начало диапазона случайных чисел: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ведите конец диапазона случайных чисел: ");
int b = int.Parse(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int sumElem(int[] mas)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < mas.Length; i += 2)
    {
        sum = sum + mas[i];
        count++;
    }
    return sum;
}

int[] array = GetArray(N, a, b + 1);
Console.WriteLine(String.Join(" ", array));

Console.Write($"Сумма элементов, стоящих на нечётных позициях = {sumElem(array)}");
Console.WriteLine();