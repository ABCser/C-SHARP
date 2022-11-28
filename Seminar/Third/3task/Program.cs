// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2

double Rast(double  x1, double  x2, double y1, double y2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return distance;
}

try
{
    Console.Write("Введите координаты x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    
}

catch
{
    Console.WriteLine("Проверьте правильность ввода данных");
}