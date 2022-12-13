// 1. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int NumbCount(int num)
{
    if(num==0)
    {
        return 1;
    }
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
Console.WriteLine(NumbCount(int.Parse(Console.ReadLine())));
