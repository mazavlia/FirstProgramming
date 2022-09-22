// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Метод ввода целых чисел.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "");
    // Возвращаем значение
    return number;
}

// Универсальный метод генерации и заполнения двумерного массива.
double[,] Gen2DArray(int countRow, int countColumn, double start, double stop)
{
    double[,] array2D = new double[countRow, countColumn];
    System.Random rnd = new System.Random();

    for (int m = 0; m < countRow; m++)
    {
        for (int n = 0; n < countColumn; n++)
        {
            array2D[m, n] = Math.Round(((rnd.NextDouble()) * 100), 2);
        }
    }
    return array2D;
}

// Массив с описанием всех 16 цветов.
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
                                        
// Описание метода печати двумерного массива разным цветом посимвольно.
string PrintStringColored(string args)
{       
    foreach (char item in args)
    {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        Console.Write(item);
        Console.ResetColor();
    }
    return args;
}

// Печать двумерного массива посимвольно разными цветами.
double[,] Print2DArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            PrintStringColored(matr[m, n]+"\t");
        }
        Console.WriteLine();
    }
    return matr;
}

// Описание программы.
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

double[,] arr2D = Gen2DArray(row, column, 0, 99);

Console.WriteLine("Разноцветный массив с изменением цвета посимвольно: ");
Print2DArray(arr2D);
