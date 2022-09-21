// Задача №48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ =m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнения двумерного массива.
int[,] Gen2DArrMN(int M, int N)
{
    int[,] arr2D = new int[M, N];
    System.Random rnd = new System.Random();

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            arr2D[i, j] = i + j;
        }
    }
    return arr2D;
}

// Печать двумерного массива монохром.
int [,] Print2DArray(int[,] matr)
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

// Мой вариант решения по образцу с доски.
int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");

Print2DArray(Gen2DArrMN(m,n));

// // Заполняем массив (вариант  решения Евгения).
// int[,] Fill2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i + j;
//         }
//     }
//     return matr;
// }

// int m = ReadData("Введите количество столбцов");
// int n = ReadData("Введите количество строк");
// int[,] matrix = new int[m, n];

// matrix = Fill2DArray(matrix);
// Print2DArray(matrix);