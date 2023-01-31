﻿string[] arrayStrings = new string[] { };
Console.Write("Желаемое количество элементов: ");
int quantity = int.Parse(Console.ReadLine()!);
arrayStrings = new string[quantity];
for (int i = 0; i < arrayStrings.Length; i++)
{
    Console.Write($"{i + 1} строчный элемент: ");
    arrayStrings[i] = Console.ReadLine()!;
}
Console.WriteLine();
Console.WriteLine("Массив введённых данных");
Console.WriteLine($"{PrintArray(arrayStrings)}");
Console.WriteLine();
string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += "]";
    return result;
}
int length = 3;
int CheckArray(string[] array, int length)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}
int smallElements = CheckArray(arrayStrings, length);
Console.WriteLine("Колличество элементов где lenght = 3 or lenght < 3");
Console.WriteLine(smallElements);