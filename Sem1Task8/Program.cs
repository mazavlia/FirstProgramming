﻿//===========================================================================
// № 8 Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
//===========================================================================

// Вводим число N.
string? inputLineN = Console.ReadLine();

// Проверяем, что это число не "пустое".
if (inputLineN != null)
{

    // Присваиваем введенному значению N "целое" число (integer).        
    int inputNumberN = int.Parse(inputLineN);

    // Присваиваем первому четному числу значение 2.
    int number = 2;

    // Пока переменная number <= значения (inputNumberN - 2).
    while (number <= inputNumberN - 2)

    {
        // Если значение inputNumberN делится на 2 без остатка.
        if (inputNumberN % 2 == 0)
        {
            // Выводим на печать все значения number в 1 строку через запятую.
            Console.Write(number + ", ");

            // Присваиваем новое значение переменной number + 2.
            number += 2;
        }

        //Иначе (если делится на 2 с остатком) вычесть -1 из значения inputNumberN. 
        else inputNumberN -= 1;
    }

    // Печатаем последнее значение inputNumberN в строке без ",".
    Console.Write(inputNumberN);

}