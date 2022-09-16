//=================================================================================
// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька
//=================================================================================

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
int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(100, 1000);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
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
int EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (EvenTest(arr[i]))
        {
            count++;
        }

    }
    return count;
    }

//Проверка на четность
bool EvenTest(int even)
{
    return(even%2==0);
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrLength = ReadData("Введите длину массива: ");

int[] arr = GenArray(arrLength);
PrintArray(arr);

int index = EvenCount(arr);
PrintResult("Количество четных чисел в массиве: " + index);