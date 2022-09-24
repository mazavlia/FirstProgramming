// Задача №59 Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

//  Меняем строки со столбцами
int[,] Change2DArray(int[,] matr)
{
    int[,] matrix = new int[matr.GetLength(1), matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[j, i] = matr[i, j];
        }
    }
    return matrix;
}

// (int x, int y) MinFind(int[,] matr)
// {
//     int min = matr[0, 0];
//     x = 0;
//     y = 0;
//     if (min > matr[i, j])
//     {
//         min = matr[i, j];
//         x = i;
//         y = j;
//     }
//     return (x, y);
// }

void MinFind(int[,] matr, ref int x, ref int y)
{
    int min = matr[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
                x = i;
                y = j;
            }
        }
    }
}


int[,] Create2DArray(int[,] matr, ref int x, ref int y)
{
    int k = 0; int m = 0;
    int[,] matrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i == x)
        {

        }
        else
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (j == y)
                {

                }
                else
                {
                    matrix[k, m] = matr[i, j];
                    m++;
                }
            }
            k++;
            m = 0;
        }
    }
    return matrix;
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

int x = -1;
int y = -1;
MinFind(matrix, ref x, ref y);
Print2DArray(Create2DArray(matrix, ref x, ref y));

// // Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Заполняем массив случайными числами
// void Fill2DArray(int[,] matr, int min, int max)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// void FindMin(int[,] arr, ref int x, ref int y)
// {
//     int min = arr[0, 0];
//     x = 0; y = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (min > arr[i, j])
//             {
//                 min = arr[i, j];
//                 x = i;
//                 y = j;
//             }
//         }
//     }
// }

// int[,] CreateArr(int[,] arr, int x, int y)
// {
//     int k = 0; int m = 0;
//     int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         if (i == x)
//         {
//         }
//         else
//         {
//             m = 0;
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 if (j == y)
//                 {
//                 }
//                 else
//                 {
//                     outArr[k, m] = arr[i, j];
//                     m++;
//                 }
//             }
//             k++;
//         }
//     }
//     return outArr;
// }

// int[,] array2D = new int[4, 4];
// Fill2DArray(array2D, 0, 9);
// Print2DArray(array2D);
// int x = -1;
// int y = -1;
// FindMin(array2D, ref x, ref y);
// int[,] outArr = CreateArr(array2D, x, y);
// Print2DArray(outArr);