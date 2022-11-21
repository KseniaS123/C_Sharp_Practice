// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Write a number: ");
int N = int.Parse(Console.ReadLine());
int negN = - N;

while(negN <= N)
{
    Console.Write($"{negN}, ");
    negN += 1;
}
