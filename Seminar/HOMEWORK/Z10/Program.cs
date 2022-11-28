// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//ВАРИАНТ1
// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int res = Math.Abs(num % 100 / 10); // модуль 2 цифры

// if (num < 1000 && num > 99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
// else if (num > -1000 && num < -99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
// else Console.WriteLine($"Ошибка! Введите трехзначное число!!!");

//ВАРИАНТ2
void Chislo(int num)
{
    int res = Math.Abs(num % 100 / 10);
    if (num < 1000 && num > 99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
    if (num > -1000 && num < -99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
    else Console.WriteLine($"Ошибка! Введите трехзначное число!!!");
}

try
{
    Console.Write("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Chislo(num);
}

catch
{
    Console.WriteLine($"Ошибка! Введите ЦЕЛОЕ трехзначное число!!!");
}