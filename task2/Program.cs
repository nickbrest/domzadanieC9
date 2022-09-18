// Показать натуральные числа от M до N, N и M заданы

void Numbers (int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        Numbers(m + 1, n);
    }
}

Numbers(7, 15);