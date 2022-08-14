/* Напишите программу, которая принимает на вход число (N) и
выдает таблицу квадратов числе от 1 до N.
Например: 5 -> 1, 4, 9, 16, 25.
2 -> 1, 4.*/

Console.Write("Введите число N = ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 2) + ", ");
}
