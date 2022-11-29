// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Dist(int  x1, int  x2, int y1, int y2, int z1, int z2)
// {
//     double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
//     Console.WriteLine($"Расстояние между точками = {Math.Round(distance, 2)}");
// }

// try
// {
//     Console.Write("Введите координаты x координату точки A: ");
//     int x1 = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите координаты y координату точки A: ");
//     int y1 = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите координаты z координату точки A: ");
//     int z1 = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите координаты x координату точки B: ");
//     int x2 = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите координаты y координату точки B: ");
//     int y2 = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите координаты z координату точки B: ");
//     int z2 = Convert.ToInt32(Console.ReadLine());
    
//     Dist(x1, x2, y1, y2, z1, z2);
// }

// catch
// {
//     Console.WriteLine("Проверьте правильность ввода данных");
// }

// Console.Write("Введите координаты x координату точки A: ");
// int[] str = Console.ReadLine().Split().Select(int.Parse).ToArray();
// Console.Write( str);э

Console.Write("Введите количество измерений: ");
int dim = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки A: ");
int[] a = Console.ReadLine().Split(' ');
               int a1 = int.Parse(a[0]);
               int a2 = int.Parse(a[1]);
               int a3 = int.Parse(a[3]);
Console.Write($"{b} и {a}");




