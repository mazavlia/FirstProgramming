// Задача №46
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Например:
// m = 3, n = 4.
// -1 4 8 19
// 5 -2 33 -2
// -77 3 8 1

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// // Вывод результата в консоль
// void PrintResult(string data)
// {
//     Console.WriteLine(data);
// }

// Универсальный метод генерации и заполнения двумерного массива.
int[,] Gen2DArray(int countRow, int countColumn, int start, int stop)
{
    int[,] array2D = new int[countRow, countColumn];
    System.Random rnd = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rnd.Next(start, stop + 1);
        }
    }
    return array2D;
}

// // Печать двумерного массива монохром.
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// // Печать двумерного массива голубым цветом.
// void Print2DColorArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = ConsoleColor.Blue;
//             Console.Write($"{matr[i, j]}\t");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};


// Печать двумерного разноцветного массива 
void Print2DColorArrayRnd(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write($"{matr[i, j]}\t");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Gen2DArray(row, column, 1, 100);
Print2DColorArrayRnd(arr2D);
