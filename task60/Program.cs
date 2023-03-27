int row = GetRow("Укажите количество строк: ", "Ошибка ввода данных!");
int column = GetColumn("Укажите количество столбцов: ", "Ошибка ввода данных!");
int depth = GetDepth("Укажите глубину массива: ", "Ошибка ввода данных!");

int[,,] array = GetArray(row, column, depth);

PrintArray(array);

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

int GetDepth(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int dep);
        if (isCorrect && dep > 0)
            return dep;
        Console.WriteLine(errorMessage);
    }
}

int[,,] GetArray(int x, int y, int z)
{
    int[,,] arr = new int [x,y,z];
    for (int  i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                while(true)
                {
                    int flag = 0;
                    Console.Write("Введите элемент массива: ");
                    bool isCorrect = int.TryParse(Console.ReadLine(), out int elem);
                    if (isCorrect && elem > 9 && elem < 100)
                    {
                        for (int  i1 = 0; i1 < arr.GetLength(0); i1++)
                        {
                            for (int j1 = 0; j1 < arr.GetLength(1); j1++)
                            {
                                for (int k1 = 0; k1 < arr.GetLength(2); k1++)
                                {
                                    if(arr[i1,j1,k1] == elem)
                                    {
                                        flag = 1;
                                        Console.WriteLine("Ошибка ввода данных!");
                                    }
                                }
                                
                            }
                            if(flag == 1)
                                break;
                        }
                        
                    if(flag == 0)
                    {
                        arr[i,j,k] = elem;
                        break;
                    }
                        
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода данных!");
                    }

                        
                    
                    
                }
            }
            
        }
    }
    return arr;
}

void PrintArray(int[,,] array1)
{
    for (int k = 0; k < array1.GetLength(2); k++)
    {
        for (int  i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array1.GetLength(1); j++)
                    {
                        Console.Write($"{array1[i,j,k]}({i},{j},{k})   ");
                    }
                    Console.WriteLine(); 
                }
    }
}