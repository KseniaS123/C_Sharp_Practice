// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

string NumSecondDelete()
{
    int num = new Random().Next(-999, 1000);
    if((num > 99 && num < 1000) || (num < -99 && num > -1000))
    {
        return $"{num} -> {num / 100 * 10 + num % 10}";
    }
    else
    {
        return $"{num} - число не является трехзначным, перезапустите программу";
    }
}
Console.WriteLine(NumSecondDelete());



// void NumSecondDelete()
// {
//    int num = new Random().Next(100, 1000);
//    Console.WriteLine(num);
//    Console.WriteLine($"{num / 100}{num % 10}");
// }

// NumSecondDelete();
