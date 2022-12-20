// посчитать сумму всех целых чисел от 1 до N , где N вводится с клавиатуры

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {N} = {Summa(N)}");
Console.WriteLine($"Сумма чисел от 1 до {N} = {SummaRec(N)}");



int Summa(int N)
{
    int res = 0;
    while (true)
    {
        res += N;
        N--;
        if (N == 0)
            break;
    }
    return res;
}

int SummaRec(int N)
{
    if (N == 0) return 0;
    return N + SummaRec(N - 1);
}