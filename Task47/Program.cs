/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");

double[,] array2D = new double[rows, columns];

Fill2DArrRandomDoubleNum(array2D);
Print2DArr(array2D);

void Fill2DArrRandomDoubleNum(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
}

void Print2DArr(double[,] arr)
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