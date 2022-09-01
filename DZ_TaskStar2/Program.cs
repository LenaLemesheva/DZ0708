/* Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994 */ 

Console.Write("Введите арабское число = ");
string N = "A" + Convert.ToString(Console.ReadLine());

int[] Roman = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
string[] Arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

int ChangeNum(string s)
{
    int[] rom = new int[100]; int i; int res;
    for (i = 0; i < s.Length; i++)
    {
        if (s[i] == 'I') rom[i] = 1;
        if (s[i] == 'V') 
        {
            if(s[i-1] == 'I')
            { 
                rom[i] = 3;
            }
            else rom[i] = 5;
        }
        if (s[i] == 'X')
        {
            if(s[i-1] == 'I')
            { 
                rom[i] = 8;
            }
            else rom[i] = 10;
        }
        if (s[i] == 'L')
        {
            if(s[i-1] == 'X')
            { 
                rom[i] = 30;
            }
            else rom[i] = 50;
        }
        if (s[i] == 'C')
        {
            if(s[i-1] == 'X')
            { 
                rom[i] = 80;
            }
            else rom[i] = 100;
        }
        if (s[i] == 'D')
        {
            if(s[i-1] == 'C')
            { 
                rom[i] = 300;
            }
            else rom[i] = 500;
        }
        if (s[i] == 'M')
        {
            if(s[i-1] == 'C')
            { 
                rom[i] = 800;
            }
            else rom[i] = 1000;
        }
    }

    res = rom[0];
    {
        for (i = 1; i < rom.Length; i++)
        {
            res += rom[i];
        }
        return res;
    }
}

Console.Write("Вы получили римское число = ");
Console.Write(ChangeNum(N));
Console.WriteLine();
