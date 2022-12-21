// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int MultiplyMatrix(int[,] matr1, int[,] matr2, int i, int j)
{
      int sum = 0;
      for (int k = 0; k < matr1.GetLength(1); k++)
      {
        sum += matr1[i, k] * matr2[k, j];
      }
      return sum;
}

int[,] matrix1 = FillArray(3, 4);
PrintArray(matrix1);

Console.WriteLine();
int[,] matrix2 = FillArray(4, 4);
PrintArray(matrix2);

Console.WriteLine();
int[,] matrixResult = new int[3, 4];
for (int i = 0; i < matrixResult.GetLength(0); i++)
{
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
        matrixResult[i, j] = MultiplyMatrix(matrix1, matrix2, i, j);
    }
}

PrintArray(matrixResult);

