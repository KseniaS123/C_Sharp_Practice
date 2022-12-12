// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

string NumberSecond(int num)
{
    if ((num > 99 && num < 1000) || (num < -99 && num > -1000))
    {
        return $"{num / 10 % 10}";
    }
    else
    {
        return "Число не является трехзначным";
    }
}
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(NumberSecond(num));


// int NumberSecond(int num)
// {
//    Console.WriteLine(num);
//    return num / 10 % 10;
// }
// Console.WriteLine(Number(new Random().Next(100, 1000)));
