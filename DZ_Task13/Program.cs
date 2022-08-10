/* Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 6, 78 -> третьей цифры нет, 32679 -> 6. */

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
int num1 = number % 1000;
int num2 = num1 / 100;
int result = num2;

Console.WriteLine ($"Из числа {number} получилось число {result}");
}
