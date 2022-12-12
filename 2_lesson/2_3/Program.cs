// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

string Number(int num)
{    
    if (num % 7 == 0 && num % 23 == 0)
        return "Yes";
    else
    {
        return "No";
    }
}
Console.WriteLine("Enter Number");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Number(num));