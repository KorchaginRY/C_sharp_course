// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kub(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }

}

Kub(3);
Kub(5);
Console.WriteLine();