// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

char[] arr = num.ToString().ToCharArray();

if (arr.Length == 5)
{
    if (arr[0] == arr[arr.Length - 1] && arr[1] == arr[arr.Length - 2])
    {
        Console.WriteLine($"число {num} - палиндром");
    }
    else
    {
        Console.WriteLine($"число {num} - не палиндром");
    }
}
else
{
    Console.WriteLine($"число {num} - не 5-значное");
}