// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write($"Введите челое число M: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write($"Введите челое число N: ");
int n = int.Parse(Console.ReadLine() ?? "");
int result = Akkerman(m, n);

Console.Write($"m = {m}; n = {n} -> A({m},{n}) = ");
Console.WriteLine(result);

static int Akkerman(int m, int n)
{
    while (m != 0)
    {
        m -= 1;
        if(n == 0)
            n = 1;
        else
            n = Akkerman(m + 1, n - 1);
    }
    return n + 1;
}