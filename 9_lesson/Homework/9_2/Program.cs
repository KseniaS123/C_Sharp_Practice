// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int IntegersSumma(int M, int N)
{
    if (M > N) return 0;
    if (N == M) return M;
    return M + IntegersSumma(M + 1, N);
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} = {IntegersSumma(m, n)}");

