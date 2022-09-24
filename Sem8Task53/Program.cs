// Задача №53
// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// // Универсальный метод генерации и заполнения двумерного массива.
// int[,] Gen2DArray(int countRow, int countColumn, int start, int stop)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     System.Random rnd = new System.Random();

//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = rnd.Next(start, stop + 1);
//         }
//     }
//     return array2D;
// }

// Печать двумерного массива монохром.
int[,] Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matr;
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

//  Меняем первую строку с последней местами
void Change2DArray(int[,] matr)
{
    //int[] arr = new int[matr.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];


Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);
Console.WriteLine();
Change2DArray(matrix);
Print2DArray(matrix);