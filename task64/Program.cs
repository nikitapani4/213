int N = GetN("Введите значение N: ","Ошибка ввода данных!");

Console.Write($"{N} --> {NaturalNumbersN(N,1)}");



int GetN(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int numb);
        if(isCorrect && numb > 0) 
            return numb;
        Console.WriteLine(errorMessage);
    }
}

string NaturalNumbersN(int num, int one)
{
    if(num == one)
        return num.ToString(); 
    return num + " " + NaturalNumbersN(num - 1, one);
}
