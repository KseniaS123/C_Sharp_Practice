// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int num)
{
    int a = 0;
    int b = 0;
    int c = 0;
    int d = 0;
    if ((num > 9999 && num < 100000) || (num < -9999 && num > -100000))
    {
        a = num / 10000;
        b = num % 10;
        c = num / 1000 % 10;
        d = num % 100 / 10;
    
        if (a == b && c == d)
        {
            Console.WriteLine("да, это палиндром");
        }
        if (a != b || c != d)
        {
            Console.WriteLine("не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine($"{num} - не является пятизначным числом");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
Palindrome(num);