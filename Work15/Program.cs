﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int num;
Console.WriteLine($"Введите цифру от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out num);
if (num == 1)
{
    Console.WriteLine($"{num} -> нет");
}
else if (num == 2)
{
    Console.WriteLine($"{num} -> нет");
}
else if (num == 3)
{
    Console.WriteLine($"{num} -> нет");
}
else if (num == 4)
{
    Console.WriteLine($"{num} -> нет");
}
else if (num == 5)
{
    Console.WriteLine($"{num} -> нет");
}
else if (num == 6)
{
    Console.WriteLine($"{num} -> да");
}
else if (num == 7)
{
    Console.WriteLine($"{num} -> да");
}
