/* Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994 */

Console.Write("Введите римское число = ");
int n = Convert.ToInt32(Console.ReadLine());

string ChangeNumber(int N)
{
    int[] Roman = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] Arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    int i = 0;
    string s = "";
    while (n > 0)
    {
        if (Roman[i] <= n)
        {
            n = n - Roman[i];
            s = s + Arab[i];
        }
        else i++;
    }
    return s;
}

Console.Write("Вы получили арабское число = ");
Console.Write(ChangeNumber(n));
Console.WriteLine();

/* Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994 */

Console.Write("Введите арабское число = ");
string N = Convert.ToString(Console.ReadLine());

int[] Roman = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
string[] Arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

int ChangeNum(string s)
{
    int[] rom = new int[100]; int i; int res;
    for (i = 0; i < s.Length; i++)
    {
        if (s[i] == 'I') rom[i] = 1;
        if (s[i] == 'V') rom[i] = 5;
        if (s[i] == 'X') rom[i] = 10;
        if (s[i] == 'L') rom[i] = 50;
        if (s[i] == 'C') rom[i] = 100;
        if (s[i] == 'D') rom[i] = 500;
        if (s[i] == 'M') rom[i] = 1000;
    }
    res = rom[0];
    {
        for (i = 1; i < s.Length; i++)
        {
            res += rom[i];
        }
        return res;
    }
}

Console.Write("Вы получили римское число = ");
Console.Write(ChangeNum(N));
Console.WriteLine();
