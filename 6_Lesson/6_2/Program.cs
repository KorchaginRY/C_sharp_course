// Программа преобразовывает 10-ое в двоичное число

string Transform(int num)
{
    string val = "";
    while (num > 0)
    {
        val = num % 2 + val;
        num /= 2;
    }
    return val;
}

Console.WriteLine(Transform(2));