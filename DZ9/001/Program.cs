// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowList(int num)
{
    if (num > 0)
    {
        Console.Write($"{num} ");
        num--;
        ShowList(num);
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0) Console.WriteLine("введите число больше 0");
else ShowList(N);
