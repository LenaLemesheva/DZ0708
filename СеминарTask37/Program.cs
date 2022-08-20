/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(1,100);
    }
    return res;

}   

int [] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i]; //5-1 = 4-i (c последнего эл-та к первому)
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}

int[] array = GetArray(5);
int[] groupArr = ResultArray(array);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", groupArr));
