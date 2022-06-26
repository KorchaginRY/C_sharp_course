Console.Write("Введите значение от 1 до 7 : ");
int val = int.Parse(Console.ReadLine());
if (val < 8)
{
    if (val == 1) { Console.WriteLine("Понедельник"); }
    if (val == 2) { Console.WriteLine("Вторник"); }
    if (val == 3) { Console.WriteLine("Среда"); }
    if (val == 4) { Console.WriteLine("Четверг"); }
    if (val == 5) { Console.WriteLine("Пятница"); }
    if (val == 6) { Console.WriteLine("Суббота"); }
    if (val == 7) { Console.WriteLine("Воскресение"); }
}
else
    Console.WriteLine("Нет такого дня");
