// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void NumberThree(int num)
{
    if (num < 100 && num > -100)
    {
        Console.WriteLine("Третьей цифры нет");
        return;
    }

    while (num > 999 || num < -999)
    {
        num /= 10;
    }
    Console.WriteLine($"Третья цифра в числе: {num % 10}");
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
NumberThree(num);