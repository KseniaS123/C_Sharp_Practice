// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.


void IntegersSecond(int M, int N)
{
    if (M > N) return;
    Console.Write($"{M} ");
    IntegersSecond(M + 1, N);
}
IntegersSecond(5, 10);
Console.WriteLine();