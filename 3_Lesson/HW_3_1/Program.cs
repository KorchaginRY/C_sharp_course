// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Poly(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
    {
        Console.WriteLine("DA");
    }
    else
        Console.WriteLine("No");

}

Poly(14212);
Poly(12821);
Poly(23432);
Console.WriteLine("---------Способ №2 через string----------------------");
// -------------------------------------------------------------------

void Polindrom(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "Yes";
    while (i < size / 2)
    {
        if (num[i] != num[size-i])
        {
            flag = "No";
            break;
        }
        i++;
    }
    Console.WriteLine($"{n} -> {flag}");
}

Polindrom(1234321);
Polindrom(1234567);
Polindrom(141);
Polindrom(4224);