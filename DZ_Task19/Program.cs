/* Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.
Например: 14212 -> нет, 23432 -> да, 12821 -> да.*/

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99999)
{
    Console.WriteLine($"Вы ввели НЕ пятизначное число");
    return;
}

int num1 = number / 10000;
int num2 = number % 10;
int num3 = number / 1000;
int num4 = num3 % 10;
int num5 = number % 100;
int num6 = num5 / 10;

if (num1 == num2 && num4 == num4)

{
Console.WriteLine ($"Да, {number} - палиндром");
}

else
{
Console.WriteLine ($"Нет, {number} - не палиндром");
}
