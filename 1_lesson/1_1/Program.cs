// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.WriteLine("Write a number: ");
int num_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number: ");
int num_2 = int.Parse(Console.ReadLine());

if(num_2 == num_1 * num_1)
{
   Console.WriteLine("Yes"); 
}
else
{
    Console.WriteLine("No");
}