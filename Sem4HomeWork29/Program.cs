//=====================================================================================
// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов
//=====================================================================================

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine()??"");
    // Возвращаем значение 
    return number;
}

int[] GenArray(int arrLength, int start, int stop)
{

    Random ren = new Random();
//Заказали тип: массив (int[], дали название outArray, new - выделили опер.память, создали массив arrLength)    
    int[] outArray = new int [arrLength];
    // создаем Random, который генерирует случайные числа
    for (int i = 0; i < arrLength; i++)
    {
        outArray[i] = ren.Next(start, stop);
    }
    return outArray;
}

void PrintArray(int[] outArray)
{
    for (int i = 0; i < outArray.Length - 1; i++)
    {
        Console.Write(outArray[i] + ", ");
    }
    Console.WriteLine(outArray[outArray.Length - 1]);
}

// Подробный способ вывода на печать 

int arrLength = ReadData("Введите длину массива: ");
int start = ReadData("Введите минимальное значение: ");
int stop = ReadData("Введите максимальное значение: ");
PrintArray(GenArray(arrLength, start, stop));
