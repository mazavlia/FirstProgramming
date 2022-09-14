//================================================================
// Задача №30. Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном порядке.
// Например: [1,0,1,1,0,1,0,0]
//================================================================

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine()??"");
    // Возвращаем значение 
    return number;
}

int[] GenArray(int arrLength)
{
//Заказали тип: массив (int[], дали название array, new - выделили опер.память, создали массив arrLength)    
    int[] array = new int [arrLength];
    Random ren = new Random();
    // создаем Random, который генерирует случайные числа
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

// Сокращенный способ описания вывода на печать.
PrintArray(GenArray(ReadData("Введите длину массива: ")));

// Подробный способ вывода на печать 
int arrLen = ReadData("Введите длину массива: ");
int [] array = GenArray(arrLen);
PrintArray(array);