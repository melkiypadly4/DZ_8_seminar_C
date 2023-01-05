// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ArrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("|" + array[i, j] + "|");
        }
        System.Console.WriteLine();
    }
}

void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 5);
        }
    }
}
System.Console.WriteLine(" количество столбцов первой матрицы");
int columsFirstMatrix = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" количество строк первой матрицы");
int RousFirstMatrix = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" количество столбцов второй матрицы");
int columsSecondMatrix = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" количество строк второй матрицы");
int RousSecondMatrix = Convert.ToInt32(Console.ReadLine());
if (columsFirstMatrix == RousSecondMatrix)
{
    int[,] firstMatrix = new int[columsFirstMatrix, RousFirstMatrix];
    int[,] secondMatrix = new int[columsSecondMatrix, RousSecondMatrix];
    RandomArray(firstMatrix);
    RandomArray(secondMatrix);
    ArrayPrint(firstMatrix);
    System.Console.WriteLine();
    ArrayPrint(secondMatrix);
    int[,] newMatrix = new int[columsFirstMatrix, RousSecondMatrix];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int g = 0; g < firstMatrix.GetLength(1); g++)
            {
                sum += firstMatrix[i, g] * secondMatrix[g, j];
            }
            newMatrix[i, j] = sum;
        }
    }
    System.Console.WriteLine();
    ArrayPrint(newMatrix);
}
else
    System.Console.WriteLine("введенные Параметры массива не подходят для произведения матриц");