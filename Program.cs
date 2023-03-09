using System;

int numb = InputNumber("Введите число: ");
int j = 1;

while (j <= numb)
{
    Console.Write($"{ThirdDegree(j)} ");
    j = j + 1;
}

int ThirdDegree(int N)
{
    int i = 1;
    int A = N;
    while (i < 3)
    {
        N = N * A;
        i = i + 1;
    }
    return N;
}

int InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine() ?? "");
    }
    catch (System.Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}