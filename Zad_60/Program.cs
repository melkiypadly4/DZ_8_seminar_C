//  ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void ShowCube(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                System.Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})   ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}
void RandomCubeNumbers(int[,,] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int g = 0; g < arr.GetLength(2); g++)
            {
                arr[i, j, g] = new Random().Next(0 + count, 10 + count);
                count = count + 10;
            }
        }
    }
}
int SizeCube(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int height = SizeCube("Введите высоту куба");
int length = SizeCube("Введите длинну куба");
int width = SizeCube("Введите ширину куба");
int[,,] cube = new int[height, length, width];
RandomCubeNumbers(cube);
ShowCube(cube);