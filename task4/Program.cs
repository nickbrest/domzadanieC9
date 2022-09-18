// Найти сумму цифр числа

int SummDigits(int number)
{
    return number == 0 ? 0 : number % 10 + SummDigits(number / 10);
}

Console.WriteLine($"Сумма цифр заданного числа равна {SummDigits(7453)}");