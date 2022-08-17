/* Напишите программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А.
Например: 7 -> 28, 4 -> 10, 8 -> 36. */

Console.Write("Ведите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNums(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine(GetSumNums(num));
