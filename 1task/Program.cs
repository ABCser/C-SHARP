Console.WriteLine("Введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());

int squarenum2 = num2 * num2;

if (num1 == squarenum2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
