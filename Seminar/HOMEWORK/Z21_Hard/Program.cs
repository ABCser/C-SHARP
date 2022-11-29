// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
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
    Console.WriteLine("Введите количество измерений в пространстве: ");
    int dimentions = Convert.ToInt32(Console.ReadLine());
    if (dimentions < 0)
    {
        dimentions = Math.Abs(dimentions);
        Console.WriteLine($"Вы ввели отрицательное число! Возможно Вы имели в виду {Math.Abs(dimentions)}?");
        Console.WriteLine("Но не волнуйтесь! Мы все исправили!");
    }
    if (dimentions == 0)
    {
        Console.WriteLine("Похоже, вы ввели НОЛЬ, а в 0-D измерении расстояний не существует!!! Попробуйте ещё раз!");
        Console.WriteLine("----------------------------------------------------------------------------------------");
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