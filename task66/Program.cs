int M = GetM("Введите значение числа M: ", "Ошибка ввода данных");
int N = GetN("Введите значение числа N: ", "Ошибка ввода данных");

Console.WriteLine($"M = {M}; N = {N} --> {SumNaturalNumbersNM(M, N)}");

int GetN(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int n);
        if(isCorrect && n > 0) 
            return n;
        Console.WriteLine(errorMessage);
    }
}

int GetM(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int m);
        if(isCorrect && m > 0) 
            return m;
        Console.WriteLine(errorMessage);
    }
}

int SumNaturalNumbersNM(int valM, int valN)
{
    if(valM == valN)
        return valN;
    return valM + SumNaturalNumbersNM(++valM, valN);
}