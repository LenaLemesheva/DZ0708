/* Напишите программу, которая принимает на вход число N и
выдает произведение чисел от 1 до N.
Например: 4 -> 24, 5 -> 120. */

Console.Write("Ведите число N: ");
int num = int.Parse(Console.ReadLine());

int MultiDigital(int N)
{
    int a = 1;

    for (int i = 2; i <= N; i++)
    // что-бы не умножать 1 на 1
    {
        a *= i;
        //      a = a * i;
    }
    return a;
}

Console.Write(MultiDigital(num));
