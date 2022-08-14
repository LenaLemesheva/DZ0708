/* Напишите программу, которая принимает на вход координаты двух
точек и находит расстояние между ними в 2D пространстве.
Например: А(3,6), В(2,1) -> 5,09
А(7,-5), В(1,-1) -> 7,21 */

Console.Write("Введите координаты х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты х2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance:f2}");
