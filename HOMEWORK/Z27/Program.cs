// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Len(int x)
{
    int counter = 1;
    while (x / 10 != 0)
    {
        x = x / 10;
        counter++;
    }
    return counter;
}

int Sum(int x, int length)
{
    int sum = 0;
    int mod = Math.Abs(x);
    if (mod == 0) sum = 1;
    for (int i = 1; i <= length; i++)
    {
        sum = sum + mod % 10;
        mod = mod / 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int length = Len(a);
Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a, length)}");