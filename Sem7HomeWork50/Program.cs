//===========================================================================================
// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
//===========================================================================================

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Gen2DArray(row, column, 10, 99);
Console.WriteLine("Сгенерированный массив: ");
Print2DArray(arr2D);

// Искомое значение по диагонали и вертикали "-1", так как нумерация начинается с 0.
int x = (ReadData("Введите искомое значение по диагонали: ")-1);
int y = (ReadData("Введите искомое значение по вертикали: ")-1);

int findElem = FindElement(arr2D);
PrintResult("Значение искомого элемента: ", findElem);

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

// Поиск элемента в массиве.
int FindElement(int[,] array2D)
{
    if ((x < array2D.GetLength(0)) && (y < array2D.GetLength(1)))
    {
        return array2D[x, y];        
    }
    else {return -1;}
}

// Метод вывода на печать.
void PrintResult(string prefix, int data)
{
    int element = FindElement(arr2D);
    if (element == -1)
    {
        Console.WriteLine("Запрашиваемый элемент не существует в рамках данного массива.");
    }
    else
    {
        Console.WriteLine(prefix + data);
    }
}