using System;

int size = GetSize("Введите размер массива: ", "Ошибка ввода данных!");
int min = GetMin("Введите минимальное значение(трехзначное): ", "Ошибка ввода данных!");
int max = GetMax("Введите максимальное значение(трехзначное): ", "Ошибка ввода данных!");

int[] array = GetArray(size, min, max);

int countEvenNumbers = GetEvenNumbers(array);

Console.Write($"Количество четных элементов в массиве {String.Join(" ", array)} --> {countEvenNumbers}");



int GetSize(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int size);
        if (isCorrect && size > 0)
            return size;
        Console.WriteLine(errorMessage);
    }
}

int GetMin(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int Min);
        if (isCorrect && Min > 99 && Min < 1000)
            return Min;
        Console.WriteLine(errorMessage);
    }
}

int GetMax(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int Max);
        if (isCorrect && Max > min && Max > 99 && Max < 1000)
            return Max;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }

    return res;
}

int GetEvenNumbers(int[] array)
{
    int size = array.Length;
    int evenNumbCount = 0;
    foreach ( int el in array)
    {
        if (el % 2 == 0)
            evenNumbCount++;
    } 

    return evenNumbCount;
}