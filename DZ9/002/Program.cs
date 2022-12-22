// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sumAll = 0;
int sum = 0;

int SumElements(int numM, int numN)
{
    sum = sumAll;
    if (numM <= numN)
    {
        sumAll += numM;
        numM++;
        return SumElements(numM, numN);
    }  else return sum;
}

if (M > N) Console.WriteLine("M > N");
else Console.WriteLine($"сумма элементов {SumElements(M, N)}");

