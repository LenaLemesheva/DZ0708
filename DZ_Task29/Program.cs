/* Напишите программу, которая задает массив из N элементов, 
заполненых случайными числами из [a, b) и выводит их на экран.
Например: 5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33] */

Console.Write("Ведите колличество элементов массива: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Ведите начало диапазона случайных чисел: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ведите конец диапазона случайных чисел: ");
int b = int.Parse(Console.ReadLine());

void RandArray()
{
    int[] arr = new int[N];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }

    Console.WriteLine($"[{String.Join(",", arr)}]");
}

RandArray();
