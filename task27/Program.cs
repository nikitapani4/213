int num = GetNumberFromUser("Введите число: ", "Ошибка ввода!");


int SumInNumber = GetSumInNumber(num);


Console.WriteLine($"Сумма цифр числа {num} = {SumInNumber}");


int GetSumInNumber(int num)
{
    int sum = 0;
    if (num < 0)
        num = num * -1;

    while (num > 0)
    {
        sum = sum + num%10;
        num = num / 10;
    }
    return sum;
}

int GetNumberFromUser(string message, string errorMessage)
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