// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

void SortArrayLines(int[,] array, int i)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        // Console.WriteLine($"i {i} j {j} {array[i, j]} {array[i, j + 1]}");
        if (array[i, j] < array[i, j + 1])
        {
            // (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
            int temp = array[i, j];
            array[i, j] = array[i, j + 1];
            array[i, j + 1] = temp;
            // Console.WriteLine($"i {i} j {j} {array[i, j]} {array[i, j + 1]}");
        }
    }
}

int[,] array = FillArray(3, 4);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    SortArrayLines(array, i);
}

Console.WriteLine();
PrintArray(array);

