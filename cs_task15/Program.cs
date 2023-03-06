using System;

Console.Write("Введите номер дня недели: ");

int numbWeek = int.Parse(Console.ReadLine());
bool result = (numbWeek == 6) || (numbWeek == 7);

if (result)
{
    Console.Write($"День {numbWeek} - выходной день!");
}
else
{
    Console.Write($"День {numbWeek} - рабочий день!");
}