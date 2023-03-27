int row1 = GetRow("Укажите количество строк для матрицы 1: ", "Ошибка ввода данных!");
int column1 = GetColumn("Укажите количество столбцов для матрицы 1: ", "Ошибка ввода данных!");
int row2 = GetRow("Укажите количество строк для матрицы 2: ", "Ошибка ввода данных!");
int column2 = GetColumn("Укажите количество столбцов для матрицы 2: ", "Ошибка ввода данных!");
int[,] array1 = GetArray(row1, column1);
int[,] array2 = GetArray(row2, column2);
int[,] multiArr = MultiArray(array1, array2);

PrintArray(array1);
Console.WriteLine("**************");
PrintArray(array2);
Console.WriteLine("==============");
PrintArray(multiArr);

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
        if (isCorrect && col > 0)
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

int[,] MultiArray(int[,] arr1, int[,] arr2)
{
    try
    {
        int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
        int multi;
        int sum;
        for(int i = 0; i < arr3.GetLength(0); i++)
        {
            
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                sum = 0;
                for(int r = 0; r < arr1.GetLength(1); r++)
                {
                    multi = 0;
                    multi = arr1[i,r] * arr2[r,j];
                    sum += multi;
                }
                arr3[i,j] = sum;
            }

        }
        return arr3;
    }
    catch
    {
        Console.WriteLine($"Ошибка! Количество столбцов 1 матрицы должно быть равно количеству строк 2 матрицы!");
        int[,] errorArr = new int [1,1];
        errorArr[0,0] = -1;
        return errorArr;
    }
}