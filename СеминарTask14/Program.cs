/* Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно 7 и 23.
14 -> нет, 46 -> нет, 161 -> да. */

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
