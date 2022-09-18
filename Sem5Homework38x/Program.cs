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

// Заполняем массив
int[] GenArray(int arrayLength, int start, int stop)
{
    int[] array = new int[arrayLength];
    Random ren = new Random();

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = ren.Next(start, stop);
    }
    return array;
}

// Находим разницу между минимальным и максимальным значением массива
int MinMax(int[] arr)
{
    int max = int.MinValue;
    int min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max) {max = arr[i];}
        if (arr[i]<min) {min = arr[i];}
    }
    int result = max - min;
    return result;
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

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, меняющий 2 элемента местами
void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

// Сортировка массива методом вставки
int[] InsertionSort(int[] inArray)
{
    int x = 0;
    int j = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        x = inArray[i];
        j = i;
        while (j > 0 && inArray[j - 1] > x)
        {
            Swap(inArray, j, j - 1);
            j -= 1;
        }
        inArray[j] = x;
    }
    return inArray;
}

// Сортировка массива методом подсчета
int[] methodOfCalculation(int[] sortedArray)
{
    int k = 0;
    for (int i = 0; i < sortedArray.Length; i++)
    {
        k = 0;
        for (int j = 0; j < sortedArray.Length; j++)
        {
            if (sortedArray[i] > sortedArray[j])
                k++;
        }
        sortedArray[k] = sortedArray[i];
    }
return sortedArray;
}

// // сортировка подсчётом (от преподавателя)
// int[] countingSort(int[] arr, int min, int max)
// {
// int[] count = new int[max - min + 1];
// int z = 0;
// for (int i = 0; i < arr.Length; i++)
// {
// count[arr[i] - min]++;
// }
// for (int i = min; i <= max; i++)
// {
// while (count[i - min]-- > 0)
// {
// arr[z] = i;
// z++;
// }
// }
// return count;
// }



int arrLength = ReadData("Введите длину массива: ");
int startBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int stopBorder = ReadData("Введите верхнюю границу заполнения массива: ");

//Метод сравнения элементов
int[] inputArray = GenArray(arrLength, startBorder, stopBorder);
Print1DArray(inputArray);
int res1 = MinMax(inputArray);
PrintResult("Разница между max и min элементами массива методом сравнения элементов: " + res1);
DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);

//Метод вставки
int[] inputPast = InsertionSort(inputArray);
Print1DArray(inputPast);
int res2 = inputPast[inputPast.Length-1]-inputPast[0];
PrintResult("Разница между max и min элементами массива методом вставки: " + "\t" + "\t" + res2);
DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now - d2);

//Метод подсчета
int[] inputCalc = methodOfCalculation(inputArray);
Print1DArray(inputCalc);
int res3 = inputCalc[inputCalc.Length-1]-inputCalc[0];
PrintResult("Разница между max и min элементами массива методом подсчета: " + "\t" + "\t" + res3);
DateTime d3 = DateTime.Now;
Console.WriteLine(DateTime.Now - d3);

// //Метод подсчета от преподавателя
// int[] countSort = countingSort(inputArray, startBorder, stopBorder);
// Print1DArray(countSort);
// int res4 = countSort[countSort.Length-1]-countSort[0];
// PrintResult("Разница между max и min элементами массива методом подсчета: " + "\t" + "\t" + res4);
// DateTime d4 = DateTime.Now;
// Console.WriteLine(DateTime.Now - d4);

