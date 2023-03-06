using System;

Console.Write("Введите число: ");

string strNumb = Console.ReadLine();
int len = strNumb.Length;
int numb = int.Parse(strNumb);
int a;

if (len < 3)
{
    Console.WriteLine("Число не имеет 3 цифры!");
}
else
{
    if (len == 3)
    {
        a = numb % 10;
        Console.WriteLine($"Третья цифра числа {strNumb} = {a}");
    }
    else
    {
        numb = numb / 10*(len - 3);
        a = numb % 10;
        Console.WriteLine($"Третья цифра числа {strNumb} = {a}");
    }
    
}