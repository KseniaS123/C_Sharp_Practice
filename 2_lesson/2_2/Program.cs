// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деления.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

string Crat(int a, int b)
{
    if (a % b == 0)
        return "кратно";
    else
    {
        return ($"некратано, остаток: {a % b}");
    }
}

Console.WriteLine("Первое число");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число");
int num_2 = int.Parse(Console.ReadLine());
Console.WriteLine(Crat(num_1, num_2));

