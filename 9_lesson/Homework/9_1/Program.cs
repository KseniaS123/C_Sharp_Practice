// Задайте значение N. Напишите программу,
// которая выведет все четные натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "4, 2"
// N = 8 -> "4, 6, 8"


void Integers(int N)
{
    if (N == 0) return;
    if (N % 2 == 0)
        Console.Write($"{N} ");
    Integers(N - 1);   
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"Четные числа от {n} до 1: ");
Integers(n);
Console.WriteLine();