﻿﻿// Задача 28: Напишите программу, которая принимает на вход число и выдает произведение чисел от 1 до N.
// 4 => 24
// 5 => 120

Console.Write("Введите число N: ");
int N= Convert.ToInt32(Console.ReadLine());
int sum = 1;

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"i = {i}");
    sum = sum * i;
}
Console.WriteLine($"Результат выполнения программы = {sum}");