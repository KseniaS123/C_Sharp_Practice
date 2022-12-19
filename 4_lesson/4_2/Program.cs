// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.


int Times(int num)
{
    int pr = 1;
    for (int i = 1; i <= num; i++)
    {
        pr = pr * i;
    }

    return pr;
}

Console.WriteLine(Times(int.Parse(Console.ReadLine())));