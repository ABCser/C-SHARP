int programm;

void Menu(int num)
{
    switch (programm)
    {
        case 2:
            Z2();
            break;

        case 4:
            Z4();
            break;

        case 6:
            Z6();
            break;

        case 8:
            Z8();
            break;

        case 10:
            Z10();
            break;

        case 13:
            Z13();
            break;

        case 15:
            Z15();
            break;

        case 19:
            Z19();
            break;

        case 20:
            Z20();
            break;

        case 21:
            Z21();
            break;

        case 22:
            Z22();
            break;

        case 23:
            Z23();
            break;

        case 25:
            Z25();
            break;

        case 26:
            Z21();
            break;

        case 27:
            Z27();
            break;

        case 29:
            Z29();
            break;

        case 30:
            Z30();
            break;

        default:
            Console.WriteLine("Выхожу из программы!! До встречи!");
            break;
    }
}

void Z2()
{
    // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    // a = 5; b = 7 -> max = 7
    // a = 2 b = 10 -> max = 10
    // a = -9 b = -3 -> max = -3
    Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("----------------------------------------------------------------------------------------------");

    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2) Console.WriteLine($"MAX = {num1}, MIN = {num2} ");

    else if (num1 < num2) Console.WriteLine($"MAX = {num2}, MIN = {num1} ");

    else Console.WriteLine("Числа равны!");
}

void Z4()
{
    // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    // 2, 3, 7 -> 7
    // 44 5 78 -> 78
    // 22 3 9 -> 22
    Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("----------------------------------------------------------------------------------------------");

    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите третье число: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int max = num1;

    if (num1 > max) max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;

    Console.WriteLine($"MAX = {max}");
}

