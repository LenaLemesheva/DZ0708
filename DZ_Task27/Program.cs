/* Напишите функцию и запустите ее, которая принимает на вход
число и выдает сумму цифр в числе.
Например: 452 -> 11; 82 -> 10; 9012 -> 12 */

Console.Write("Ведите число N: ");
int num = int.Parse(Console.ReadLine());

int SumDigits(int N)
{
    int a = 0;
    int sum = 0;

    while (num > 0)
    {
        a = num % 10;
        num = num / 10;
        sum = sum + a;
    }
    return sum;
}

Console.Write(SumDigits(num));
Console.WriteLine();
