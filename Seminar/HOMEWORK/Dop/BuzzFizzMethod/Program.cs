for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0) Console.Write("FizzBuzz "); // Кратно ли 15
    if (i % 3 == 0) Console.Write("Fizz "); // Кратно ли 3
    if (i % 5 == 0) Console.Write("Buzz "); // Кратно ли 5
    else Console.Write($"{i} ");
}