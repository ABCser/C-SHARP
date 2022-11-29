// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kub(int N)
{
    if (N <= 0) Console.WriteLine("Попробуйте ввести число > 0!");
    else
    {
        Console.WriteLine($"Кубы чисел  от 1 до {N} равны: ");
        for (int i = 1; i <= N; i++)
        {
            double kub = Math.Pow(i, 3);
            Console.Write($"{kub} ");
        }
    }
}

try
{
    Console.WriteLine("Введите целое положительное число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Kub(N);
}

catch
{
    Console.Write("УПС! Что-то пошло не так! проверьте правильность ввода данных!");
}