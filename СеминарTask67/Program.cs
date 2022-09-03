/* Напишите программу, которая будет принимать на вход 
число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int SumNumber(int num)
{
    return num <= 0 ? 0 : num % 10 + SumNumber(num / 10); //если сумма меньше нуля, то возвращаем ноль
}   // if (num <= 0) return 0;                            //если сумма больше нуля то вызываем рекурсию
    //else return num % 10 + SumNumber(num / 10);         //со значением с сокращением на один разряд
                                                      
Console.Write("Число = ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр: " + SumNumber(number));
