int[] array = new int [8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    int length = array.Length;
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 20 + 1);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}