/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя 
индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Write("Ввелите количество строк матриц = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матриц = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество слоев матриц = ");
int r = int.Parse(Console.ReadLine());

void FillMatrix(int[,,] matrix, int minValue, int maxValue)
{
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (matrix[i, j, k] == 0)
                {
                    int number = rand.Next(minValue, maxValue + 1);

                    if (NumbersMatrix(matrix, number) == false)
                    {
                        matrix[i, j, k] = number;
                    }
                }

            }
        }
    }
}

bool NumbersMatrix(int[,,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == number) return true;
            }
        }
    }
    return false;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k]);
                Console.Write("({0},{1},{2})\t", i, j, k);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] myMatrix = new int[m, n, r];
FillMatrix(myMatrix, 10, 99);
PrintMatrix(myMatrix);
