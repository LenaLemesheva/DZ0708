/* Напишите цикл, который принимает на вход два числа (А и В) и
возводит число А в натуральную степень В.
Например: 3, 5 -> 243; 2, 4 -> 16 */

Console.Write("Ведите число A: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Ведите число B: ");
int number2 = int.Parse(Console.ReadLine());

    if (number2 == 0)
    {
        Console.WriteLine($"1");
        return;
    }
int Exponentiation(int A)
{
        int exp = number1;

    for (int i = 2; i <= number2; i++)
    {
        exp = exp * number1;
    }
    return exp;
}

Console.Write(Exponentiation(number2));
Console.WriteLine();
