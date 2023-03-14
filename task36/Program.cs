using System;

int size = GetSize("Введите размер массива: ", "Ошибка ввода данных!");
int min = GetMin("Введите минимальное значение элемента: ", "Ошибка ввода данных!");
int max = GetMax("Введите максимальное значение элемента: ", "Ошибка ввода данных!");
int[] array = GetArray(size, min, max);

int sumElem = GetSumElem(array);

Console.Write($"Сумма элементов с нечетным индексом в массиве {String.Join(" ", array)} --> {sumElem}");


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
        bool isCorrect = int.TryParse(Console.ReadLine(), out int min);
        if (isCorrect)
            return min;
        Console.WriteLine(errorMessage);
    }
}

int GetMax(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int max);
        if (isCorrect && max > min)
            return max;
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

int GetSumElem(int[] array)
{
    int sumEl = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0)
            sumEl += array[i];
    }

    return sumEl;
}