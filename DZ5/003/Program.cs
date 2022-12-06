// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] arr = new double[10];
double sumX = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(new Random().Next(1, 100) + new Random().NextDouble(), 2);
    Console.Write($"{arr[i]} ");
}

double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}
Console.WriteLine();
Console.WriteLine($"max {max}, min {min}");

Console.WriteLine(Math.Round(max - min, 2));
