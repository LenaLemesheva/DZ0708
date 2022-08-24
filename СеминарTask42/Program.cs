/* Напишите программу, которая будет преобразовывать
 десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

int GetBinary(int num)
{
    //string result = String.Empty(); // зарезервировать строку
    string result = "";
    while(num > 0)
    {
//      result += (num % 2) * Convert.ToInt32(Math.Pow(10, count)); для конверции doble - int
        result = result + Convert.ToString(num % 2);  //Конвертировать в строку
        num /= 2;
    }
    result.ToCharArray().Reverse(); // метод для разворачивания строки наоборот
    return int.Parse(result); // Результат привести к целому числу
}

Console.Write($"{GetBinary(number)}");
Console.WriteLine();
