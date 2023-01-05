// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int SearchMinSumRous(int[,] matrix, int sum, int rousNumber , int sumMin)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumMin = sumMin + matrix[0, j];

    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sumMin > sum)
        {
            sumMin = sum;
            rousNumber = i;
        }
        sum = 0;
    }
    return rousNumber;
}
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
    return array;
}
Random rand = new Random();
int quantityrows = rand.Next(1, 9);
int quantitycolumns = rand.Next(1, 9);
int[,] matrix = CreateRandomArray(quantitycolumns, quantityrows, 1, 9);
ShowArray(matrix);
int sum = 0;
int sumMin = 0;
int rousNumber = 0;
int results = SearchMinSumRous(matrix, sum, rousNumber,sumMin);
System.Console.WriteLine($"строка с наименьшей суммой элементов - {results}");