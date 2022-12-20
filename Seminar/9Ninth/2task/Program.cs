// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{N} -> {Posl(N)}");
Console.WriteLine($"{N} -> {Posled(N)}");

string Posl(int N)
{
    string res = "";
    while (true)
    {
        res = N + " " + res;
        N--;
        if (N == 0)
            break;
    }
    return res;
}

string Posled(int N)
{
    if (N == 1) return "1";
    else return Posled(N - 1) + " " + Convert.ToString(N);
}