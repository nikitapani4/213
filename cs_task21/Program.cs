using System;

int x1 = InputCoord("Введите X1: ");
int y1 = InputCoord("Введите Y1: ");
int z1 = InputCoord("Введите Z1: ");
int x2 = InputCoord("Введите X2: ");
int y2 = InputCoord("Введите Y2: ");
int z2 = InputCoord("Введите Z2: ");
double dist = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)),2);

int InputCoord(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (System.Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

Console.Write($"Расстояние между точками A и B равно {dist}");

