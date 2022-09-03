﻿/* Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

/*void PrintN(int count, int N)
{
    if (count > N) return;
    PrintN(count, N - 1);
    Console.Write(N + ", ");
}*/

string PrintNumToString(int step, int N)
{
    if (step == N) return step.ToString();  //делает строку
    return step + ", " + PrintNumToString(step + 1, N);
}

Console.Write("N = ");
int number = int.Parse(Console.ReadLine());
//PrintN(1, number);
Console.WriteLine(PrintNumToString(1, number));

