int row = GetRow("Укажите количество строк: ", "Ошибка ввода данных!");
int column = GetColumn("Укажите количество столбцов: ", "Ошибка ввода данных!");
int[,] array = GetArray(row, column);
int[] arraySum = ArrSumRow(array);

PrintArray(array);

int minSum = MinSumArr(arraySum);

//Console.Write($"{String.Join(" ", arraySum)}");

Console.WriteLine($"Строка, имеющая наименьшую сумму элементов --> {minSum + 1}");

int GetRow(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int rows);
        if (isCorrect && rows > 0)
            return rows;
        Console.WriteLine(errorMessage);
    }
}

int GetColumn(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int col);
        if (isCorrect && col > 0 && row != col)
            return col;
        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int n, int m)
{
    int[,] arr = new int [n,m];
    for (int  i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
    return arr;
}

void PrintArray(int[,] Arr)
{
    for (int  i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write($"{Arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] ArrSumRow(int[,] arr)
{
    int[] sumarr = new int [arr.GetLength(0)];
    int sumR = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumR = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumR += arr[i,j];
        }
        sumarr[i] = sumR;
    }
    return sumarr;
}

int MinSumArr(int[] arr1)
{
    int min = arr1[0];
    int minInd = 0;
    for(int i = 1; i < arr1.GetLength(0); i++)
    {
        if(arr1[i] < min)
        {
            min = arr1[i];
            minInd = i;
        }
        
    }
    return minInd;
}

