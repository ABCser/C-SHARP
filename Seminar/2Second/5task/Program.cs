Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 - (num1 * num1) == 0) Console.Write($"{num2} является квадратом {num1}");
else if (num1 - (num2 * num2) == 0)Console.Write($"{num1} является квадратом {num2}");
else Console.Write("Ни одно из чисел не является квадратом другого");