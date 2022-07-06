// программа показывает количество цифр в числе

int countnum(int num)
{
    string n = num.ToString();
    return n.Length;
}


Console.WriteLine(countnum(214));