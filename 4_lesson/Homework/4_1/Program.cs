// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. 
// Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Extent(double a, double b)
{
    double op = 1;
    double c = 0;

    if (b < 0)
    {
        c = b;
        b = b * (-1);
    }
    for (int i = 1; i <= b; i++)
    {
        if (a > 0)
        {
            op = op * a;
        }
        else
        {
            a = a * (-1);
            op = -(op * a);
        }
    }
    if (c < 0)
    {
        op = 1 / op;
    }
    op = Math.Round(op, 4);
    return op;
}

Console.WriteLine("Введите число A: ");
double num_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double num_2 = double.Parse(Console.ReadLine());

Console.WriteLine($"{num_1} в {num_2} степени = {Extent(num_1, num_2)}");
