// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int SumNums (int numIn)
{
    int numOut = 0;
    while (numIn > 0)
    {
        numOut += numIn % 10;
        numIn /= 10 ;
    }
    return numOut;
}

Console.Write("Введите число num: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNums(num));