void Z6()
{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    // 4 -> да
    // -3 -> нет
    // 7 -> нет
    Console.WriteLine("Программа, которая на вход принимает число и выдаёт, является ли число чётным.");
    Console.WriteLine("----------------------------------------------------------------------------------------------");

    Console.Write("Введите число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int i = num1 % 2;

    if (i == 0) Console.Write($"Число {num1} - ЧЁТНОЕ!!!");
    else Console.Write($"Число {num1} - НЕЧЁТНОЕ!!!");
}

void Z8()
{
    // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    // 5 -> 2, 4
    // 8 -> 2, 4, 6, 8

    //for (int i = 0; i<=num;i=i+2) Console.Write($"{i} ");
    Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine("----------------------------------------------------------------------------------------------");

    Console.Write("Введите первое число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int chet = 2;

    while (chet <= N) // вывод всех чисел от 2 до N
    {
        if (chet % 2 == 0)
            Console.Write($"{chet} ");
        chet++;
    }
}

void Z10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
    // 456 -> 5
    // 782 -> 8
    // 918 -> 1

    //ВАРИАНТ1
    // Console.Write("Введите трёхзначное число: ");
    // int num = Convert.ToInt32(Console.ReadLine());

    // int res = Math.Abs(num % 100 / 10); // модуль 2 цифры

    // if (num < 1000 && num > 99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
    // else if (num > -1000 && num < -99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
    // else Console.WriteLine($"Ошибка! Введите трехзначное число!!!");

    //ВАРИАНТ2
    void Chislo(int num)
    {
        int res = Math.Abs(num % 100 / 10);
        if (num < 1000 && num > 99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
        else if (num > -1000 && num < -99) Console.WriteLine($"Вторая цифра введенного числа = {res}.");
        else Console.WriteLine($"Ошибка! Введите трехзначное число!!!");
    }

    try
    {
        Console.WriteLine("Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");

        Console.Write("Введите трехзначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Chislo(num);
    }

    catch
    {
        Console.WriteLine($"Ошибка! Введите ЦЕЛОЕ трехзначное число!!!");
    }
}

void Z13()
{
    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
    // 645 -> 5
    // 78 -> третьей цифры нет
    // 32679 -> 6

    void ThirdNum(int num)
    {
        int counter = 0;
        int mod = (int)Math.Abs(num); // находим модуль числа
        int module = mod; // Дополнительная переменная модуля числа
        if (mod == 0) // если модуль числа равен нулю, то число состоит из 1 разряда
        {
            counter = 1;
        }
        while (mod != 0) // число делится на 10 пока не дойдет до нуля.
        {
            mod = mod / 10;
            counter++; // цикл завершается а counter накопил в себе количество делений на 10, тем самым показав нам разряд
        }

        if (counter < 3) // если невозможно определить третью цифру
        {
            Console.WriteLine("ВНИМАНИЕ! Невозможно определить третью слева цифру! Число разрядностью < 3! ");
        }
        else
        {
            int multiplier = (int)Math.Pow(10, counter - 3); // множитель 3 слева разряда
            int result = module % (10 * multiplier) / multiplier;
            Console.WriteLine($"Третья слева цифра = {result}");
        }
    }

    try
    {
        Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        ThirdNum(num);
    }

    catch
    {
        Console.WriteLine("Ошибка! Программа работает только с целыми числами! Введите целое число!");
    }
}

void Z15()
{
    // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    // 6 -> да
    // 7 -> да
    // 1 -> нет

    void Weekend(int den)
    {
        if (den <= 7 && den >= 1)
        {
            if (den == 6 || den == 7) Console.WriteLine("Ура! Сегодня выходной!!!");
            else Console.WriteLine("Иди РАБотай! Сегодня будний день!!!");
        }
        else Console.WriteLine("В неделе всего 7 дней! Проверь, не с другой ли ты планеты!");
    }
    try
    {
        Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Введите номер дня недели от 1 до 7, где 1 - это понедельник, а 7 - воскресенье: ");
        int den = Convert.ToInt32(Console.ReadLine());
        Weekend(den);
    }
    catch
    {
        Console.WriteLine("Что-то пошло не так! Проверьте правильность ввода данных!!!");
    }
}

void Z19()
{
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
    // 14212 -> нет
    // 12821 -> да
    // 23432 -> да

    void Palindrom(int n)
    {
        if (n > 99999 || n < 10000) Console.WriteLine("Ошибка! Вы ввели не пятизначное число!!!");
        else
        {
            if (n % 10 == n / 10000 && n / 1000 % 10 == n % 100 / 10) Console.WriteLine("Число является палиндромом!");
            else Console.WriteLine("Число НЕ является палиндромом!");
        }
    }

    try
    {
        Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Введите пятизначное число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int n = Math.Abs(x);
        Palindrom(n);
    }

    catch
    {
        Console.WriteLine("Ошибка! Программа работает только с целыми пятизначными числами!");
    }
}

void Z20()
{
    // Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.



    // Вариант решения через модуль bool 
    bool Palinndrom(int num) //Определяем палиндром

    {
        int N = Math.Abs(num);
        int N_norm = N;
        int N_rev = 0;

        while (N > 0) // отзеркаливаем число
        {
            int temp = N % 10;   // (123456) 6 -> 5 -> 4 -> 3 -> 2 ->  1
            N_rev = (N_rev * 10) + temp; // (6) -> 65 -> 654 -> 6543 -> 65432 -> 654321
            N = N / 10; // (123456) 12345 -> 1234 -> 123 -> 12 -> 1 -> 0 (Стоп) 
        }

        if (N_norm == N_rev && N_rev >= 10) return true;
        else return false;
    }
Begin:
    try
    {
        Console.WriteLine("Программа, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.Write("Введите любое число! ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (Palinndrom(n)) Console.WriteLine($"Число {n} является палиндромом!");
        else Console.WriteLine($"Число {n} НЕ является палиндромом!");
    }

    catch
    {
        Console.WriteLine("Ошибка! Проверьте правильность введенных данных!!!");
        goto Begin;
    }




    // int Mirror(int n) // отзеркаливаем число
    // {
    //     int N = Math.Abs(n);
    //     int N_rev = 0;

    //     while (N > 0)
    //     {
    //         int temp = N % 10;   // (123456) 6 -> 5 -> 4 -> 3 -> 2 ->  1
    //         N_rev = (N_rev * 10) + temp; // (6) -> 65 -> 654 -> 6543 -> 65432 -> 654321
    //         N = N / 10; // (123456) 12345 -> 1234 -> 123 -> 12 -> 1 -> 0 (Стоп) 
    //     }
    //     return N_rev;
    // }

    // bool Palinndrom(int num, int mun) //Определяем палиндром
    // {
    //     if (Math.Abs(num) == mun && mun >= 10) return true;
    //     else return false;
    // }
    // Begin:
    // try
    // {
    //     Console.Write("Введите любое число! ");
    //     int n = Convert.ToInt32(Console.ReadLine());
    //     int a = Mirror(n);
    //     bool isPal = Palinndrom(n, a);
    //     if (isPal) Console.WriteLine($"Число {n} является палиндромом!");
    //     else Console.WriteLine($"Число {n} НЕ является палиндромом!");
    // }

    // catch
    // {
    //     Console.WriteLine("Ошибка! Проверьте правильность введенных данных!!!");
    //     goto Begin;
    // } 
    //  Вариант через void
    // void Palindrom(int n)
    // {
    //     int N = Math.Abs(n);
    //     int N_norm = N;
    //     int N_rev = 0;

    //     while (N > 0) // отзеркаливаем число
    //     {
    //         int temp = N % 10;   // (123456) 6 -> 5 -> 4 -> 3 -> 2 ->  1
    //         N_rev = (N_rev * 10) + temp; // (6) -> 65 -> 654 -> 6543 -> 65432 -> 654321
    //         N = N / 10; // (123456) 12345 -> 1234 -> 123 -> 12 -> 1 -> 0 (Стоп) 
    //     }

    //     if (N_norm < 10 && N_norm >= 0)
    //         Console.WriteLine($"Число {n} НЕ является палиндромом, так как состоиз из 1 разряда!!!");
    //     else if (N_norm == N_rev)
    //         Console.WriteLine($"Число {n} является палиндромом!");
    //     else
    //         Console.WriteLine($"Число {n} НЕ является палиндромом!");
    // }

    // try
    // {
    //     Console.Write("Введите любое число! ");
    //     int n = Convert.ToInt32(Console.ReadLine());
    //     Palindrom(n);
    // }

    // catch
    // {
    //     Console.WriteLine("Ошибка! Проверьте правильность введенных данных!!!");
    // } 
}

void Z21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53

    double Dist(double x1, double x2, double y1, double y2, double z1, double z2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return Math.Round(distance, 2);
    }

    try
    {
        Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");

        Console.Write("Введите x координату точки A: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y координату точки A: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите z координату точки A: ");
        double z1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите x координату точки B: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y координату точки B: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите z координату точки B: ");
        double z2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Расстояние между точками = {Dist(x1, x2, y1, y2, z1, z2)}");
    }

    catch
    {
        Console.WriteLine("Проверьте правильность ввода данных");
    }
}

void Z22()
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53

    int[] coordInput(int times) // Метод для ввода координат! возвращает массив длинной times 
    {
        int[] array = new int[times];
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine($"Введите {i + 1} координату");
            array[i] = Convert.ToInt32(Console.ReadLine());
        } //Повторяем times-раз
        return array;
    }

    double Distance(int[] array_A, int[] array_B)  // Метод для рассчета расстояния! возвращает число, принимает 2 массива 
    {
        double counter = 0;
        for (int i = 0; i < array_A.Length; i++)
        {
            counter = counter + Math.Pow(array_B[i] - array_A[i], 2);
        }
        double dist = Math.Sqrt(counter);
        return Math.Round(dist, 2);
    }

Begin:
    try
    {
        Console.WriteLine("Программа, которая принимает на вход количество измерений и координаты двух точек и находит расстояние между ними в заданном пространстве.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");

        Console.WriteLine("Введите количество измерений в пространстве: ");
        int dimentions = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (dimentions < 0)
        {
            dimentions = Math.Abs(dimentions);
            Console.WriteLine($"Вы ввели отрицательное число! Возможно Вы имели в виду {Math.Abs(dimentions)}?");
            Console.WriteLine("Но не волнуйтесь! Мы все исправили!");
            Console.WriteLine();
        }
        if (dimentions == 0)
        {
            Console.WriteLine("Похоже, вы ввели НОЛЬ, а в 0-D измерении расстояний не существует!!! Попробуйте ещё раз!");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine();
            goto Begin; // если НОЛЬ то в начало
        }

        Console.WriteLine("Введите координаты точки A:");
        int[] coordA = coordInput(dimentions);

        Console.WriteLine("Введите координаты точки B:");
        int[] coordB = coordInput(dimentions);

        Console.WriteLine($"Рсстояние между точками A и B = {Distance(coordA, coordB)}");
    }

    catch
    {
        Console.WriteLine("Что-то пошло не так! Проверьте правильность ввода данных!!!");
        Console.WriteLine("----------------------------------------------------------------------------------------");
        goto Begin; // В начало, если ошибка!!!
    }
}

void Z23()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    // 3 -> 1, 8, 27
    // 5 -> 1, 8, 27, 64, 125

    void Kub(int N)
    {
        if (N <= 0) Console.WriteLine("Попробуйте ввести число > 0!");
        else
        {
            Console.WriteLine($"Кубы чисел  от 1 до {N} равны: ");
            for (int i = 1; i <= N; i++)
            {
                double kub = Math.Pow(i, 3);
                Console.Write($"{kub} ");
            }
        }
    }

    try
    {
        Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        Console.WriteLine("----------------------------------------------------------------------------------------------");
        Console.WriteLine("Введите целое положительное число: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Kub(N);
    }

    catch
    {
        Console.Write("УПС! Что-то пошло не так! проверьте правильность ввода данных!");
    }
}

void Z25()
{
    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16

    // Ваниант через Math.Pow

    // double Pow(int ф, int x)
    // {
    //     double res = Math.Pow(a,x);
    //     return res;
    // }

    // Вариант 2:
    int Power(int a, int x)
    {
        int res = 1;
        for (int i = 0; i < x; i++)
            res *= a;
        return res;
    }

    Console.Write("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{a} в степени {x} равно = {Power(a, x)}");

}

void Z26()
{

}

void Z27()
{
    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12

    int Len(int x)
    {
        int counter = 1;
        while (x / 10 != 0)
        {
            x = x / 10;
            counter++;
        }
        return counter;
    }

    int Sum(int x, int length)
    {
        int sum = 0;
        int mod = Math.Abs(x);
        if (mod == 0) sum = 1;
        for (int i = 1; i <= length; i++)
        {
            sum = sum + mod % 10;
            mod = mod / 10;
        }
        return sum;
    }

    Console.Write("Введите целое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int length = Len(a);
    Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a, length)}");
}

