// 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// Формула вычисления расстояния - AB = √(xb - xa)2 + (yb - ya)2

double Distance(int ax, int ay, int bx, int by)
{
    double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    return result;
}

Console.Write("Введите aX: ");
int ax = int.Parse(Console.ReadLine());

Console.Write("Введите aY: ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Введите bX: ");
int bx = int.Parse(Console.ReadLine());

Console.Write("Введите bY: ");
int by = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by),2));