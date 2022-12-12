// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string WeekDay(int num)
{
    if (num == 6 || num == 7)
        return "Выходной";
    else if (num > 7 || num < 1)
    {
        return "Введите номер от 1 до 7";
    }
    else
    {
        return "Рабочий";
    }
}
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(WeekDay(num));
