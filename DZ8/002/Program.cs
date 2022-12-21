// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
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

int SumInLine(int[,] array, int i)
{
  int sumLine = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i, j];
  }
  return sumLine;
}

int[,] array = FillArray(3, 4);
PrintArray(array);

int minLine = 0;
int sumLine = SumInLine(array, minLine);
for (int i = 0; i < array.GetLength(0); i++)
{
  int tempSumLine = SumInLine(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minLine = i;
  }
}
Console.WriteLine($"{minLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");