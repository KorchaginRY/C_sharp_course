Console.Write("Введите 1е число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2е число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine("Число 1 является квадратом 2 числа ");
}
else
{
    Console.WriteLine("Число 1  НЕ является квадратом 2 числа ");
}
