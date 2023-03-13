int A = GetNumberAFromUser("Введите число A: ", "Ошибка ввода!");
int B = GetNumberBFromUser("Введите число B: ", "Ошибка ввода!");


int PowerToB = GetPowerToB(A,B);


Console.WriteLine($"{A}^{B} = {PowerToB}");

int GetPowerToB(int A, int B)
{
    int pow = 1;
    while (B > 0)
    {
        pow = pow * A;
        B = B - 1;
    }
    return pow;
}

int GetNumberAFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

int GetNumberBFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}