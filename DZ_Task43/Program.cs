/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 начения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2 = ");
double k2 = double.Parse(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine($"Прямые параллельны, не пересекаются");
    return;
}

double GetPointX(double a1, double c1, double a2, double c2)
{
    double x;
    x = (a2 - a1) / (c1 - c2);
    return x;
}

double GetPointY(double a1, double c1, double a2, double c2)
{
    double y;
    y = (c1 * ((a2 - a1) / (c1 - c2)) + a1);
    return y;
}

Console.Write($"Точка пересечения прямых ({GetPointX(b1, k1, b2, k2)}, {GetPointY(b1, k1, b2, k2)})");
