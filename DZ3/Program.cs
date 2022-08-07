Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write($"{number} - да, четное");
}
else
{
    Console.Write($"{number} - нет, нечетное");
}
