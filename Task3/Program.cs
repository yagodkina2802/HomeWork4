﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int [] collection)
{
    int index = 0;
    int length = collection.Length;
    while(index < length)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;

    }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);