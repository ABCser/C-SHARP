// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

int SumNum(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++) sum += i;
    return sum;
}

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех числел от 1 до {num} = {SumNum(num)}");