void Z29()
{
    // Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

    int[] PrintArray(int len)
    {
        {
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = new Random().Next(1, 99);
                Console.Write(array[i] + " ");
            }
            return array;
        }
    }
    Console.Write("Введите количество элементов массива: ");
    int x = Convert.ToInt32(Console.ReadLine());

    PrintArray(x);
}

void Z30()
{

}


try
{
    Console.WriteLine("------");
    Console.WriteLine("Введите номер задачи (для выхода введите любое другое число): ");
    Console.WriteLine();
    Console.WriteLine("2. Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("4. Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("6. Программа, которая на вход принимает число и выдаёт, является ли число чётным.");
    Console.WriteLine("8. Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine("10. Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("13. Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("15. Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    Console.WriteLine("19. Программа, принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.WriteLine("20*. Программа, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.");
    Console.WriteLine("21. Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("22*. Программа, которая принимает на вход количество измерений и координаты двух точек и находит расстояние между ними в заданном пространстве.");
    Console.WriteLine("23. Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
    Console.WriteLine("25. Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
    Console.WriteLine("26*. Программа, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.");
    Console.WriteLine("27. Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("29. Программа, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.");
    Console.WriteLine("30*.  которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.");

    programm = Convert.ToInt32(Console.ReadLine());
    Menu(programm);
}

catch
{
    Console.WriteLine("Ошибка! Программа работает только с целыми числами! Введите целое число!");
}


// void Next()
// {
//     Console.WriteLine("------------------------------------------");
//     Console.WriteLine($"Перезапустить задачу №{programm} - R(r) ");
//     Console.WriteLine("Выбрать другую задачу? Да - Y(y)/ Нет - N(n)");

//     string next = Convert.ToString(Console.ReadLine());
//     if (next == "N" || next == "n") begin = false;
//     if (next == "R" || next == "r") programm == programm;
//     else;
// }
