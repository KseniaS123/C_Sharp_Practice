// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите любое число, начиная с единицы: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

if (N < i)
{
    Console.Write("введите число, начиная с единицы");
}
else
{
    Console.WriteLine($"Четные числа от 1 до {N}:");
}
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    if (N == 1)
    {
        Console.Write("четных чисел нет");
    }
    i = i + 1;  
}
Console.WriteLine("");


