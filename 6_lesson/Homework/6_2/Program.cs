// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntPointCoord(double b1, double k1, double b2, double k2)
{
    if ((k1 - k2) == 0)
        Console.Write("Ошибка: 'деление на 0', введите другие значения переменных!");
    else
    {   
        double x = Math.Round((b2 - b1) / (k1 - k2), 2);
        double y = Math.Round(k1 * x + b1, 2);
        Console.Write($"Координаты точки пересечения прямых: ({x}; {y})");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

IntPointCoord(b1, k1, b2, k2);