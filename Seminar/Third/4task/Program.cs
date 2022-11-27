// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// void square (int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         int sqrt = (i * i);
//         return sqrt;
//     }
// }

// try
// {
//     Console.Write("Введите целое число ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     if (N < 0) N = -N;
//     else if (N == 0) Console.WriteLine("0 ");
//     Console.WriteLine(square(N));

// }

// catch
// {
//     Console.Write("УПС! ");
// }

Console.WriteLine("Напишите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат чисел равен: ");

for (int i = 1; i <= N; i++)
{
    int sqrt = (i * i);
    Console.Write($"{sqrt} ");
}
