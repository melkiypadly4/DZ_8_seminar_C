// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void ShowArray(int[,] array)
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

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return;
}
Random rand = new Random();
int = rand.Next(1, 9);
int = rand.Next(1, 9);
int[,] matrix = CreateRandomArray(quantitycolumns, quantityrows, 1, 9);
ShowArray(matrix);

0   max = 0;
0 = = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int count = 0; count < matrix.GetLength(1) - 1; count++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {

            if (matrix[i, j] < matrix[i, j + 1])
            {
                bufer = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = bufer;
            }

        }
    }
}
System.Console.WriteLine();
ShowArray(matrix);
