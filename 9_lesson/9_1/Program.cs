// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void Integers(int N)
{
    if (N == 0) return;
    Integers(N - 1);
    Console.Write($"{N} ");    
}
Integers(5);
Console.WriteLine();
