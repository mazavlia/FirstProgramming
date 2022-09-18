﻿//========================================================================================
// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено
//========================================================================================

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}

int Count(int m)
{
    int res = 0;
    for (int i = 0; i < m; i++)
    {
        int num = ReadData("Введите число: ");
        if (num > 0) res++;
    }
    return res;
}

// PrintResult("Количество положительных чисел: ", Count(ReadData("Введите количество чисел: ")));


PrintResult("Количество положительных чисел: ", Count(ReadData("Введите количество чисел: ")).ToString());
