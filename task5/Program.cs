// Написать программу вычисления функции Аккермана A(n, m)

int Akkerman(int n, int m)
{
    return n == 0 ? m + 1 : n > 0 && m == 0 ? Akkerman(n - 1, 1) : Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine(Akkerman(3, 4));