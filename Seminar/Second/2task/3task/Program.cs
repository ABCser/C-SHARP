Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int num3 = num2 % num1;

if (num2 % num1 == 0) Console.WriteLine($"{num2} кратно {num1} ");

else Console.WriteLine($"Числа не кратные, остаток = {num3}");
