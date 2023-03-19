int size = GetArraySize("Введите длиину массива: ", "Ошибка ввода данных!");


int[] array = GetArray(size, "Введите элемент массива: ", "Ошибка ввода данных!");

int positNumb = GetPositiveNumb(array);


Console.Write($"Количество чисел, больших нуля {String.Join(" ", array)} --> {positNumb}");


int GetArraySize(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int res);
        if (isCorrect && res > 0)
            return res;
        Console.WriteLine(errorMessage);
    }
    
}

int[] GetArray(int size, string message, string errorMessage)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        while(true)
        {
            Console.Write(message);
            bool isCorrect = int.TryParse(Console.ReadLine(), out int elem);
            if (isCorrect)
            {
                arr[i] = elem;
                break;
            }
            Console.WriteLine(errorMessage);
        }
    }

    return arr;
}

int GetPositiveNumb(int[] array)
{
    int countPositNumb = 0;
    foreach(int el in array)
    {
        if (el > 0)
            countPositNumb++;
    }

    return countPositNumb;
}