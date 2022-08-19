/* Напишите функцию, которая принимает одно число - высоту
елочки и рисует ее в консоли звездочками. */

Console.Write("Введите высоту елочки: ");
int N = int.Parse(Console.ReadLine());

void Tree(int N)
{
    for (int i = N; i > -1; i--)
    {
        for (int j = N - i; j < N; j++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j < N - i; j++)
        {
            Console.Write("*");
        }
        for (int j = 0; j < N - i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
Tree(N);
