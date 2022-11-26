int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано случайное число {num}");

int result = num / 100; // 3 цифра (количество сотен)
int result1 = num % 10; // 1 цифра (количество единиц)
Console.WriteLine($"{result}{result1}");