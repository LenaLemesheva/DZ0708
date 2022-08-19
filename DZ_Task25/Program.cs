/* Напишите цикл, который принимает на вход два числа (А и В) и
возводит число А в натуральную степень В.
Например: 3, 5 -> 243; 2, 4 -> 16 */

Console.Write("Ведите число A: ");
int numer1 = int.Parse(Console.ReadLine());
Console.Write("Ведите число B: ");
int numer2 = int.Parse(Console.ReadLine());


int Exponentiation(int A)
{
    int exp = numer1;

    for (int i = 2; i <= numer2; i++)
    {
        exp = exp * numer1;
    }
    return exp;
}

Console.Write(Exponentiation(numer2));
Console.WriteLine();
