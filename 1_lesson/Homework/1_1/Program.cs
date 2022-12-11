//  Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите число: ");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число: ");
int num_2 = int.Parse(Console.ReadLine());

if (num_1 < num_2)
{
    Console.WriteLine($"{num_2} больше, чем {num_1}");
}
else if (num_1 == num_2)
{
    Console.WriteLine($"{num_1} равно {num_2}");
}
else
{
    Console.WriteLine($"{num_1} больше, чем {num_2}");
}
