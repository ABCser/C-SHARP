    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16

    // Ваниант 1 через Math.Pow
    // double Pow(int ф, int x)
    // {
    //     double res = Math.Pow(a,x);
    //     return res;
    // }

    // Вариант 2:
    int Power(int a, int x)
    {
        int res = 1;
        for (int i = 0; i < x; i++)
            res *= a;
        return res;
    }

    Console.Write("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{a} в степени {x} равно = {Power(a, x)}");