// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//for (int i = 0; i<=num;i=i+2) Console.Write($"{i} ");

Console.Write("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int chet = 2;

while (chet <= N) // вывод всех чисел от 2 до N
{
    if (chet % 2 == 0)
    Console.Write($"{chet} ");
    chet++;
}