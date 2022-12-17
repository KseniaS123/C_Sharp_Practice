// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Square(int N)
{
    int i = 1;
    double n;
    while (i <= N)
    {
        if (i == N)
        {
            n = Math.Pow(i, 3);
            Console.Write($"{n}");
        }
        else
        {
            n = Math.Pow(i, 3);
            Console.Write($"{n}, ");
        }
        i += 1;
    }
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Square(num);
Console.WriteLine();