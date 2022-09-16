//===============================================================================
// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю
//===============================================================================

// Метод ввода данных
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "");
    // Возвращаем значение
    return number;
}

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop);
    }
    return array;
}

// Печатаем массив
void Print1DArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

//Подсчитываем количество четных элементов массива
int UnevenSumPosition(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        count += arr[i];
    }
    return count;
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrLength = ReadData("Введите длину массива: ");
int startBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int stopBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = GenArray(arrLength, startBorder, stopBorder);
//int[] arr = GenArray(inputArray);
Print1DArray(inputArray);

int sum = UnevenSumPosition(inputArray);
PrintResult("Сумма элементов массива, стоящих на нечётных позициях: " + sum);
