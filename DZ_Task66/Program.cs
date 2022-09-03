/* Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine());

int SumNaturalElements(int start, int end)
{
    if (start == end) return end;
    return start + SumNaturalElements(start + 1, end);
}

Console.Write("Сумма = ");
Console.WriteLine(SumNaturalElements(M, N));
