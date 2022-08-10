/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да, 7 -> да, 1 -> нет. */

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine("Вы ввели неверное число");
    return;
}
if (number >= 6)
{
    Console.WriteLine("да");
}
else
{
Console.WriteLine ("нет");
}
