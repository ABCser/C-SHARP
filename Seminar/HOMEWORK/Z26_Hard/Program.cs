// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

double FullNum(double num)
{
    while (num % 1 != 0) // число делится 10 пока не дойдет до нуля.
    {
        num = num * 10;
    }
    return num;
}

int Len(int x)
{
    int counter = 1;
    if (x == 0) counter = 1;
    while (x / 10 != 0)
    {
        x = x / 10;
        counter++;
    }
    return counter;
}

Console.Write("Введите целое : ");
double a = Convert.ToDouble(Console.ReadLine());
int fullnum = Convert.ToInt32(FullNum(a));
Console.WriteLine($"Количество цифр в числе {a} = {Len(fullnum)}");