/* Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994 */

/* Console.Write("Введите арабское число = ");
string N = Convert.ToString(Console.ReadLine());

int[] Roman = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
string[] Arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

int ChangeNum(string s)
{
   int[] rom = new int[100]; int n; int res;
    res = 0;
    int i = 0;

    if (i < s.Length + 1)
    {
        switch (s[i])
        {
            case 'I':
                {
                    res += 1;
                    i += 1;
                    if (i < s.Length + 1)
                    {
                        switch (s[i])
                        {
                            case 'I':
                                {
                                    res += 1;
                                    i += 1;
                                    if (i < s.Length + 1)
                                    {
                                        res += 1;
                                    }
                                    break;
                                }
                            case 'V':
                                {
                                    res = 4;
                                    break;
                                }
                            case 'X':
                                {
                                    res = 9;
                                    break;
                                }
                        }
                    }
                }
            case 'V':
                {
                    res = 5;
                    i += 1;
                    if (i < s.Length + 1)
                    {
                        res = 6;
                        i += 1;
                        if (i < s.Length + 1)
                        {
                            res = 7;
                            i += 1;
                            if (i < s.Length + 1)
                            {
                                res = 8;
                            }
                        }

                    }
                    break;
                }
                default: Console.Write("Такого римского числа не существует");
        }
        //if (s[i] == 'I') rom[i] = 1;
        //if (s[i] == 'V') rom[i] = 5;
        //if (s[i] == 'X') rom[i] = 10;
        //if (s[i] == 'L') rom[i] = 50;
        //if (s[i] == 'C') rom[i] = 100;
        //if (s[i] == 'D') rom[i] = 500;
        //if (s[i] == 'M') rom[i] = 1000;
    }
    //res = rom[0];
    {
        //for (i = 1; i < s.Length; i++)
        {
            //res += rom[i];
        }
        return res;
    }
}
//return res;
Console.Write("Вы получили римское число = ");
Console.Write(ChangeNum(N));
Console.WriteLine();
*/
