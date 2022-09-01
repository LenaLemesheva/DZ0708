/* Вывести первые N строк треугольника Паскаля. Сделать вывод в виде 
равнобедренного треугольника */

Console.Write("Введите количество строк Паскаля N = ");
int n = int.Parse(Console.ReadLine());

void FillPascalTriangle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[i, j] != 0)
            {
                array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                array[i, j] = 0;
                count++;
            }
        }
    }
    array[array.GetLength(0) - 1, 0] = 1;
}

void FillTriangle(int[,] triangle)
{
    for (int k = 0; k < triangle.GetLength(0); k++)
    {
        triangle[k, 0] = 1;
    }
    for (int i = 1; i < triangle.GetLength(0); i++)
    {
        for (int j = 1; j < i + 1; j++)
        {
            triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
        }
    }
}
void PrintTriangle(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] != 0)
            {
                Console.Write($"{arr[i, j]} ");
            }

            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] pascalTriangle = new int[n + 1, 2 * n + 1];
FillPascalTriangle(pascalTriangle);

Console.WriteLine();
PrintTriangle(pascalTriangle);

FillTriangle(pascalTriangle);

Console.WriteLine();
PrintTriangle(pascalTriangle);
