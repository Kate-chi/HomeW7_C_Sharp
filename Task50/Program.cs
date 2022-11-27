/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. 
Во вводе первая цифра - номер строки, вторая - столбца.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
int min = 1;
int max = 9;

int[,] array2D = new int[rows, columns];

Fill2DArrRandomNum(array2D);
Print2DArr(array2D);

int position = InputNum("введите позицию элемента в двумерном массиве " +
                        "(при вводе первая цифра - номер строки, вторая - столбца): ");

IsInArray(array2D, position);

void IsInArray(int[,] arr, int numIndex)
{
    int findRows = numIndex / 10;
    int findCols = numIndex % 10;

    if(findRows <= rows && findCols <= columns)
    {
        Console.Write($"На заданной позиции находится число {arr[findRows - 1, findCols - 1]}");
    }
    else
    {
        Console.Write("Такого числа в массиве нет");
    }
    
}

void Fill2DArrRandomNum(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}