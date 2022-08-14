/* Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой находится 
эта точка.*/

Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
