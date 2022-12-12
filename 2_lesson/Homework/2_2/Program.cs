// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

void NumSecondDelete()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine(num);
    Console.WriteLine($"{num / 100}{num % 10}");
}

NumSecondDelete();
