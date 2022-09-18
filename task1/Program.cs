// Показать натуральные числа от N до 1, N задано

void Numbers (int n)
{
    if (n >= 1)
    {
        Console.Write($"{n} ");
        Numbers(n - 1);
    }
}

Numbers(15);