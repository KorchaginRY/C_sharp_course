// 1. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

void Triangle(int a, int b, int c)
{
    string flag = "Нельзя";
    if (a + b > c && a + c > b && b + c > a)
    { flag = "Можно"; }
    Console.WriteLine(flag);
}


Triangle(1, 2, 2);