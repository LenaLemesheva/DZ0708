/* Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа.
456 -> 46, 782 -> 72, 918 -> 98.
*/

int number = new Random().Next(100, 1000);
int num1 = number % 10;
int num3 = number / 100;
int result = num3 * 10 + num1;

Console.WriteLine ($"Из числа {number} получилось число {result}");

