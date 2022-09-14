﻿//===============================================================================
// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//===============================================================================
// * Сделать оценку времени алгоритма через вещественные числа и строки
//===============================================================================


int ReadData(string line)
{
    // Выводим сообщение.
    Console.WriteLine(line);
    //Считываем число.
    int inputNumber = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение.
    return inputNumber;
}

// Метод %10, /10
int SumDigit(int num)
{
    int sum = 0; 
    while(num> 0)
{
    sum += num%10;
    num = num/10;
}
    return sum;
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Печать метода %10, /10.
int num = ReadData("Введите число: ");
int res = SumDigit(num);
PrintResult("Сумма цифр в числе: " + res);
DateTime d = DateTime.Now;
Console.WriteLine(DateTime.Now - d);
