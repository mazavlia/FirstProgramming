//========================================================================================
// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например:
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.
//========================================================================================

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "");
    // Возвращаем значение
    return number;
}

// Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    // Генератор случайных чисел
    Random numSyntezator = new Random();
    //Заказали тип: массив (int[], дали название array, new - выделили опер.память, создали массив arrLength)
    int[] arr = new int[num];
    // Тест заданных границ
    if (downBorder < topBorder)
    {
        // создаем Random, который генерирует случайные числа/ Создаем массив.
        for (int i = 0; i<arr.Length; i++)
        {
            arr[i] = numSyntezator.Next(downBorder, topBorder+1);
        }
    }
    // Возвращаем результат
    return arr;
}

// Печатаем одномерный массив
void Print1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int[] NegativePositiveSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];
        }
        else
        {
            sums[1] += arr[i];
        }
    }
    return sums;
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLength, downBorder, topBorder);

Print1DArray(inputArray);

int[] sumArray = NegativePositiveSums(inputArray);

PrintResult("Сумма >0: " + sumArray[0]+ "; " + "Сумма <0: " + sumArray[1]);
Print1DArray(sumArray);

// string RandowArr(int lng, int from, int to)
// {
//   int[] array = new int[lng];
//   Random rnd = new Random();

//   int sunNeg =0;
//   int sunPos =0;
//   for(int i = 0; i < lng; i++)
//   {
//     array[i] = rnd.Next(from, to+1);
//     if(array[i]>0)sunPos+=array[i];
//     else sunNeg+=array[i];
//   }

//   return (string.Join(", ", array)+"\n "+sunPos+" "+sunNeg);
// }

// Console.Write(RandowArr(12,-9,9));
