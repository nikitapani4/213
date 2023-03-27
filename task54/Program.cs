// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int row = GetRowColumn("Укажите количество строк: ", "Ошибка ввода данных!");
int column = GetRowColumn("Укажите количество столбцов: ", "Ошибка ввода данных!");
int[,] array = GetArray(row, column);

OrderArr(array);

int GetRowColumn(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int numb);
        if (isCorrect && numb > 0)
            return numb;
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
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("____________________________");
    return arr;
}

void OrderArr(int[,] arr)
{
    for (int  i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                if(arr[i,j] < arr[i,k] && k != j && j < k)
                {
                    int num = 0;
                    num = arr[i,j];
                    arr[i,j] = arr[i,k];
                    arr[i,k] = num; 
                }
            }
            
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}