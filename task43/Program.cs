double b1 = GetUserNumb("Введите значение B1: ", "Ошибка ввода данных!");
double k1 = GetUserNumb("Введите значение K1: ", "Ошибка ввода данных!");
double b2 = GetUserNumb("Введите значение B2: ", "Ошибка ввода данных!");
double k2 = GetUserNumb("Введите значение K2: ", "Ошибка ввода данных!");

double X = GetX(b1, k1, b2, k2);
double Y = GetY(b1, k1, X);

Console.WriteLine($"Точка пересечения 2 прямых имеет координаты ({X};{Y})");


double GetUserNumb(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double res);
        if (isCorrect)
            return res;
        Console.WriteLine(errorMessage);
    }
}

double GetX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    Console.WriteLine(x);
    return x;
}

double GetY(double b1, double k1, double x)
{
    double y;
    y = k1 * x + b1;
    return y;
}