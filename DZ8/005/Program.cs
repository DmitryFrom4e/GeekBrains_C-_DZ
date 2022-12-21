// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void FillArray(int[,] array)
{
    int number = 1;
    int square = array.GetLength(0) * array.GetLength(1);
    int row = 0, col = 0;
    while (number <= square)
    {
        array[row, col] = number;
        number++;
        if (row < col && row + col >= array.GetLength(0) - 1)
            row++;
        else if (row <= col + 1 && row + col < array.GetLength(1) - 1)
            col++;
        else if (row >= col && row + col > array.GetLength(1) - 1)
            col--;
        else
            row--;
    }
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

int[,] array = new int[4, 4];
FillArray(array);
Console.WriteLine();
PrintArray(array);