/* Разобраться с алгоритмом сортировки методом пузырька. 
Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1] */

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

int[] sort(int[] mas)
{
    int M;
    for (int i = 0; i < mas.Length; i ++)
    {
        for(int j = 0; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                M = mas[i];
                mas[i] = mas[j];
                mas[j] = M;
            }
        }
    }
    return mas;
}

int[] array = GetArray(N, a, b + 1);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine(String.Join(" ",sort(array)));
Console.WriteLine();
