int[,] array = new int [4,4];

array = SpiralArray(array);
PrintArray(array);


int[,] SpiralArray(int[,] arr)
{
    int i = 0;
    int j = 0;
    int val = 1;
    int size = arr.GetLength(0);
    while(size/2 > 0)
    {
        int k = 0;
        do 
        {
            arr[i,j] = val;
            j++;
            val++;
        }
        while(++k < size - 1);

        for (k = 0; k < size-1; k++)
        {
            arr[i,j] = val;
            i++;
            val++;
        }

        for (k = 0; k < size-1; k++)
        {
            arr[i,j] = val;
            j--;
            val++;
        }


        for (k = 0; k < size-1; k++)
        {
            arr[i,j] = val;
            i--;
            val++;
        }

        i++;
        j++;
        size = size - 2;
    }
    return arr;
}


void PrintArray(int[,] Arr)
{
    for (int  i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write($"{Arr[i,j]}\t ");
        }
        Console.WriteLine();
    }
}