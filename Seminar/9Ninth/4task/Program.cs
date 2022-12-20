// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(N));
Console.WriteLine(SumRec(N));

int Sum(int x)
{
    int sum = 0;
    int mod = Math.Abs(x);
    while (mod > 0)
    {
        sum = sum + mod % 10;
        mod = mod / 10;
    }
    return sum;
}

int SumRec(int x)
{
    if (x == 0) return 0;
    return x % 10 + SumRec(x / 10);
}