// 2. Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

int Maxnum(int num)
{
    int a = num / 10;
    int b = num % 10;
    
    if (a>b)
    {
        return a;
    }
    return b;
}
int k = new Random().Next(10, 100);
Console.WriteLine(Maxnum(k));