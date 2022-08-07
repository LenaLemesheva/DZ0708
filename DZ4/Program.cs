Console.Write("N = ");
int number = int.Parse(Console.ReadLine());
int count = 2;
if (number == 1)
{
    Console.Write("нет таких чисел");
}
else
{
    Console.Write($"{number}: ");
    while (count <= number)
    {
        Console.Write($"{count},");
        count = count + 2;
    }
}
