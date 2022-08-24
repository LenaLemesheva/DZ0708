/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] GetArr(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

Console.Write("Введите количество чисел: М = ");
int num = int.Parse(Console.ReadLine());
int[] array = GetArr(num);

int sumElem(int[] mas)
{
    int sum = 0;

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0) sum++;
    }
    return sum;
}

Console.Write($"Чисел больше нуля = {sumElem(array)}");
Console.WriteLine();
