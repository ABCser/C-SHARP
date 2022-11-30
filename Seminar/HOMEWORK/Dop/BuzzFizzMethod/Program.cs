int[] FizzBuzz(int num)
{
    int[] array = new int[num];
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 15 == 0) Console.WriteLine("FizzBuzz ");
        else if (i % 5 == 0) Console.WriteLine("Buzz ");
        else if (i % 3 == 0) Console.WriteLine("Fizz ");
        else Console.WriteLine($"{i} ");
    }
    return array;
}
FizzBuzz(101);