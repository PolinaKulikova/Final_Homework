﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число больше M");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int index = M;
while (index <= N)
{
    sum = sum + index;
    index++;
}
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна {sum}");