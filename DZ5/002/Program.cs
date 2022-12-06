// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];
int sumX = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write($"{arr[i]} ");

    if(i % 2 != 0) sumX += arr[i];
}

Console.WriteLine();
Console.WriteLine(sumX);
