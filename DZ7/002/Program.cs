// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(4, 3);
PrintArray(array);

Console.Write("Введите номер строки в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if ((row > array.GetLength(0) - 1) || (column > array.GetLength(1) - 1))
{
    Console.WriteLine("Такого числа в массиве нет");
} 
else{
    Console.WriteLine($"строка {row}, столбец {column} - значение {array[row, column]}");
}