// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа, находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine("Введите числа для переменных k1, b1, k2 и b2");

Console.Write("k1 = ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("b1 = ");
int b1 = int.Parse(Console.ReadLine()!);

Console.Write("k2 = ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("b2 = ");
int b2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Полученные уравнения: ");
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");

//функция получения точки х
double GetX()
{
    double x = (double)(b2 - b1) / (k1 - k2);
    return x;
}

//функция получения точки у
double GetY(double x)
{
    double y = k1 * x + b1;
    return y;
}

double x = GetX();
double y = GetY(x);

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают.");
}
else
{
    Console.WriteLine($"Координаты точки пересечения: ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}