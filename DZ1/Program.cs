Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write($"{numberA} - большее, {numberB} - меньшее");
}
else
{
    Console.Write($"{numberB} - большее, {numberA} - меньшее");
}

