// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} в степени {b} равно = {Power(a, b)}");
Console.WriteLine($"{a} в степени {b} равно = {PowerRec(a, b)}");


int Power(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
        res *= a;
    return res;
}

int PowerRec(int a, int b)
{
    if (b == 0) return 1;
    return a * PowerRec(a, b-1);
}