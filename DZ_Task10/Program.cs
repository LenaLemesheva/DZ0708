/* Напишите программу, которая принимает на вход трехзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5, 782 -> 8, 918 -> 1. */

int number = new Random().Next(100, 1000);
int num1 = number % 100;
int num2 = num1 / 10;

int result = num2;

Console.WriteLine ($"Из числа {number} получилось число {result}");
