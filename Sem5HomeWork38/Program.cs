//================================================================================
// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
//================================================================================

// Метод ввода целых чисел
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "");
    // Возвращаем значение
    return number;
}

// Метод ввода вещественных чисел
double ReadDataDouble(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    double number = double.Parse(Console.ReadLine() ?? "");
    // Возвращаем значение
    return number;
}

// Заполняем массив
double[] GenArray(int arrayLength, double start, double stop)
{
    double[] array = new double[arrayLength];
    Random ren = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = Math.Round(((ren.NextDouble())*100), 2);
    }
    return array;
}

// Находим разницу между минимальным и максимальным значением массива
double MinMax(double[] arr)
{
    //double sum = 0;
    double max = double.MinValue;
    double min = double.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max) {max = arr[i];}
        if (arr[i]<min) {min = arr[i];}
    }
    double result = Math.Round((max - min), 2);
    return result;
}

// Печатаем массив
void Print1DArray(double[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrLength = ReadData("Введите длину массива: ");
double startBorder = ReadDataDouble("Введите нижнюю границу заполнения массива: ");
double stopBorder = ReadDataDouble("Введите верхнюю границу заполнения массива: ");

double[] inputArray = GenArray(arrLength, startBorder, stopBorder);
Print1DArray(inputArray);

// double diff = MinMax(result);
// PrintResult("Разница между максимальным и минимальным элементами массива: " + diff);
//PrintResult(MinMax(arr));

double diff = MinMax(inputArray);
PrintResult("Разница между минимальным и максимальным элементом массива: " + diff);

