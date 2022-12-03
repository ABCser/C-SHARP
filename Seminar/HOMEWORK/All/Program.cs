while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.  Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("11. (Не рабочий) С использованием реверса строки");
    Console.WriteLine("111. стыреный из интырнета метод проверки строки на число");
    Console.WriteLine("     TryParse - пока не разобрался как работет");
    Console.WriteLine("2. Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("3. Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {

void Z2()
    {
        // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        // a = 5; b = 7 -> max = 7
        // a = 2 b = 10 -> max = 10
        // a = -9 b = -3 -> max = -3
        Case 2;
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2) Console.WriteLine($"MAX = {num1}, MIN = {num2} ");

        else if (num1 < num2) Console.WriteLine($"MAX = {num2}, MIN = {num1} ");

        else Console.WriteLine("Числа равны!");
    }
}
}