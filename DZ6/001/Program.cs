// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int CountNums(int arrLen)
{
    int count = 0;
    int[] arr = new int[arrLen];
    for (int i = 0; i < arrLen; i++)
    {
        Console.Write("Введите число с клавиатуры: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0) count++;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return count;
}

Console.Write("Введите кол-во чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество чисел > 0 {CountNums(M)}");



