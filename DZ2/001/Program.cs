﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int a = new Random().Next(100, 999);

Console.WriteLine(a);

int result = (a % 100) / 10;

Console.WriteLine(result);