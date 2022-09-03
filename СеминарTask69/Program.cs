/* Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Int64 PowRes(int a, int n)
{
    //return n == 0 ? 1 : a * PowRes(a, n - 1);  // ? - если, : - иначе
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowRes(a * a, n / 2);
    else return a * PowRes(a, n - 1);
}

Console.Write("Введите основание степени, А (не равное нулю): ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите показатель степени, В: ");
int B = int.Parse(Console.ReadLine());

if (A == 0 || B < 0)  // степень 0 оставляю
{
    Console.WriteLine("Введенные значения не соответствуют условию");
}
else
    Console.WriteLine(PowRes(A, B));
