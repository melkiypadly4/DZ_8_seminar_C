// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
                System.Console.Write("|" + 0 + arr[i, j] + "|");
            else
                System.Console.Write("|" + arr[i, j] + "|");
        }
        System.Console.WriteLine();
    }
}
void SpiralArray(int[,] matrix)
{
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == 0)
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = count;
                count++;
            }
    }
    for (int j = 3; j < matrix.GetLength(1); j++)
    {
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = count;
            count++;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == 3)
            for (int j = 2; j >= 0; j--)
            {
                matrix[i, j] = count;
                count++;
            }
    }
    for (int j = 0; j < matrix.GetLength(1); j++)
        if (j == 0)
        {
            for (int i = 2; i >= 1; i--)
            {
                matrix[i, j] = count;
                count++;
            }
        }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == 1)
            for (int j = 1; j < matrix.GetLength(1) - 1; j++)
            {
                matrix[i, j] = count;
                count++;
            }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == 2)
            for (int j = 2; j >= 1; j--)
            {
                matrix[i, j] = count;
                count++;
            }
    }
   
}
int[,] matrix = new int[4, 4];
SpiralArray(matrix);
PrintMatrix(matrix);