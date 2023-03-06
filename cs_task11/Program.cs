using System;

Console.Write("Введите число: ");

int numb = int.Parse(Console.ReadLine());
int a;

numb = numb / 10;
a = numb % 10;

Console.WriteLine ($"Вторая цифра числа numb = {a}");