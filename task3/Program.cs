// Найти сумму элементов от M до N, N и M заданы

int SummElements(int m, int n)
{
    return m == n ? m : m + SummElements(m + 1, n);
}

int summ = SummElements(3, 11);
Console.WriteLine($"Сумма элементов равна {summ}");