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
Console.WriteLine();
double[,] arr2D = new double[row, column];
Console.WriteLine("Сгенерированный массив: ");
Print2DArray(Gen2DArray(arr2D));
Console.WriteLine();
// Искомое значение по диагонали и вертикали "-1", так как нумерация начинается с 0.
int x = (ReadData("Введите искомое значение по диагонали: ")-1);
int y = (ReadData("Введите искомое значение по вертикали: ")-1);
Console.WriteLine();
double findElem = FindElement(arr2D);
PrintResult("Значение искомого элемента: ", findElem);
Console.WriteLine();
Print2DColorArr(Gen2DArray(arr2D));

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив числами Фибоначи
double[,] Gen2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr2D[i, j] = Fibonacci(i*matr.GetLength(1)+j); 
        }
    }
    return arr2D;
}

// Печать двумерного массива.
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Печать двумерного массива.
void Print2DColorArr(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == x && j== y)
            {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{matr[i, j]} ");
            Console.ResetColor(); 
            }
            else {Console.Write($"{matr[i, j]} ");}
        }
        Console.WriteLine();
    }
}

// Поиск элемента в массиве.
double FindElement(double[,] array2D)
{
    if ((x < array2D.GetLength(0)) && (y < array2D.GetLength(1)))
    {
        return array2D[x, y];        
    }
    else {return -1;}
}

// Метод вывода на печать.
void PrintResult(string prefix, double data)
{
    double element = FindElement(arr2D);
    if (element == -1)
    {
        Console.WriteLine("Запрашиваемый элемент не существует в рамках данного массива.");
    }
    else
    {
        Console.WriteLine(prefix + data);
    }
}

// Рассчитаем числа Фибоначчи
double Fibonacci(int n)
{
    if (n == 0 || n == 1) return 1;       
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
