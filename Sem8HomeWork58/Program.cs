// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Метод нахождения произведения двух матриц.
int[,] Multiplication(int[,] firstArr, int[,] secondArr)
{
    int[,] thirdArr = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    if (firstArr.GetLength(1) != secondArr.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя перемножить.");
    }
    else
    {        
        for (int i = 0; i < firstArr.GetLength(0); i++)
        {
            for (int j = 0; j < secondArr.GetLength(1); j++)
            {
                for (int k = 0; k < secondArr.GetLength(0); k++)
                {
                    thirdArr[i, j] += firstArr[i, k] * secondArr[k, j];
                }
            }
        }   
        Print2DArray(thirdArr);     
    }
    return thirdArr;
}

// Описание программы.
int row1 = ReadData("Введите количество строк в первой матрице: ");
int column1 = ReadData("Введите количество столбцов в первой матрице: ");

Console.WriteLine("Первая матрица");
int[,] firstArr2D = Gen2DArray(row1, column1, 0, 9);
Print2DArray(firstArr2D);

int row2 = ReadData("Введите количество строк во второй матрице: ");
int column2 = ReadData("Введите количество столбцов во второй матрице: ");

Console.WriteLine("Вторая матрица");
int[,] secondArr2D = Gen2DArray(row2, column2, 0, 9);
Print2DArray(secondArr2D);

Console.WriteLine("Произведение двух матриц:");
Multiplication(firstArr2D, secondArr2D);
