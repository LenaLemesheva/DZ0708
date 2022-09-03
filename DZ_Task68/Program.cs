/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

Console.Write("Введите m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n = ");
int n = int.Parse(Console.ReadLine());

int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunction(m - 1, 1);
  else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

int funcAkkerman = AckermanFunction(m, n);
Console.Write($"Функция Аккермана = ");
Console.WriteLine(funcAkkerman);
