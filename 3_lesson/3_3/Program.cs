// 3. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

void Square(int N)
{
    int i = 1;
    double n;
    while (i <= N)
    {
        if (i == N)
        {
            n = Math.Pow(i, 2);
            Console.Write($"{n}");
        }
        else
        {
            n = Math.Pow(i, 2);
            Console.Write($"{n}, ");
        }
        i += 1;
    }
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Square(num);
Console.WriteLine();