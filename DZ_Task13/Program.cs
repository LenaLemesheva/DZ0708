/* Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5, 78 -> третьей цифры нет, 32679 -> 6. */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
while (number >= 999)
{
    number = number / 10;
}
if (number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    int num1 = number % 100;
    int num2 = num1 % 10;
    int result = num2;

    Console.WriteLine($"{result}");
}
