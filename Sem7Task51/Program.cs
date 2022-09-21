// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнения двумерного массива.
int[,] Gen2DArray(int countRow, int countColumn, int start, int stop)
{
    int[,] array2D = new int[countRow, countColumn];
    System.Random rnd = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(start, stop + 1);
        }
    }
    return array2D;
}

// (int[,] matr) - на вход получаем массив;
// int - на выход получим целое число (сумму).
int SumDiagonale(int[,] array2D)
{
    int sum = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++) 
        { 
            if (i == j)
            {
                sum = sum + array2D[i, j];
            }
        }
    }
    return sum;
}

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

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, int line)
{
    Console.WriteLine(prefix + line);
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Gen2DArray(row, column, 1, 20);
Console.WriteLine("Сгенерированный массив: ");

Print2DArray(arr2D);
int sumDiag = SumDiagonale(arr2D);
PrintResult("Сумма элементов массива, расположенных на главной диагонали: ", sumDiag);

// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, печатает одномерный массив
// void Print2DArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
// //     }
// // }

// // Метод генерации и заполнения массива
// int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
// {
//     // Создаём массив
//     int[,] array2D = new int[rows, cols];

//     if (numMin < numMax)
//     {
//         // Заполняем массив
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 array2D[i, j] = new Random().Next(numMin, numMax + 1);
//             }
//         }
//     }

//     return array2D;
// }


// // Метод, принимает массив, возвращает сумму элементов с одинаковыми индексами
// int SumEqualIndexElements(int[,] arr)
// {
//     int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
//     int sum = 0;

//     for (int i = 0; i < length; i++)
//     {
//         sum += arr[i, i];
//     }

//     return sum;
// }

// int numMin = 10;
// int numMax = 99;
// int rows = ReadData("Введите количество строк: ");
// int cols = ReadData("Введите количество столбцов: ");

// int[,] array2D = Fill2DArray(rows, cols, numMin, numMax);

// Console.WriteLine($"Случайный массив {rows}x{cols}:");
// Print2DArray(array2D);

// Console.WriteLine($"Сумма элементов по главной диагонали: {SumEqualIndexElements(array2D)}");


// // Чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Печать результата
// void PrintResult(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }
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
// }
// // Ищем сумму диагонали
// int Change2DArray(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matr[i, j];
//             }

//         }
//     }
//     return sum;
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

// int m = ReadData("Введите количество столбцов: ");
// int n = ReadData("Введите количество строк: ");
// int[,] matrix = new int[m, n];

// Fill2DArray(matrix, 1, 9);
// Print2DArray(matrix);


// PrintResult("Сумма главной диагонали: ", Change2DArray(matrix).ToString());