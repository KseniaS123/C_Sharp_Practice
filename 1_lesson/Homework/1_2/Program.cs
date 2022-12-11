// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int num_3 = int.Parse(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}
Console.WriteLine($"Максимальное: {max}");