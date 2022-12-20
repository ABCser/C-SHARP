Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0) Console.WriteLine($"КРАСАВА! {num1} кратно 7 и 23 одновременно! ");

else Console.WriteLine($"{num1} не кратно 7 и 23 одновременно!");