// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.

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
            array2D[i,j] = rnd.Next(start, stop + 1);
        }
    }
    return array2D;
}

// Печать двумерного массива.
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Печатаем массив
void Print1DArray(double[] arr)
{
    Console.Write(arr[0] + "\t");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]+"\t");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine();
}

double[] Count(int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            sum = sum + arr2D[i, j];
        }
        arr[j] = Math.Round(sum/arr2D.GetLength(0), 2);
        sum = 0;
    }     
    return arr;    
}

// Описание программы.
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Gen2DArray(row, column, 0, 99);
Print2DArray(arr2D);
double[] arr1D = Count(arr2D);
Print1DArray(arr1D);