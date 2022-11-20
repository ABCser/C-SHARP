Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = num1 * -1;

while (num2 <= num1) // вывод всех чисел от num2 до num1
{
    Console.Write($"{num2} ");
    num2++;
}
Console.WriteLine();