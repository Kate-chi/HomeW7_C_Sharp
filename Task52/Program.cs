/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
int min = 1;
int max = 9;

int[,] array2D = new int[rows, columns];
double[] result = new double[columns];

Fill2DArrRandomNum(array2D);
Print2DArr(array2D);
Console.WriteLine();

FindAverageInColumnsArr(array2D, result);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArr(result);

void FindAverageInColumnsArr(int[,] arr, double[] result)
{
    double sum = 0;
    double average = 0;
    
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int k = 0; k < arr.GetLength(0); k++)
        {
            sum += arr[k, j];
            average = sum / rows;
        }
        result[j] = average;
        sum = 0;
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

void PrintArr(double[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);

        if(i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}