// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Получение данных от пользователя и преобразование в число.
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

// Метод сортировки элементов по убыванию.
int[,] SortMaxMinArray(int[,] arr)
{
    // Создаем новый одномерный массив(line). 
    int[] line = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             line[j] = arr[i, j];
        }
        SortPast(line);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = line[j];
        }
    }
    return arr;
}

// Метод вставки для сортировки двумерного массива построчно.
void SortPast(int[] line)
{
    for (int i = 1; i < line.Length; i++)
    {
        int buf = line[i];
        int k = i;
        while (k > 0 && buf > line[k - 1])
        {
            line[k] = line[k - 1];
            k--;
        }
        line[k] = buf;
    }
}

// Описание программы.
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Gen2DArray(row, column, 0, 99);
Print2DArray(arr2D);
Console.WriteLine();

int[,] sortArr = SortMaxMinArray(arr2D);
Print2DArray(sortArr);
