// Нахождение точки пересечения двух прямых заданных уравнениями y=k1*x+b1, y=k2*x+b2

void Point(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + k2;
    Console.WriteLine($"Точка пересечения: ({x};{y})");
}

Point(2, 4, 6, 2);