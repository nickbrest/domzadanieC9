// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int PsevdoFib(int first, int second, int n)
{
    return n == 1 ? first : n == 2 ? second
    : PsevdoFib(first, second, n - 1) + PsevdoFib(first, second, n - 2);
}

void PrintFib(int first, int second, int n)
{
    for (int i = 1; i <= n; i++)
        Console.Write($"{PsevdoFib(first, second, i)} ");
}

PrintFib(7, 10, 9);
// (первый элемент, второй элемент, N)