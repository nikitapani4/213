int M = GetM("Введите значение числа M: ", "Ошибка ввода данных");
int N = GetN("Введите значение числа N: ", "Ошибка ввода данных");

Console.WriteLine(AckermannFun(M, N));



int GetN(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int n);
        if(isCorrect && n >= 0) 
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
        if(isCorrect && m >= 0) 
            return m;
        Console.WriteLine(errorMessage);
    }
}

int AckermannFun(int valM, int valN)
{
    if(valM == 0)
        return ++valN;
    if(valM > 0 && valN == 0)
        return AckermannFun(--valM, 1);
    return AckermannFun(--valM, AckermannFun(++valM, --valN));
    
}