/* Написать функцию Sqrt(x) - квадратного корня, которая принимает 
на вход целочисленное значение x и возвращает целую часть квадратного 
корня от введенного числа.
Например:
4 -> 2
28 -> 5
Нельзя использовать встроенные функции библиотеки Math! */

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int isqrt(int x)
{
    int m, y, b;
    m = 0x40000000;
    y = 0;
    while (m != 0)
    {
        b = y | m;
        y >>= 1;
        if (x >= b)
        {
            x -= b;
            y |= m;
        }
        m >>= 2;
    }
    return y;
}

Console.Write("Вы получили число = ");
Console.Write(isqrt(n));
Console.WriteLine();