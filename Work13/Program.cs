// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int num;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

if (num >= 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int a1 = num % 10;
    Console.WriteLine($"{num} -> {a1}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}
