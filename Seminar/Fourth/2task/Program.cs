// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int len(int num)
{
    int counter = 0;
    int mod = (int)Math.Abs(num);
    if (mod == 0) counter = 1;
        while (num != 0) // число делится на 10 пока не дойдет до нуля.
    {
        num = num / 10;
        counter++; // цикл завершается а counter накопил в себе количество делений на 10, тем самым показав нам разряд
    }
    return counter;
}

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {num} = {len(num)}");