// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
// Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.
using System.Diagnostics;
namespace StopwatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем объект
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();
            //выполняем какую-либо операцию
        int n1 = 1;
        while (n1 <= 100) // вывод всех чисел от 1 до 100
        {
        if (n1 % 15 == 0) // Кратно ли 15
        {
            Console.WriteLine("FizzBuzz ");
            n1++;
        }        
        if (n1 % 3 == 0) // Кратно ли 3
        {
            Console.WriteLine("Fizz ");
            n1++;
        }
        if (n1 % 5 == 0) // Кратно ли 5
        {
            Console.WriteLine("Buzz ");
            n1++;
        }
        else
        { 
            Console.WriteLine($"{n1} ");
            n1++;
        }
}
            //останавливаем счётчик
            stopwatch.Stop();
            //смотрим сколько миллисекунд было затрачено на выполнение
            Console.WriteLine($"Время выполнения программы: {stopwatch.ElapsedMilliseconds} милисекунд.");
        }
    }
}