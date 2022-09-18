// Написать программу возведения числа А в целую стень B

int PowerA(int a, int b)
{
    return b == 0 ? 1 : PowerA(a, b - 1) * a;
}
Console.WriteLine(PowerA(5, 4));