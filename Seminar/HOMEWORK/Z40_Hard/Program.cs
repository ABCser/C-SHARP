// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.


bool IsTraingle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;
    else
    {
        Console.WriteLine("Такой треугольник не может существовать!");
        return false;
    }
}

string Type(int a, int b, int c)
{
    string type = string.Empty;
    if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
        type = "прямоугольным.";
    else if (a == b && b == c && a == c)
        type = "равносторонним.";
    else if (a == b || a == c || b == c)
        type = "равнобедренным.";
    else type = "обычным треугольником.";
    return type;
}

void Ugol(int a, int b, int c)
{
    double cosAB;
    double cosBC;
    double cosAC;

    cosBC = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
    cosAB = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);
    cosAC = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);

    double angleAB = Math.Acos(cosAB);
    double angleBC = Math.Acos(cosBC);
    double angleAC = Math.Acos(cosAC);

    Console.WriteLine("Углы треугольника: ");
    Console.WriteLine($"AB = {Math.Round(angleAB * 180 / Math.PI, 1)} градусов;");
    Console.WriteLine($"BC = {Math.Round(angleBC * 180 / Math.PI, 1)} градусов;");
    Console.WriteLine($"AC = {Math.Round(angleAC * 180 / Math.PI, 1)} градусов.");
}

void Perimetr(int a, int b, int c)
{
    Console.WriteLine($"Периметр = {a + b + c};");
}

void Ploshad(int a, int b, int c)
{
    double temp = (a + b + c) / 2;
    double result = Math.Sqrt(temp * ((temp - a) * (temp - b) * (temp - c)));
    Console.WriteLine($"Площадь = {Math.Round(result, 2)};");
}



Console.WriteLine("Введите длинну стороны A треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну второй B треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны C треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());

bool istraingle = IsTraingle(a, b, c);

if (istraingle)
{
    Console.WriteLine($"Треугольник может существовать и является {Type(a, b, c)}");
    Ploshad(a, b, c);
    Perimetr(a, b, c);
    Ugol(a, b, c);
}