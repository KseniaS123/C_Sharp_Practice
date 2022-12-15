// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

string Number(int num)
{    
    if (num % 7 == 0 && num % 23 == 0)
        return "Число кратно 7 и 23";
    else
    {
        return "Число некратно 7 и 23";
    }
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Number(num));