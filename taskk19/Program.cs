Console.Write("Введите число: ");
string strN = Console.ReadLine();
int N = int.Parse(strN);

Palindrom(N);

int Multi(int A, int B)
{
    int C = 1;
    int D = 1;
    while (C < B)
    {
        D = D * A;
        C = C + 1;
    }

    return D;
}

void Palindrom(int N)
{       
    int numb = 0;
    int len = strN.Length;
    int N1 = N;

    while (len > 0)
    { 
        numb = numb + Multi(10, len)*(N % 10);
        N = N / 10;
        len = len - 1;
        //Console.WriteLine(numb);
    }

    if (N1 == numb)
    {
        Console.WriteLine($"Число {N1} является палиндромом!");
    }
    else
    {
        Console.WriteLine($"Число {N1} не является палиндромом!");
    }
}

