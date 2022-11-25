// Задача 6: Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число num ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;

if (result == 0)
{
    Console.WriteLine($"Число {num} четное");
}
else
{
    Console.WriteLine($"Число {num} нечетное");
}