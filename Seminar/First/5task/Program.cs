Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int razr = (int)Math.Log10(num) + 1; // количество разрядов
Console.WriteLine(razr); 
int multiplier = (int)Math.Pow(10, razr - 3); // множитель 3 слева разряда
Console.WriteLine(multiplier); 
int result = num % (10 * multiplier) / multiplier; 
Console.WriteLine(result);