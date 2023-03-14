using System;

int size = GetSize("Введите размер массива: ", "Ошибка ввода данных!");
double[] array = GetArray(size);
double DiffNumb  = GetDiffNumb(array);

Console.Write($"Разница между максимальным и минимальным элементами в массиве {String.Join(" ", array)} --> {DiffNumb}");



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

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }

    return res;
}

double GetDiffNumb(double[] array)
{
    int size = array.Length;
    double minNum = array[0];
    double maxNum = array[1];

    if (minNum > maxNum)
    {
        minNum = array[1];
        maxNum = array[0];
    }

    double diffNumb = 0;

    for (int i = 2; i < size; i++)
    {
        if (array[i] < minNum)
            minNum = array[i];
        if (array[i] > maxNum)
            maxNum = array[i]; 
    } 

    diffNumb = maxNum - minNum;

    Console.WriteLine($"Минимальное значение: {minNum}");
    Console.WriteLine($"Максимальное значение: {maxNum}");

    return diffNumb;
}